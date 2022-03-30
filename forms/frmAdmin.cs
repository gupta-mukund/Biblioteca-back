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
using FontAwesome.Sharp;
using System.Reflection;

namespace Biblioteca
{
    public partial class frmAdmin : Form
    {
        private List<Libro> libriData;
        private List<User> userData;
        public FileSystemWatcher watcher;
        private User currentUser = null;
        public static event EventHandler OnPrestitiChange;
        public static event EventHandler OnBookChange;
        public static event EventHandler OnUsersChange;
        private delegate void BindingCallback();
        public frmAdmin(User admin)
        {
            InitializeComponent();
            this.btnLogOut.IconChar = IconChar.ArrowCircleRight;
            panel1.BackColor = ColorTranslator.FromHtml("#6FE0CC");
            this.Text = admin.GetFullName();
            libriData = new List<Libro>();
            userData = new List<User>();
            
            libriData = Form1.libriElenco.Values.ToList();
            userData = Form1.usersElenco.Values.ToList();
            currentUser = admin;
            lblNome.Text = "Admin: " + currentUser.GetFullName();
            watcher = new FileSystemWatcher();
            watcher.Path = Directory.GetCurrentDirectory();
            watcher.NotifyFilter = NotifyFilters.Attributes |
                NotifyFilters.CreationTime |
                NotifyFilters.DirectoryName |
                NotifyFilters.FileName |
                NotifyFilters.LastAccess |
                NotifyFilters.LastWrite |
                NotifyFilters.Security |
                NotifyFilters.Size;
            watcher.Filter = "*.json";
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.EnableRaisingEvents = true;
            BindingData();
        }
        public void OnChanged(object source, FileSystemEventArgs e)
        {
            switch (e.Name)
            {
                case "prestiti.json":
                case "books.json":
                case "users.json":
                    if (Methods.ReloadData(Directory.GetCurrentDirectory() + @"\prestiti.json", "", ref Form1.prestiti) &&
                        Methods.ReloadData(Directory.GetCurrentDirectory() + @"\books.json", "Isbn", ref Form1.libriElenco) &&
                        Methods.ReloadData(Directory.GetCurrentDirectory() + @"\users.json", "CodiceFiscale", ref Form1.usersElenco))
                       OnPrestitiChange?.Invoke(null, null);
                    OnBookChange?.Invoke(null, null);
                     OnUsersChange?.Invoke(null, null);
                    BindingData();
                    break;
                default:
                    break;
            }
        }
        public void BindingData()
        {
            //pattern che modifica la ui in sicurezza
            if (this.dgvLibri.InvokeRequired)
            {
                BindingCallback d = new BindingCallback(BindingData);
                this.Invoke(d);
            }
            else
            {
                //setto il databinding dei dati
                dgvLibri.DataSource = Form1.libriElenco.Select(x => new {
                    Isbn = x.Key,
                    Titolo = x.Value.Titolo,
                    Autore = x.Value.Autori,
                    Categoria = x.Value.Categorie,
                    Pagine = x.Value.Pagine
                }).ToList();
                dgvUtenti.DataSource = Form1.usersElenco.Select(x => new {
                    Nome = x.Value.Nome,
                    Cognome = x.Value.Cognome,
                    Codice = x.Value.CodiceFiscale,
                    Prestiti = x.Value.Prestiti,

                }).ToList();
            }
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            //setto l'autocomplete dei campi di filtraggio
            AutoCompleteStringCollection ac = new AutoCompleteStringCollection();
            foreach (Libro item in libriData)
            {
                ac.Add(item.Titolo);
            }
            txtBookName.Suggestions(ac);

            AutoCompleteStringCollection ac2 = new AutoCompleteStringCollection();
            foreach (User item in userData)
            {
                ac2.Add(item.GetFullName());
            }
            txtNome.Suggestions(ac2);
        }

        private void btnFiltra_Click(object sender, EventArgs e)
        {
            libriData = Form1.libriElenco.Values.ToList();

            if (!String.IsNullOrWhiteSpace(txtBookName.Texts))
            {
                libriData = libriData.Where(x => x.Titolo == txtBookName.Texts).ToList();
            };
           
            dgvLibri.DataSource = null;
            dgvLibri.DataSource = libriData.Select(x => new {
                Isbn = x.Isbn,
                Titolo = x.Titolo,
                Autore = x.Autori,
                Categoria = x.Categorie,
                Pagine = x.Pagine
            }).ToList();
            
        }

        private void btnEntraUser_Click(object sender, EventArgs e)
        {
            if (txtLoginCodice.Texts.Trim() != "")
            {
                if (Form1.usersElenco.ContainsKey(txtLoginCodice.Texts.Trim()) && Form1.usersElenco[txtLoginCodice.Texts.Trim()].Ruolo != "admin")
                {
                    new frmRestituzione(Form1.usersElenco[txtLoginCodice.Texts.Trim()]).Show();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            BindingData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNewIsbn.Texts.Trim() == "")
            {
                MessageBox.Show("Write new book isbn");
            }
            else if (Form1.libriElenco.ContainsKey(txtNewIsbn.Texts.Trim()))
            {
                MessageBox.Show("Book already exists");
            } else
            {
                new forms.GestioneLibro(txtNewIsbn.Texts.Trim(), true, typeof(Libro)).Show();
            }
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            string isbn = dgvLibri.Rows[dgvLibri.CurrentCell.RowIndex].Cells[0].Value.ToString();
            if (!Form1.prestiti.Any(p => p.Isbn == isbn))
            {
                Form1.libriElenco.Remove(isbn);
                Methods.Serialize(Form1.libriElenco, Directory.GetCurrentDirectory() + @"\books.json");
            } else
            {
                MessageBox.Show("Libro in prestito");
            }
            
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            string isbn = dgvLibri.Rows[dgvLibri.CurrentCell.RowIndex].Cells[0].Value.ToString();
            new forms.GestioneLibro(Form1.libriElenco[isbn], false, typeof(Libro)).Show();
        }

        private void btnFiltraUser_Click(object sender, EventArgs e)
        {
            userData = Form1.usersElenco.Values.ToList();

            if (!String.IsNullOrWhiteSpace(txtNome.Texts))
            {
               
                userData = userData.Where(x => x.GetFullName() == txtNome.Texts).ToList();
            };
            dgvUtenti.DataSource = null;
            dgvUtenti.DataSource = userData.Select(x => new {
                Nome = x.Nome,
                Cognome = x.Cognome,
                Codice = x.CodiceFiscale,
                Prestiti = x.Prestiti,
            }).ToList();
        }

        private void btnResetUSer_Click(object sender, EventArgs e)
        {
            BindingData();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            if (txtNewUser.Texts.Trim() == "")
            {
                MessageBox.Show("Write new user code");
            } else if (txtNewUser.Texts.Trim().Length != 16)
            {
                MessageBox.Show("User must have 16 chars");
            }
            else if (Form1.usersElenco.ContainsKey(txtNewUser.Texts))
            {
                MessageBox.Show("User already exists");
            }
            else
            {
                new forms.GestioneLibro(txtNewUser.Texts.Trim(), true, typeof(User)).Show();
            }
        }

        private void btnEliminaUser_Click(object sender, EventArgs e)
        {
            string codice = dgvUtenti.Rows[dgvUtenti.CurrentCell.RowIndex].Cells[2].Value.ToString();
            if (!Form1.prestiti.Any(p => p.Prestiti.Any(x => x.Key == codice)))
            {
                Form1.usersElenco.Remove(codice);
                Methods.Serialize(Form1.usersElenco, Directory.GetCurrentDirectory() + @"\users.json");
            }
            else
            {
                MessageBox.Show("Utente con libri in prestito");
            }
        }

        private void btnModificaUser_Click(object sender, EventArgs e)
        {
            string codice = dgvUtenti.Rows[dgvLibri.CurrentCell.RowIndex].Cells[3].Value.ToString();
            new forms.GestioneLibro(Form1.usersElenco[codice], false, typeof(User));
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.Istance.Show();
        }
    }
}
