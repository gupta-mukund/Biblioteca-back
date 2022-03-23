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
        List<Prestito> myPrestiti;
        public frmPrestiti()
        {
            InitializeComponent();
            frmBooks.OnPrestitiChange += FrmBooks_OnPrestitiChange;
            myPrestiti = new List<Prestito>();
            //dgvPrestiti.DataSource = frmMainPage.currentUser.GetPrestiti().Where(o => new { });
            GetPrestiti();

            BindPrenotazioni();
        }

        private void FrmBooks_OnPrestitiChange(object sender, EventArgs e)
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
            if (myPrestiti.Count > 0)
            {
                dgvPrestiti.DataSource = myPrestiti.Select(p => new { Titolo = frmMainPage.libriElenco[p.Isbn].Titolo}).ToList();
            }
            
            return;
        }
    }
}
