using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.IO;
using Newtonsoft.Json;
namespace Biblioteca
{
    public partial class Form1 : Form
    {
        public static Dictionary<string, User> usersElenco;
        private string SelectedPanelColour = "#6FE0CC";
        public static List<Prestito> prestiti;
        public static Dictionary<string, Libro> libriElenco;
        private Label currentLabel;
        private string NotSelectedPanelColour = "#505F74";
        private BackgroundWorker emailWorker;
        public static Form1 Istance;
        private System.Timers.Timer emailTimer;
        public Form1()
        {
            //deserializzo i vari dati
            Methods.Deserialize(Directory.GetCurrentDirectory() + @"\books.json", "Isbn", ref libriElenco);
            Methods.Deserialize(Directory.GetCurrentDirectory() + @"\users.json", "CodiceFiscale", ref usersElenco);
            Methods.Deserialize(Directory.GetCurrentDirectory() + @"\prestiti.json", "", ref prestiti);
            
            InitializeComponent();
            Istance = this;
            //inizio un background worker che controlla se ci sono email da mandare
            emailWorker = new BackgroundWorker();
            emailWorker.DoWork += EmailWorker_DoWork;
            emailTimer = new System.Timers.Timer(20 * 1000);
            emailTimer.Elapsed += EmailTimer_Elapsed;
            emailTimer.Start();

            currentLabel = this.lblLogin;
            lblTitolo.Text = currentLabel.Text;
            btnLogin.Text = currentLabel.Text;
            
            panel4.BackColor = ColorTranslator.FromHtml("#6FE0CC");
            panel1.BackColor = ColorTranslator.FromHtml("#253243");
            pnlSignup.BackColor = ColorTranslator.FromHtml(SelectedPanelColour);
            pnlLogin.BackColor = ColorTranslator.FromHtml(NotSelectedPanelColour);
            pcbIconMain.Image = Properties.Resources.libraryIcon;
            pcbIconMain.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        
        private void EmailTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (!emailWorker.IsBusy)
            {
                emailWorker.RunWorkerAsync();
            }
        }

        private void EmailWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int index = 0;
            foreach (Prestito item in prestiti)
            {
                foreach (KeyValuePair<string, DateTime> it in item.Prestiti)
                {
                    var client = new SmtpClient("smtp.mailtrap.io", 2525)
                    {
                        Credentials = new NetworkCredential("9e08f2fd43d2b3", "e7426694403040"),
                        EnableSsl = true
                    };
                    string text;
                    
                    if (it.Value.AddDays(30).Subtract(DateTime.Now).TotalMinutes <= 40)
                    {
                        MessageBox.Show(it.Value.AddDays(30).Subtract(DateTime.Now).TotalMinutes.ToString());
                        text = "Buongiorno gentile cliente,\n" +
                           $"Le informiamo che il suo prestito '{Form1.libriElenco[item.Isbn].Titolo}' scade tra poco.\n\n" +
                           "Biblioteca di Manchester.";
                        client.Send("manchesterlibrary@library.com", $"{Form1.usersElenco[it.Key].GetFullName().Replace(" ", "")}@client.com", "Promemoria resituzione libro", text);
                    }
                    else if (it.Value.AddDays(30) <= DateTime.Now)
                    {
                        text = "Buongiorno gentile cliente,\n" +
                            $"Le informiamo che il suo prestito '{Form1.libriElenco[item.Isbn].Titolo}' non è stato consegnato in tempo.\n\n" +
                            "Biblioteca di Manchester.";
                        client.Send("manchesterlibrary@library.com", $"{Form1.usersElenco[it.Key].GetFullName().Replace(" ", "")}@client.com", "Promemoria resituzione libro", text);
                        HandleRitardoPrestito(it.Key, index);
                    }
                }
                index++;
            }

        }
        private void HandleRitardoPrestito(string codice, int position)
        {
            //se sono in ritardo, tolgo punti all'utente
            prestiti[position].Prestiti.Remove(codice);
            usersElenco[codice].Punti--;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (currentLabel == lblLogin)
            {
                Login();
            }
            else if (currentLabel == lblSignup)
            {
                SigningUp();
            }
        }
        private void Login()
        {
            //sistema di login
            if(!String.IsNullOrEmpty(txtUsername.Texts.Trim()) && !string.IsNullOrEmpty(txtPassword.Texts.Trim()))
            {
                if (usersElenco.ContainsKey(txtUsername.Texts.ToUpper()))
                {
                    if (usersElenco[txtUsername.Texts.ToUpper()].Password == txtPassword.Texts) {
                        if (usersElenco[txtUsername.Texts.ToUpper()].Ruolo == "admin")
                        {
                            AdminLogin(usersElenco[txtUsername.Texts.ToUpper()]);
                        } else
                        {
                            UserLogin(usersElenco[txtUsername.Texts.ToUpper()]);
                        }
                        txtPassword.Texts = "";
                        txtUsername.Texts = "";
                        this.Hide();
                    }
                    
                    else MessageBox.Show("wrong password");
                }

                
                else
                {
                    MessageBox.Show("no user");
                }
            }
        }

        private void SigningUp()
        {
            if (!String.IsNullOrEmpty(txtUsername.Texts.Trim()) && !string.IsNullOrEmpty(txtPassword.Texts.Trim()))
            {
                if (usersElenco.ContainsKey(txtUsername.Texts))
                {
                    if (usersElenco[txtUsername.Texts.Trim()].Password == txtPassword.Texts && usersElenco[txtUsername.Texts.Trim()].Ruolo == "admin")
                    {
                        new Registrazione().Show();
                    }  
                }
                else
                {
                    MessageBox.Show("no admin");
                }
            }
        }
        private void AdminLogin(User user)
        {
            var form = new frmAdmin(user);
            form.Show();
        }
        private void UserLogin(User user)
        {
            var form = new frmMainPage(user);
            form.Show();
        }

        

        private void LabelLoginClicks(object sender, EventArgs e)
        {
            Label send = (Label)sender;
            if (send != currentLabel)
            {
                currentLabel = send;
                
                if (send.Text == "Sign Up")
                {
                    lblAdmin.Visible = true;
                } else
                {
                    lblAdmin.Visible = false;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Methods.Serialize(libriElenco, Directory.GetCurrentDirectory() + @"\books.json");
            Methods.Serialize(usersElenco, Directory.GetCurrentDirectory() + @"\users.json");
            Methods.Serialize(prestiti, Directory.GetCurrentDirectory() + @"\prestiti.json");
        }

        private void ckbPassShow_CheckStateChanged(object sender, EventArgs e)
        {
            if (ckbPassShow.Checked)
            {
                txtPassword.PasswordChar = false;
                lblShow.Text = "Hide Password";
            } else
            {
                txtPassword.PasswordChar = true;
                lblShow.Text = "Show Password";
            }
        }
    }
}
