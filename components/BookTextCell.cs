using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.components
{
    public partial class BookTextCell : UserControl
    {
        private Libro _identity;
        public event EventHandler<Data> Prenota;
        private BindingSource dataSource;
        public Libro Identity {
            get { return _identity; }
            set
            {
                if (value != null) 
                { 
                    _identity = value;
                    dataSource.DataSource = _identity;
                }
                
            }
        }
        public BookTextCell()
        {
            InitializeComponent();
            pcbPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            dataSource = new BindingSource();
            dataSource.DataSource = typeof(Libro);
            this.lblGenere.DataBindings.Add(new Binding("Text", dataSource, "Categorie"));
            this.lblTitolo.DataBindings.Add(new Binding("Text", dataSource, "Titolo"));
            this.lblDescrizione.DataBindings.Add(new Binding("Text", dataSource, "Descrizione"));
            this.lblAutore.DataBindings.Add(new Binding("Text", dataSource, "Autori"));
            this.lblAnno.DataBindings.Add(new Binding("Text", dataSource, "Anno"));
            this.pcbPicture.DataBindings.Add(new Binding("ImageLocation", dataSource, "Immagine"));

        }

        public void NormalizeButton()
        {
            this.btnPrenota.Text = "Prenota";
            this.btnPrenota.Enabled = true;
        }
        public void FinishedBook()
        {
            this.btnPrenota.Text = "Finito";
            this.btnPrenota.Enabled = false;
        }
        private void btnPrenota_Click(object sender, EventArgs e)
        {
            Prenota?.Invoke(this, new Data(this.Identity));
        }
    }

    public class Data : EventArgs
    {
        public Libro Book { get; set; }
        public Data(Libro book)
        {
            Book = book;
        }
    }
}
