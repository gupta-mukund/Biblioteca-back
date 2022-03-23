﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.IO;

namespace Biblioteca.forms
{
    public partial class frmBooks : Form
    {
        List<components.BookTextCell> myBooks;
        List<Libro> libriData;
        string booksPath = Directory.GetCurrentDirectory() + @"\books.json";
        private static object lockerFile = new Object();
        public static event EventHandler OnPrestitiChange;
        public frmBooks()
        {
            InitializeComponent();
            //new frmMainPage();
           
            libriData = new List<Libro>();            
            Init();
            

        }
        private void Init()
        {
            foreach (Control item in this.tlpMain.Controls)
            {
                tlpMain.Controls.Remove(item);
            }
            tlpMain.ColumnCount = 1;
            tlpMain.RowCount = 0;
            myBooks = new List<components.BookTextCell>();
            libriData = frmMainPage.libriElenco.Values.ToList();
            Pagination.DataPerPage = 10;
            Pagination.PagesNumber = (int)Math.Ceiling((double)libriData.Count / 10);
            Pagination.CurrentStart = 0;
            Pagination.CurrentEnd = Pagination.CurrentStart + Pagination.DataPerPage;

            for (int i = 0; i < Pagination.DataPerPage; i++)
            {
                tlpMain.RowCount = tlpMain.RowCount + 1;
                tlpMain.RowStyles.Add(new RowStyle());
                components.BookTextCell comp = new components.BookTextCell();
                comp.Prenota += UserPrenota;
                myBooks.Add(comp);
                tlpMain.Controls.Add(comp, 0, tlpMain.RowCount - 1);
                //comp.BringToFront();
            }
            txtCurrentPages.Text = (Math.Floor((double)Pagination.CurrentStart)+1).ToString();
            lblPages.Text = $"/{Pagination.PagesNumber}";
            SetData();
        }

        private void UserPrenota(object sender, components.Data e)
        {
            if (TryOrderBook(e.Book.Isbn))
            {
                OnPrestitiChange?.Invoke(null, null);
            };
        }
        public bool TryOrderBook(string isbn)
        {
            DateTime x = File.GetLastWriteTime(booksPath);
            double difference = frmMainPage.ExecutedTime.Subtract(x).TotalMinutes;
            if (difference > 0) // file modificato dopo esecuzione file
            {
                frmMainPage.ReloadBooks();
                Init();
            }
            if (!FileIsLocked(booksPath))
            {
                WriteToFile(isbn);
                return true;
            }
            return false;
            //MessageBox.Show(FileIsLocked(booksPath).ToString());
        }

        public void WriteToFile(string isbn)
        {
            lock (lockerFile)
            {
                FileStream file = new FileStream(booksPath, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
                //FileStream file2 = new FileStream(Directory.GetCurrentDirectory() + @"\prestiti.json", FileMode.Open, FileAccess.ReadWrite, FileShare.None);
                MessageBox.Show(frmMainPage.libriElenco[isbn].Quantita.ToString());
                frmMainPage.libriElenco[isbn].Quantita--;
                StreamWriter writer = new StreamWriter(file, Encoding.Unicode);
                    
                writer.Write(String.Empty);
                string output = JsonConvert.SerializeObject(frmMainPage.libriElenco.Values, Formatting.Indented);
                writer.Write(output);
                writer.Close();

                frmMainPage.prestiti.Add(new Prestito(isbn, new Dictionary<string, DateTime> { [frmMainPage.currentUser.CodiceFiscale] = DateTime.Now}));

                frmMainPage.libriElenco.Clear();
                frmMainPage.ReloadBooks();
                Init();
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

        private void SetData()
        {
            Pagination.PaginationData = libriData.Skip(Pagination.CurrentStart).Take(Pagination.CurrentEnd - Pagination.CurrentStart).ToList();
            for (int i = 0; i < Pagination.PaginationData.Count; i++)
            {
                myBooks[i].Identity= Pagination.PaginationData[i];
                if (myBooks[i].Identity.Quantita == 0) myBooks[i].FinishedBook();
                else myBooks[i].NormalizeButton();
                                    
            }
            //if (Pagination.PaginationData.Count < Pagination.DataPerPage)
            //{
            //    for (int i = Pagination.PaginationData.Count; i < Pagination.DataPerPage; i++)
            //    {
            //        tlpMain.Controls.Remove(tlpMain.GetControlFromPosition(0, i));
            //    }
            //}
            
            panel1.AutoScroll = true;
            panel1.AutoScrollPosition = new Point(panel1.AutoScrollPosition.X, 0);
            panel1.VerticalScroll.Value = 0;
            txtCurrentPages.Text = (Pagination.CurrentStart + 1).ToString();
            //lblPages.Text = $"{Pagination.CurrentStart + 1}/{Pagination.PagesNumber}";
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (Pagination.CurrentStart < 1)
            {
                Pagination.CurrentStart = 0;
            } else
            {
                Pagination.CurrentStart = Pagination.CurrentStart - Pagination.DataPerPage;
                Pagination.CurrentEnd = Pagination.CurrentEnd - Pagination.DataPerPage;
                SetData();
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            if (Pagination.CurrentEnd > Pagination.PagesNumber - 1)
            {
                Pagination.CurrentEnd = Pagination.PagesNumber;
            }
            else
            {
                Pagination.CurrentStart = Pagination.CurrentStart + Pagination.DataPerPage;
                Pagination.CurrentEnd += Pagination.DataPerPage;
                SetData();
            }
        }
        private void txtCurrentPages_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Int32.TryParse(this.txtCurrentPages.Text, out int n) && n > 0 && n <= Pagination.PagesNumber)
                {
                    
                    Pagination.CurrentStart = n * Pagination.DataPerPage;
                    Pagination.CurrentEnd = Pagination.CurrentStart + Pagination.DataPerPage;
                    SetData();
                } else
                {
                    txtCurrentPages.Text = (Math.Floor((double)Pagination.CurrentStart) + 1).ToString();
                }
            }
        }
        private static class Pagination
        {
            public static List<Libro> PaginationData { get; set; }
            public static int PagesNumber { get; set; }
            public static int DataPerPage { get; set; }
            public static int CurrentStart { get; set; }
            public static int CurrentEnd { get; set; }
        }

        private void frmBooks_Load(object sender, EventArgs e)
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
            List<string> genres = libriData.Select(o => o.Categorie).Where(g => g!="").Distinct().ToList();
            cmbGenres.DataSource = genres;
        }

        private void btnFiltra_Click(object sender, EventArgs e)
        {
            libriData = frmMainPage.libriElenco.Values.ToList();
            Dictionary<string,string> filters = new Dictionary<string, string>();
            if (!String.IsNullOrWhiteSpace(txtBookName.Texts)) filters.Add("Titolo", txtBookName.Texts);
            if (!String.IsNullOrWhiteSpace(txtAutori.Texts)) filters.Add("Autori", txtAutori.Texts);
            if (!String.IsNullOrWhiteSpace(cmbGenres.Text)) filters.Add("Categorie",cmbGenres.Text);

            if (filters.Count != 0)
            {
                foreach (var item in filters)
                {
                    PropertyInfo pinfo = typeof(Libro).GetProperty(item.Key);
                    libriData = libriData.Where(x => pinfo.GetValue(x, null).ToString() == item.Value.ToString()).ToList();
                }
                Pagination.CurrentStart = 0;
                Pagination.CurrentEnd = libriData.Count > 10 ? Pagination.CurrentStart + Pagination.DataPerPage : libriData.Count;
                Pagination.PagesNumber = (int)Math.Ceiling((double)libriData.Count / 10);
                txtCurrentPages.Text = (Math.Floor((double)Pagination.CurrentStart) + 1).ToString();
                lblPages.Text = $"/{Pagination.PagesNumber}";
                SetData();
            }
        }
    }
    
}