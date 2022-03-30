﻿using System;
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
    public partial class frmCarta : Form
    {
        public frmCarta()
        {
            InitializeComponent();
            this.lblPunti.Text = frmMainPage.currentUser.Punti.ToString();
            frmMainPage.OnUsersChange += FrmMainPage_OnUsersChange;
        }

        private void FrmMainPage_OnUsersChange(object sender, EventArgs e)
        {
            this.lblPunti.Text = frmMainPage.currentUser.Punti.ToString();
        }
    }
}