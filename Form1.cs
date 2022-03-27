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
        public Form1()
        {
            InitializeComponent();
            usersElenco = new Dictionary<string, User>();
            Methods.Deserialize(Directory.GetCurrentDirectory() + @"\users.json", "CodiceFiscale", out usersElenco);
            txtUsername.Texts = "TYJIKR47F60M553C";
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
            if (!String.IsNullOrEmpty(txtUsername.Texts) && !string.IsNullOrEmpty(txtPassword.Texts))
            {
                if (usersElenco.ContainsKey(txtUsername.Texts))
                {
                    if (usersElenco[txtUsername.Texts].Password == txtPassword.Texts) UserLogin(usersElenco[txtUsername.Texts]);
                    else MessageBox.Show("wrong password");
                }
                else
                {
                    MessageBox.Show("no user");
                }
            }
        }

        private void AdminLogin(User user)
        {

        }
        private void UserLogin(User user)
        {
            var form = new frmMainPage(user);
            form.Show();
        }
    }
}
