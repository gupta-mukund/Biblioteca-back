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
            //frmBooks.OnPrestitiChange += FrmBooks_OnPrestitiChange;
            myPrestiti = new List<Prestito>();
            //dgvPrestiti.DataSource = frmMainPage.currentUser.GetPrestiti().Where(o => new { });
            GetPrestiti();

            BindPrenotazioni();
        }

        private void FrmMainPage_OnPrestitiChange(object sender, EventArgs e)
        {
            GetPrestiti();
            BindPrenotazioni();
        }
        private void GetPrestiti()
        {
            if (frmMainPage.prestiti != null)
            {
                myPrestiti = (from u in frmMainPage.prestiti
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
                dgvPrestiti.DataSource = myPrestiti.Select(p => new { Titolo = frmMainPage.libriElenco[p.Isbn].Titolo, Scadenza = p.Prestiti[frmMainPage.currentUser.CodiceFiscale].AddDays(30) }).ToList();   
            }
        }
    }
}
