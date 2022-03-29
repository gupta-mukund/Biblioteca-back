using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.forms
{
    public partial class GestioneLibro : Form
    {
        private string[] campi;
        private string[] results;
        private bool IsCrea;
        private Libro thisLibro;
        private int index;
        private string isbn;
        public GestioneLibro(Libro libro, bool crea)
        {
            InitializeComponent();
            index = 0;
            thisLibro = libro;
            results = new string[7];
            campi = new string[] { "Titolo", "Autori", "Sottotitolo", "Categorie", "Immagine", "Descrizione", "Anno" };
            lblTitolo.Text = campi[index];
            IsCrea = crea;
            if (!IsCrea)
            {
                txtField.Texts = typeof(Libro).GetProperty(campi[index]).GetValue(thisLibro, null).ToString();
            }
        }
        public GestioneLibro(string code, bool crea)
        {
            InitializeComponent();
            index = 0;
            isbn = code;
            results = new string[7];
            campi = new string[] { "Titolo", "Autori", "Sottotitolo", "Categorie", "Immagine", "Descrizione", "Anno" };
            lblTitolo.Text = campi[index];
            IsCrea = crea;
            if (!IsCrea)
            {
                txtField.Texts = typeof(Libro).GetProperty(campi[index]).GetValue(thisLibro, null).ToString();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtField.Texts))
            {
                results[index] = txtField.Texts.Trim();
                index++;
                CheckFormEnd();
            }
            else
            {
                MessageBox.Show("Compila Campo");
            }
        }
        private void CheckFormEnd()
        {
            if (index == campi.Length)
            {
                if (IsCrea)
                {
                    Libro tmp = new Libro();
                    tmp.Titolo = results[0];
                    tmp.Autori = results[1];
                    tmp.Sottotitolo = results[2];
                    tmp.Categorie = results[3];
                    tmp.Immagine = results[4];
                    tmp.Descrizione = results[5];
                    tmp.Anno = results[6];
                    Form1.libriElenco.Add(isbn, tmp);
                } else
                {
                    Form1.libriElenco[thisLibro.Isbn].Titolo = campi[0];
                    Form1.libriElenco[thisLibro.Isbn].Autori = campi[1];
                    Form1.libriElenco[thisLibro.Isbn].Sottotitolo = campi[2];
                    Form1.libriElenco[thisLibro.Isbn].Categorie = campi[3];
                    Form1.libriElenco[thisLibro.Isbn].Immagine = campi[4];
                    Form1.libriElenco[thisLibro.Isbn].Descrizione = campi[5];
                    Form1.libriElenco[thisLibro.Isbn].Anno = campi[6];
                }
                this.Close();
            }
            else
            {
                lblTitolo.Text = campi[index];
                if (!IsCrea)
                {
                    txtField.Texts = typeof(Libro).GetProperty(campi[index]).GetValue(thisLibro, null).ToString();
                } else
                {
                    txtField.Texts = "";
                }
            }
        }
    
    }
}
