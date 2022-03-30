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
using System.IO;

namespace Biblioteca.forms
{
    public partial class GestioneLibro : Form
    {
        private string[] campi;
        private string[] results;
        private bool IsCrea;
        private Libro thisLibro;
        private User thisUser;
        private Type theType;
        private int index;
        private string code;
        public GestioneLibro(Libro libro, bool crea, Type type)
        {
            InitializeComponent();
            index = 0;
            thisLibro = libro;
            results = new string[7];
            theType = type;
            campi = new string[] { "Titolo", "Autori", "Sottotitolo", "Categorie", "Immagine", "Descrizione", "Anno" };
            lblTitolo.Text = campi[index];
            IsCrea = crea;
            if (!IsCrea)
            {
                txtField.Texts = typeof(Libro).GetProperty(campi[index]).GetValue(thisLibro, null).ToString();
            }
        }

        public GestioneLibro(User user, bool crea, Type type)
        {
            InitializeComponent();
            index = 0;
            thisUser = user;
            results = new string[6];
            theType = type;
            campi = new string[] { "Nome", "Cognome", "Email", "Citta", "Password", "DataNascita" };
            lblTitolo.Text = campi[index];
            IsCrea = crea;
            if (!IsCrea)
            {
                txtField.Texts = typeof(User).GetProperty(campi[index]).GetValue(thisUser, null).ToString();
            }
        }
        public GestioneLibro(string codice, bool crea, Type type)
        {
            InitializeComponent();
            index = 0;
            code = codice;
            theType = type;
            if (type == typeof(Libro))
            {
                results = new string[7];
                campi = new string[] { "Titolo", "Autori", "Sottotitolo", "Categorie", "Immagine", "Descrizione", "Anno" };
                lblTitolo.Text = campi[index];
                IsCrea = crea;
                if (!IsCrea)
                {
                    txtField.Texts = typeof(Libro).GetProperty(campi[index]).GetValue(thisLibro, null).ToString();
                }
            }
            else if (type == typeof(User))
            {
                results = new string[6];
                campi = new string[] { "Nome", "Cognome", "Email", "Citta", "Password", "DataNascita" };
                lblTitolo.Text = campi[index];
                IsCrea = crea;
                if (!IsCrea)
                {
                    txtField.Texts = typeof(User).GetProperty(campi[index]).GetValue(thisUser, null).ToString();
                }
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
                if (theType == typeof(Libro))
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
                        Form1.libriElenco.Add(code, tmp);
                    }
                    else
                    {
                        Form1.libriElenco[thisLibro.Isbn].Titolo = results[0];
                        Form1.libriElenco[thisLibro.Isbn].Autori = results[1];
                        Form1.libriElenco[thisLibro.Isbn].Sottotitolo = results[2];
                        Form1.libriElenco[thisLibro.Isbn].Categorie = results[3];
                        Form1.libriElenco[thisLibro.Isbn].Immagine = results[4];
                        Form1.libriElenco[thisLibro.Isbn].Descrizione = results[5];
                        Form1.libriElenco[thisLibro.Isbn].Anno = results[6];
                    }
                    if (Methods.Serialize(Form1.libriElenco, Directory.GetCurrentDirectory() + @"\books.json")) this.Close();
                }
                else if (theType == typeof(User))
                {
                    if (IsCrea)
                    {
                        campi = new string[] { "Nome", "Cognome", "Email", "Citta", "Password", "DataNascita" };
                        User tmp = new User();
                        tmp.Nome = results[0];
                        tmp.Cognome = results[1];
                        tmp.Email = results[2];
                        tmp.CodiceFiscale = code;
                        tmp.Ruolo = "user";
                        tmp.Citta = results[3];
                        tmp.Password = results[4];
                        tmp.DataNascita = results[5];
                        Form1.usersElenco.Add(code, tmp);
                    } else
                    {
                        Form1.usersElenco[thisUser.CodiceFiscale].Nome = results[0];
                        Form1.usersElenco[thisUser.CodiceFiscale].Cognome = results[1];
                        Form1.usersElenco[thisUser.CodiceFiscale].Email = results[2];
                        Form1.usersElenco[thisUser.CodiceFiscale].Citta = results[3];
                        Form1.usersElenco[thisUser.CodiceFiscale].Password = results[4];
                        Form1.usersElenco[thisUser.CodiceFiscale].DataNascita = results[5];
                    }
                    if (Methods.Serialize(Form1.usersElenco, Directory.GetCurrentDirectory() + @"\users.json")) this.Close();
                }
                

            }
            else
            {
                lblTitolo.Text = campi[index];
                if (!IsCrea)
                {
                    txtField.Texts = theType.GetProperty(campi[index]).GetValue(thisLibro, null).ToString();
                } else
                {
                    txtField.Texts = "";
                }
            }
        }
    
    }
}
