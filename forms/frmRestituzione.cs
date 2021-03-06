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
        private TaskCompletionSource<bool> tsc = null;
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
                if (myPrestiti.Count > 0)
                {
                    dgvPrestiti.DataSource = null;
                    dgvPrestiti.DataSource = myPrestiti.Select(p => new { Isbn = p.Isbn, Titolo = Form1.libriElenco[p.Isbn].Titolo, Scadenza = p.Prestiti[myUser.CodiceFiscale] }).ToList();
                } else {
                    dgvPrestiti.DataSource = null;
                }
            
            }
        }

        private async void dgvPrestiti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;
            if (grid[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
            {
                currentRating = 0;
                tsc = new TaskCompletionSource<bool>();
                HandleRating();
                await tsc.Task;
                HandleRestituzione(grid[e.ColumnIndex + 1, e.RowIndex].Value.ToString());
                
            }
        }
        Form tmpForm;
        private void HandleRating()
        {
            tmpForm = new Form();
            components.Rating tmpRat = new components.Rating();
            tmpRat.RatingDone += TmpRat_RatingDone;
            tmpRat.Dock = DockStyle.Fill;
            tmpForm.Controls.Add(tmpRat);
            tmpForm.StartPosition = FormStartPosition.CenterParent;
            tmpForm.Show();
        }

        private void TmpRat_RatingDone(object sender, components.RatingEvent e)
        {
            tmpForm.Dispose();
            currentRating = e.NumberOfStars;
            tsc.TrySetResult(true);
        }

        private void HandleRestituzione(string isbn)
        {
            WriteToFile(isbn);  
        }

        public void WriteToFile(string isbn)
        {
            if (Methods.FileIsLocked(Directory.GetCurrentDirectory() + @"\users.json") || Methods.FileIsLocked(Directory.GetCurrentDirectory() + @"\books.json") || Methods.FileIsLocked(Directory.GetCurrentDirectory() + @"\prestiti.json"))
            {
                WriteToFile(isbn);
            } else
            {

                lock (locker)
                {
                    using (FileStream file = new FileStream(Directory.GetCurrentDirectory() + @"\books.json", FileMode.Truncate, FileAccess.ReadWrite, FileShare.None))
                    using (FileStream file3 = new FileStream(Directory.GetCurrentDirectory() + @"\users.json", FileMode.Truncate, FileAccess.ReadWrite, FileShare.None))
                    using (FileStream file2 = new FileStream(Directory.GetCurrentDirectory() + @"\prestiti.json", FileMode.Truncate, FileAccess.ReadWrite, FileShare.None))
                    {
                        Form1.libriElenco[isbn].Quantita++;

                        int totalVotanti = Form1.libriElenco[isbn].QuantitaVoti;
                        float totalStars = Form1.libriElenco[isbn].MediaVoti * totalVotanti;
                        totalVotanti++;
                        totalStars += this.currentRating * 100;
                        Form1.libriElenco[isbn].MediaVoti = totalStars / totalVotanti;
                        Form1.libriElenco[isbn].QuantitaVoti = totalVotanti;



                        int position = Form1.prestiti.FindIndex(s => s.Isbn == isbn);

                        Form1.prestiti[position].Prestiti.Remove(myUser.CodiceFiscale);
                        if (Form1.prestiti[position].Prestiti.Count == 0)
                        {
                            Form1.prestiti.RemoveAt(position);
                        }
                     

                        Form1.usersElenco[myUser.CodiceFiscale].Storico.Add(isbn);
                        Form1.usersElenco[myUser.CodiceFiscale].Punti++;
                        Form1.usersElenco[myUser.CodiceFiscale].RemovePrestito();

                        StreamWriter writer = new StreamWriter(file, Encoding.Unicode);
                        StreamWriter writer2 = new StreamWriter(file2, Encoding.Unicode);
                        StreamWriter writer3 = new StreamWriter(file3, Encoding.Unicode);
                        string output = JsonConvert.SerializeObject(Form1.libriElenco, Formatting.Indented);
                        string output2 = JsonConvert.SerializeObject(Form1.prestiti, Formatting.Indented);
                        string output3 = JsonConvert.SerializeObject(Form1.usersElenco, Formatting.Indented);


                        writer.Write(output);
                        writer.Close();
                        writer2.Write(output2);
                        writer2.Close();
                        writer3.Write(output3);
                        writer3.Close();
                    }
                }  
            }
        }
    }
}
