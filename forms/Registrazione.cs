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

namespace Biblioteca
{
    public partial class Registrazione : Form
    {
        private string[] campi;
        private string[] results;
        private int index;
        public Registrazione()
        {
            InitializeComponent();
            index = 0;
            results = new string[7];
            campi = new string[] {"Nome", "Cognome", "Email", "Città", "Codice Fiscale", "Password", "Data di nascita" };
            lblTitolo.Text = campi[index];
        }
        private void btnNext_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(txtField.Texts))
            {
                if (campi[index] == "Codice Fiscale")
                {
                    if (txtField.Texts.Length < 16)
                    {
                        MessageBox.Show("Codice Fiscale Invalido");
                        return;
                    }
                    if (Form1.usersElenco.ContainsKey(txtField.Texts))
                    {
                        MessageBox.Show("utente già registrato");
                        return;
                    }
                }
                results[index] = txtField.Texts.Trim();
                index++;
                CheckFormEnd();
            } else
            {
                MessageBox.Show("Compila Campo");
            }
        }

        private void CheckFormEnd()
        {
            if (index == campi.Length)
            {
                    User tmp = new User();
                    tmp.Nome = results[0];
                    tmp.Cognome = results[1];
                    tmp.Email = results[2];
                    tmp.Citta = results[3];
                    tmp.CodiceFiscale = results[4];
                    tmp.Password = results[5];
                    tmp.DataNascita = results[6];
                    tmp.Ruolo = "user";
                    Form1.usersElenco.Add(campi[4], tmp);
                    this.Close();         
            } else
            {
                lblTitolo.Text = campi[index];
                txtField.Texts = "";
            }
        }
    }
}
