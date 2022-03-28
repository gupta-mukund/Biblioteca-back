using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Biblioteca
{
    public partial class Form1 : Form
    {
        public static Dictionary<string, User> usersElenco;
        private string SelectedPanelColour = "#6FE0CC";
        private Label currentLabel;
        private string NotSelectedPanelColour = "#505F74";
        public Form1()
        {
            InitializeComponent();
            currentLabel = this.lblLogin;
            lblTitolo.Text = currentLabel.Text;
            btnLogin.Text = currentLabel.Text;
            usersElenco = new Dictionary<string, User>();
            Methods.Deserialize(Directory.GetCurrentDirectory() + @"\users.json", "CodiceFiscale", out usersElenco);
            panel4.BackColor = ColorTranslator.FromHtml("#6FE0CC");
            panel1.BackColor = ColorTranslator.FromHtml("#253243");
            pnlSignup.BackColor = ColorTranslator.FromHtml(SelectedPanelColour);
            pnlLogin.BackColor = ColorTranslator.FromHtml(NotSelectedPanelColour);
            pcbIconMain.Image = Properties.Resources.libraryIcon;
            pcbIconMain.SizeMode = PictureBoxSizeMode.StretchImage;
            txtUsername.Texts = "tyjikr47f60m553c";
            txtPassword.Texts = "dIIosgaCb4w";
            btnLogin_Click(null, null);
        }

        public static void ReloadUsers()
        {
            usersElenco = null;
            Methods.Deserialize(Directory.GetCurrentDirectory() + @"\users.json", "CodiceFiscale", out usersElenco);
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LabelLoginClicks(object sender, EventArgs e)
        {
            Label send = (Label)sender;
            if (send != currentLabel)
            {
                currentLabel = send;
                lblTitolo.Text = currentLabel.Text;
                btnLogin.Text = currentLabel.Text;
            }
        }
    }
}
