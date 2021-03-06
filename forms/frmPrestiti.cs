using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Biblioteca.forms
{
    public partial class frmPrestiti : Form
    {
        public static List<Prestito> myPrestiti;
        private delegate void BindingCallback(); 
        public frmPrestiti()
        {
            InitializeComponent();
            frmMainPage.OnPrestitiChange += FrmMainPage_OnPrestitiChange;
            frmMainPage.OnUsersChange += FrmMainPage_OnUsersChange;
            myPrestiti = new List<Prestito>();
            GetPrestiti();
            BindPrenotazioni();
            BindStorico();
        }

        private void FrmMainPage_OnUsersChange(object sender, EventArgs e)
        {
            BindStorico();
        }

        private void FrmMainPage_OnPrestitiChange(object sender, EventArgs e)
        {
            //eseguo il data binding dei vari dati quando cambiano
            GetPrestiti();
            BindPrenotazioni();
        }
        private void GetPrestiti()
        {
            if (Form1.prestiti != null)
            {
                myPrestiti = (from u in Form1.prestiti
                              where u.Prestiti.ContainsKey(frmMainPage.currentUser.CodiceFiscale)
                              select u).ToList();
            }
        }
        private void BindPrenotazioni()
        {
            if (dgvPrestiti.InvokeRequired)
            {
                BindingCallback d = new BindingCallback(BindPrenotazioni);
                this.Invoke(d);
            } else
            {
                dgvPrestiti.DataSource = null;
                dgvPrestiti.DataSource = myPrestiti.Select(p => new { Titolo = Form1.libriElenco[p.Isbn].Titolo, Scadenza = p.Prestiti[frmMainPage.currentUser.CodiceFiscale].AddDays(30) }).ToList();   
            }
        }

        public void BindStorico()
        {
            if (Form1.usersElenco[frmMainPage.currentUser.CodiceFiscale].Storico != null)
            {
                this.dgvStorico.DataSource = Form1.usersElenco[frmMainPage.currentUser.CodiceFiscale].Storico
                .Select(p => new
                {
                    Isbn = p,
                    Titolo = Form1.libriElenco[p].Titolo,
                    Autore = Form1.libriElenco[p].Autori,
                    Anno = Form1.libriElenco[p].Anno,
                }).ToList();
            }

        }
    }
}
