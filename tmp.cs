using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.components;

namespace Biblioteca
{
    public partial class tmp : Form
    {
        
        public tmp()
        {
            InitializeComponent();
            //dgv.Columns.Clear();
            //DataGridViewImageColumn clm = new DataGridViewImageColumn();
            //clm.HeaderText = "phtoo";
            //clm.Name = "photo";
            //dgv.Columns.Add(clm);
            dgv.RowTemplate.Height = 200;
            //DataGridViewColumn clom = new DataGridViewColumn();
            //clm.HeaderText = "text";
            //clm.Name = "text";
            //dgv.Columns.Add(clom);
            dgv.BackgroundColor = Color.White;
            dgv.RowHeadersVisible = false;


            //BookTextCell cell1 = new BookTextCell();
            //this.dgv.Controls.Add(cell1);
            //cell1.Dock = DockStyle.Top;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            flowLayoutPanel1.Controls.Add(new BookTextCell());
            flowLayoutPanel1.Controls.Add(new BookTextCell());
            flowLayoutPanel1.Controls.Add(new BookTextCell());
            flowLayoutPanel1.Controls.Add(new BookTextCell());
            flowLayoutPanel1.Controls.Add(new BookTextCell());


            //Image img = Image.FromFile(@"C:\Users\gupta\OneDrive\Desktop\Image_created_with_a_mobile_phone.png");
            // dgv.Rows.Add(img, "ciao");

            //dgv.Rows.Add(Image.FromFile(@"C:\Users\gupta\OneDrive\Desktop\offset_comp_772626-opt.jpg"), "sisisiis");
        }

        private void dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
           e.AdvancedBorderStyle.All = DataGridViewAdvancedCellBorderStyle.None;
        }
    }
}
