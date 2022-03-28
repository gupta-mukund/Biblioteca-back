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
            if (frmAdmin.utentiPrestiti != null)
            {
                myPrestiti = (from u in frmAdmin.utentiPrestiti
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
            dgvPrestiti.DataSource = myPrestiti.Select(p => new { Isbn = p.Isbn, Titolo = frmAdmin.libri[p.Isbn].Titolo , Scadenza = p.Prestiti[myUser.CodiceFiscale]}).ToList();
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
                MessageBox.Show(currentRating.ToString());
                WriteToFile(isbn);
            }   
        }

        public void WriteToFile(string isbn)
        {
            lock (locker)
            {
                
                FileStream file = new FileStream(Directory.GetCurrentDirectory() + @"\books.json", FileMode.Open, FileAccess.ReadWrite, FileShare.None);
                
                FileStream file3 = new FileStream(Directory.GetCurrentDirectory() + @"\users.json", FileMode.Open, FileAccess.ReadWrite, FileShare.None);
                frmAdmin.libri[isbn].Quantita++;
                StreamWriter writer = new StreamWriter(file, Encoding.Unicode);
                
                StreamWriter writer3 = new StreamWriter(file3, Encoding.Unicode);
                int totalVotanti = frmAdmin.libri[isbn].QuantitaVoti;
                float totalStars = frmAdmin.libri[isbn].MediaVoti * totalVotanti;
                totalVotanti++;
                totalStars += this.currentRating * 100;
                frmAdmin.libri[isbn].MediaVoti = totalStars / totalVotanti;
                frmAdmin.libri[isbn].QuantitaVoti = totalVotanti;
                writer.Write(String.Empty);
                string output = JsonConvert.SerializeObject(frmAdmin.libri, Formatting.Indented);
                writer.Write(output);
                writer.Close();

                if (frmAdmin.utentiPrestiti != null)
                {

                    int position = frmAdmin.utentiPrestiti.Select((item, i) => new
                    {
                        Item = item,
                        Position = i
                    }).Where(m => m.Item.Isbn == isbn).First().Position;
                    //List<string> list = (frmAdmin.utentiPrestiti[position].Prestiti.Where(p => p.Key == myUser.CodiceFiscale).Select(u => u.Key)).ToList();
                    //MessageBox.Show(frmAdmin.utentiPrestiti[position].Prestiti.Where(p => p.Key == myUser.CodiceFiscale).Select(u => u.Key).ToList()[0]);
                    frmAdmin.utentiPrestiti[position].Prestiti.Remove(frmAdmin.utentiPrestiti[position].Prestiti.Where(p => p.Key == myUser.CodiceFiscale).Select(u => u.Key).ToList()[0]);
                    if (frmAdmin.utentiPrestiti[position].Prestiti.Count == 0)
                    {
                        frmAdmin.utentiPrestiti.RemoveAt(position);
                    }
                    //frmAdmin.utentiPrestiti.Where(pre => pre.Isbn == isbn).Select(obj => { obj.Prestiti.Add(this.myUser.CodiceFiscale, DateTime.Now); });
                }
                frmAdmin.utenti[myUser.CodiceFiscale].RemovePrestito();
                File.WriteAllText(Directory.GetCurrentDirectory() + @"\prestiti.json", String.Empty);
                FileStream file2 = new FileStream(Directory.GetCurrentDirectory() + @"\prestiti.json", FileMode.Open, FileAccess.ReadWrite, FileShare.None);
                StreamWriter writer2 = new StreamWriter(file2, Encoding.Unicode);
                string output2 = JsonConvert.SerializeObject(frmAdmin.utentiPrestiti, Formatting.Indented);
                
                writer2.Write(output2);
                writer2.Close();

                writer3.Write(String.Empty);
                string output3 = JsonConvert.SerializeObject(frmAdmin.utenti, Formatting.Indented);
               
                writer3.Write(output3);
                writer3.Close();

                Methods.Deserialize(Directory.GetCurrentDirectory() + @"\users.json", "CodiceFiscale", out frmAdmin.utenti);
                Methods.Deserialize(Directory.GetCurrentDirectory() + @"\books.json", "Isbn", out frmAdmin.libri);
                Methods.Deserialize(Directory.GetCurrentDirectory() + @"\prestiti.json", "", out frmAdmin.utentiPrestiti);
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
