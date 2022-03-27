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
        public frmRestituzione(User user)
        {
            InitializeComponent();
            myUser = user;
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
        private void BindData()
        {           
            dgvPrestiti.DataSource = null;
            dgvPrestiti.DataSource = myPrestiti.Select(p => new { Isbn = p.Isbn, Titolo = frmAdmin.libri[p.Isbn].Titolo , Scadenza = p.Prestiti[myUser.CodiceFiscale]}).ToList();
        }

        private void dgvPrestiti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;
            if (grid[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
            {
                HandleRestituzione(grid[e.ColumnIndex + 1, e.RowIndex].Value.ToString());
                
            }
        }
        private bool HandleRestituzione(string isbn)
        {
            //frmAdmin.libri[isbn].Quantita++;
            if (!FileIsLocked(Directory.GetCurrentDirectory() + @"\books.json"))
            {
                WriteToFile(isbn);
                return true;
            }
            return false;
        }

        public void WriteToFile(string isbn)
        {
            lock (locker)
            {
                FileStream file = new FileStream(Directory.GetCurrentDirectory() + @"\books.json", FileMode.Open, FileAccess.ReadWrite, FileShare.None);
                FileStream file2 = new FileStream(Directory.GetCurrentDirectory() + @"\prestiti.json", FileMode.Open, FileAccess.ReadWrite, FileShare.None);
                FileStream file3 = new FileStream(Directory.GetCurrentDirectory() + @"\users.json", FileMode.Open, FileAccess.ReadWrite, FileShare.None);
                frmAdmin.libri[isbn].Quantita++;
                StreamWriter writer = new StreamWriter(file, Encoding.Unicode);
                StreamWriter writer2 = new StreamWriter(file2, Encoding.Unicode);
                StreamWriter writer3 = new StreamWriter(file3, Encoding.Unicode);

                writer.Write(String.Empty);
                string output = JsonConvert.SerializeObject(frmMainPage.libriElenco.Values, Formatting.Indented);
                writer.Write(output);
                writer.Close();

                if (frmAdmin.utentiPrestiti != null)
                {

                    int position = frmAdmin.utentiPrestiti.Select((item, i) => new
                    {
                        Item = item,
                        Position = i
                    }).Where(m => m.Item.Isbn == isbn).First().Position;
                    frmAdmin.utentiPrestiti[position].Prestiti.Remove(frmAdmin.utentiPrestiti[position].Prestiti[myUser.CodiceFiscale].ToString());
                    //frmAdmin.utentiPrestiti.Where(pre => pre.Isbn == isbn).Select(obj => { obj.Prestiti.Add(this.myUser.CodiceFiscale, DateTime.Now); });
                }
                frmAdmin.utenti[myUser.CodiceFiscale].RemovePrestito();
                writer2.Write(String.Empty);
                string output2 = JsonConvert.SerializeObject(frmAdmin.utentiPrestiti, Formatting.Indented);
                writer2.Write(output2);
                writer2.Close();

                writer3.Write(String.Empty);
                string output3 = JsonConvert.SerializeObject(Form1.usersElenco, Formatting.Indented);
                writer3.Write(output3);
                writer3.Close();

                Form1.ReloadUsers();
                Methods.Deserialize(Directory.GetCurrentDirectory() + @"\books.json", "", out frmAdmin.libri);
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
