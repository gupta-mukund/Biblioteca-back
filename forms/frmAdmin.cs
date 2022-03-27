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
using System.Reflection;

namespace Biblioteca
{
    public partial class frmAdmin : Form
    {
        public static Dictionary<string, User> utenti;
        public static Dictionary<string, Libro> libri;
        public static List<Prestito> utentiPrestiti;
        private List<Libro> libriData;
        public FileSystemWatcher watcher;
        private User currentUser = null;
        public static event EventHandler OnPrestitiChange;
        public static event EventHandler OnBookChange;
        public static event EventHandler OnUsersChange;
        private delegate void BindingCallback();
        public frmAdmin()
        {
            InitializeComponent();
            libriData = new List<Libro>();
            Methods.Deserialize(Directory.GetCurrentDirectory() + @"\users.json", "CodiceFiscale", out utenti);
            Methods.Deserialize(Directory.GetCurrentDirectory() + @"\books.json", "Isbn", out libri);
            Methods.Deserialize(Directory.GetCurrentDirectory() + @"\prestiti.json", "", out utentiPrestiti);
            libriData = libri.Values.ToList();
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
        public static void ReloadPrestiti()
        {
            Methods.Deserialize(Directory.GetCurrentDirectory() + @"\prestiti.json", "", out utentiPrestiti);
        }

        public static void ReloadBooks()
        {
            Methods.Deserialize(Directory.GetCurrentDirectory() + @"\books.json", "Isbn", out libri);
        }
        public static void ReloadUsers()
        {
            Methods.Deserialize(Directory.GetCurrentDirectory() + @"\users.json", "CodiceFiscale", out utenti);
        }
        public void OnChanged(object source, FileSystemEventArgs e)
        {
            switch (e.Name)
            {
                case "prestiti.json":
                    ReloadPrestiti();
                    BindingData();
                    OnPrestitiChange?.Invoke(null, null);
                    break;
                case "books.json":
                    BindingData();
                    ReloadBooks();
                    OnBookChange?.Invoke(null, null);
                    break;
                case "users.json":
                    ReloadUsers();
                    OnUsersChange?.Invoke(null, null);
                    break;
                default:
                    break;
            }
            //Console.WriteLine("{0}, with path {1} has been {2}", e.Name, e.FullPath, e.ChangeType);
        }
        public void BindingData()
        {
            if (this.dgvLibri.InvokeRequired)
            {
                BindingCallback d = new BindingCallback(BindingData);
                this.Invoke(d);
            }
            else
            {
                dgvLibri.DataSource = libri.Select(x => new {
                    Isbn = x.Key,
                    Titolo = x.Value.Titolo,
                    Autore = x.Value.Autori,
                    Categoria = x.Value.Categorie,
                    Pagine = x.Value.Pagine
                }).ToList();
                dgvUtenti.DataSource = utenti.Select(x => new {
                    Nome = x.Value.Nome,
                    Cognome = x.Value.Cognome,
                    Codice = x.Value.CodiceFiscale,
                    Prestiti = x.Value.Prestiti,

                }).ToList();
            }
            





        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection ac = new AutoCompleteStringCollection();
            foreach (Libro item in libriData)
            {
                ac.Add(item.Titolo);
            }
            txtBookName.Suggestions(ac);
            ac = new AutoCompleteStringCollection();
            foreach (Libro item in libriData)
            {
                ac.Add(item.Autori);
            }
            txtAutori.Suggestions(ac);
            List<string> genres = libriData.Select(o => o.Categorie).Where(g => g != "").Distinct().ToList();
            cmbGenres.DataSource = genres;
        }

        private void btnFiltra_Click(object sender, EventArgs e)
        {
            libriData = libri.Values.ToList();
            Dictionary<string, string> filters = new Dictionary<string, string>();
            if (!String.IsNullOrWhiteSpace(txtBookName.Texts)) filters.Add("Titolo", txtBookName.Texts);
            if (!String.IsNullOrWhiteSpace(txtAutori.Texts)) filters.Add("Autori", txtAutori.Texts);
            if (!String.IsNullOrWhiteSpace(cmbGenres.Text)) filters.Add("Categorie", cmbGenres.Text);

            if (filters.Count != 0)
            {
                foreach (var item in filters)
                {
                    PropertyInfo pinfo = typeof(Libro).GetProperty(item.Key);
                    libriData = libriData.Where(x => pinfo.GetValue(x, null).ToString() == item.Value.ToString()).ToList();
                }
                dgvLibri.DataSource = null;
                dgvLibri.DataSource = libriData.Select(x => new {
                    Isbn = x.Isbn,
                    Titolo = x.Titolo,
                    Autore = x.Autori,
                    Categoria = x.Categorie,
                    Pagine = x.Pagine
                }).ToList();
            }
        }

        private void btnEntraUser_Click(object sender, EventArgs e)
        {
            if (txtLoginCodice.Texts.Trim() != "")
            {
                if (utenti.ContainsKey(txtLoginCodice.Texts.Trim()) && utenti[txtLoginCodice.Texts.Trim()].Ruolo != "admin")
                {
                    new frmRestituzione(utenti[txtLoginCodice.Texts.Trim()]).Show();
                }
            }
        }
        private void RestituzioneLibri()
        {
            
        }
    }
}
