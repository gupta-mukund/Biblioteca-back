﻿using System;
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
        private List<Libro> libriData;
        public FileSystemWatcher watcher;
        private User currentUser = null;
        public static event EventHandler OnPrestitiChange;
        public static event EventHandler OnBookChange;
        public static event EventHandler OnUsersChange;
        private delegate void BindingCallback();
        public frmAdmin(User admin)
        {
            InitializeComponent();
            libriData = new List<Libro>();
            //Methods.Deserialize(Directory.GetCurrentDirectory() + @"\users.json", "CodiceFiscale", ref Form1.usersElenco);
            //Methods.Deserialize(Directory.GetCurrentDirectory() + @"\books.json", "Isbn", ref Form1.libriElenco);
            libriData = Form1.libriElenco.Values.ToList();
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
        //public static void ReloadPrestiti()
        //{
        //    Methods.Deserialize(Directory.GetCurrentDirectory() + @"\prestiti.json", "", out Form1.prestiti);
        //}

        //public static void ReloadBooks()
        //{
        //    Methods.Deserialize(Directory.GetCurrentDirectory() + @"\books.json", "Isbn", out Form1.libriElenco);
        //}
        //public static void ReloadUsers()
        //{
        //    Methods.Deserialize(Directory.GetCurrentDirectory() + @"\users.json", "CodiceFiscale", out Form1.libriElenco);
        //}
        public void OnChanged(object source, FileSystemEventArgs e)
        {
            switch (e.Name)
            {
                case "prestiti.json":
                case "books.json":
                case "users.json":
                    Methods.ReloadData(Directory.GetCurrentDirectory() + @"\prestiti.json", "", ref Form1.prestiti);
                    Methods.ReloadData(Directory.GetCurrentDirectory() + @"\books.json", "Isbn", ref Form1.libriElenco);
                    Methods.ReloadData(Directory.GetCurrentDirectory() + @"\users.json", "CodiceFiscale", ref Form1.usersElenco);
                    //ReloadPrestiti();
                    OnPrestitiChange?.Invoke(null, null);
                    OnBookChange?.Invoke(null, null);
                    OnUsersChange?.Invoke(null, null);  
                    BindingData();     
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
            AutoCompleteStringCollection ac = new AutoCompleteStringCollection();
            foreach (Libro item in libriData)
            {
                ac.Add(item.Titolo);
            }
            txtBookName.Suggestions(ac);
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
                new forms.GestioneLibro(txtNewIsbn.Texts.Trim(), true).Show();
            }
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            string isbn = dgvLibri.Rows[dgvLibri.CurrentCell.RowIndex].Cells[0].Value.ToString();
            if (!Form1.prestiti.Any(p => p.Isbn == isbn))
            {
                Form1.libriElenco.Remove(isbn);
            } else
            {
                MessageBox.Show("Libro in prestito");
            }
            
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            string isbn = dgvLibri.Rows[dgvLibri.CurrentCell.RowIndex].Cells[0].Value.ToString();
            new forms.GestioneLibro(Form1.libriElenco[isbn], false);
        }
    }
}
