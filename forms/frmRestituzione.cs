using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Biblioteca
{
    public partial class frmRestituzione : Form
    {
        private User myUser;
        private List<Prestito> myPrestiti;
        private static object locker = new Object();
        private int currentRating = 0;
        TaskCompletionSource<bool> tsc = null;
        public frmRestituzione(User user)
        {
            InitializeComponent();
            myUser = user;
            
            frmAdmin.OnPrestitiChange += FrmAdmin_OnPrestitiChange;
            Init();
            BindData();
        }

        private void FrmAdmin_OnPrestitiChange(object sender, EventArgs e)
        {
            Init();
            BindData();
        }

        private void Init()
        {
            if (Form1.prestiti != null)
            {
                myPrestiti = (from u in Form1.prestiti
                              where u.Prestiti.ContainsKey(myUser.CodiceFiscale)
                              select u).ToList();
            }
        }

        public delegate void Del();
        private void BindData()
        {
            if (this.dgvPrestiti.InvokeRequired)
            {
                Del d = new Del(BindData);
                this.Invoke(d);
            } else
            {

            dgvPrestiti.DataSource = null;
            dgvPrestiti.DataSource = myPrestiti.Select(p => new { Isbn = p.Isbn, Titolo = Form1.libriElenco[p.Isbn].Titolo , Scadenza = p.Prestiti[myUser.CodiceFiscale]}).ToList();
            }
        }

        private void dgvPrestiti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;
            if (grid[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
            {
                HandleRestituzione(grid[e.ColumnIndex + 1, e.RowIndex].Value.ToString());
                
            }
        }
        Form tmpForm;
        private void HandleRating()
        {
            tmpForm = new Form();
            components.Rating tmpRat = new components.Rating();
            tmpRat.RatingDone += TmpRat_RatingDone;
            tmpForm.Controls.Add(tmpRat);
            tmpForm.Show();
        }

        private void TmpRat_RatingDone(object sender, components.RatingEvent e)
        {
            tmpForm.Dispose();
            currentRating = e.NumberOfStars;
            tsc.TrySetResult(true);
        }

        private async void HandleRestituzione(string isbn)
        {          
            if (!FileIsLocked(Directory.GetCurrentDirectory() + @"\books.json"))
            {
                currentRating = 0;
                tsc = new TaskCompletionSource<bool>();
                HandleRating();
                
                await tsc.Task;
                
                WriteToFile(isbn);
            }   
        }

        public void WriteToFile(string isbn)
        {
            lock (locker)
            {
                
                FileStream file = new FileStream(Directory.GetCurrentDirectory() + @"\books.json", FileMode.Open, FileAccess.ReadWrite, FileShare.None);
                
                FileStream file3 = new FileStream(Directory.GetCurrentDirectory() + @"\users.json", FileMode.Open, FileAccess.ReadWrite, FileShare.None);
                Form1.libriElenco[isbn].Quantita++;
                StreamWriter writer = new StreamWriter(file, Encoding.Unicode);
                
                StreamWriter writer3 = new StreamWriter(file3, Encoding.Unicode);
                int totalVotanti = Form1.libriElenco[isbn].QuantitaVoti;
                float totalStars = Form1.libriElenco[isbn].MediaVoti * totalVotanti;
                totalVotanti++;
                totalStars += this.currentRating * 100;
                Form1.libriElenco[isbn].MediaVoti = totalStars / totalVotanti;
                Form1.libriElenco[isbn].QuantitaVoti = totalVotanti;
                writer.Write(String.Empty);
                string output = JsonConvert.SerializeObject(Form1.libriElenco, Formatting.Indented);
                writer.Write(output);
                writer.Close();

                if (Form1.prestiti != null)
                {

                    int position = Form1.prestiti.Select((item, i) => new
                    {
                        Item = item,
                        Position = i
                    }).Where(m => m.Item.Isbn == isbn).First().Position;
                    //List<string> list = (Form1.prestiti[position].Prestiti.Where(p => p.Key == myUser.CodiceFiscale).Select(u => u.Key)).ToList();
                    //MessageBox.Show(Form1.prestiti[position].Prestiti.Where(p => p.Key == myUser.CodiceFiscale).Select(u => u.Key).ToList()[0]);
                    Form1.prestiti[position].Prestiti.Remove(Form1.prestiti[position].Prestiti.Where(p => p.Key == myUser.CodiceFiscale).Select(u => u.Key).ToList()[0]);
                    if (Form1.prestiti[position].Prestiti.Count == 0)
                    {
                        Form1.prestiti.RemoveAt(position);
                    }
                    //Form1.prestiti.Where(pre => pre.Isbn == isbn).Select(obj => { obj.Prestiti.Add(this.myUser.CodiceFiscale, DateTime.Now); });
                }
                Form1.usersElenco[myUser.CodiceFiscale].Storico.Add(isbn);
                Form1.usersElenco[myUser.CodiceFiscale].RemovePrestito();
                File.WriteAllText(Directory.GetCurrentDirectory() + @"\prestiti.json", String.Empty);
                FileStream file2 = new FileStream(Directory.GetCurrentDirectory() + @"\prestiti.json", FileMode.Open, FileAccess.ReadWrite, FileShare.None);
                StreamWriter writer2 = new StreamWriter(file2, Encoding.Unicode);
                string output2 = JsonConvert.SerializeObject(Form1.prestiti, Formatting.Indented);
                
                writer2.Write(output2);
                writer2.Close();

                writer3.Write(String.Empty);
                string output3 = JsonConvert.SerializeObject(Form1.usersElenco, Formatting.Indented);
               
                writer3.Write(output3);
                writer3.Close();

                Methods.Deserialize(Directory.GetCurrentDirectory() + @"\users.json", "CodiceFiscale", out Form1.usersElenco);
                Methods.Deserialize(Directory.GetCurrentDirectory() + @"\books.json", "Isbn", out Form1.libriElenco);
                Methods.Deserialize(Directory.GetCurrentDirectory() + @"\prestiti.json", "", out Form1.prestiti);
                Init();
                BindData();
            }
        }

        private bool FileIsLocked(string filename)
        {
            bool Locked = false;
            try
            {
                FileStream fs =
                    File.Open(filename, FileMode.OpenOrCreate,
                    FileAccess.ReadWrite, FileShare.None);
                fs.Close();
            }
            catch (IOException)
            {
                Locked = true;
            }
            return Locked;
        }
    }
}
