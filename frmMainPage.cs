using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.IO;
namespace Biblioteca
{
    public partial class frmMainPage : Form
    {
        private IconButton currentFormBtn;
        public static User currentUser;
        public forms.frmBooks BooksForm;
        public forms.frmPrestiti PrestitiForm;
        public forms.frmCarta CartaForm;
        public frmRecensioni RecensioniForm;
        
        //public static DateTime ExecutedTime;
        public FileSystemWatcher watcher;

        public static event EventHandler OnPrestitiChange;
        public static event EventHandler OnBookChange;
        public static event EventHandler OnUsersChange;

        private string currentForm;

        private Dictionary<string, Form> formReference;
        public frmMainPage(User user)
        {
            InitializeComponent();
            this.btnCarta.IconChar = IconChar.IdCard;
            this.btnLogOut.IconChar = IconChar.ArrowCircleRight;
            pnlProfileInfo.BackColor = ColorTranslator.FromHtml("#6FE0CC");
            pnlMain.BackColor = ColorTranslator.FromHtml("#253243");
            pnlMainTitle.BackColor = ColorTranslator.FromHtml("#253243");
            this.Text = user.GetFullName();
            foreach (KeyValuePair<string, Libro> item in Form1.libriElenco)
            {
                item.Value.CalculateRating();
            }
            
            watcher = new FileSystemWatcher();
            watcher.Path = Directory.GetCurrentDirectory();
            //ExecutedTime = DateTime.Now;
            watcher.NotifyFilter = NotifyFilters.Attributes |
                NotifyFilters.CreationTime |
                NotifyFilters.DirectoryName |
                NotifyFilters.FileName |
                NotifyFilters.LastAccess |
                NotifyFilters.LastWrite |
                NotifyFilters.Security |
                NotifyFilters.Size;
            watcher.Filter = "*.json";
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.EnableRaisingEvents = true;

            this.formReference = new Dictionary<string, Form>();
            currentUser = user;
            lblCodiceFiscale.Text = currentUser.CodiceFiscale;
            //pcbProfile.ImageLocation = $"https://via.placeholder.com/1000.png/FFFFFF/000000?text={currentUser.GetFullName()}";

            BooksForm = new forms.frmBooks();
            PrestitiForm = new forms.frmPrestiti();
            CartaForm = new forms.frmCarta();
            RecensioniForm = new frmRecensioni();
            formReference.Add("UserBooks", BooksForm);
            formReference.Add("UserPrestiti", PrestitiForm);
            formReference.Add("Carta", CartaForm);
            formReference.Add("Recensioni", RecensioniForm);
            currentForm = "UserBook";
            ChangeForm(formReference["UserBooks"]);
        }

        public static void OnChanged(object source, FileSystemEventArgs e)
        {
            
            switch (e.Name)
            {
                case "prestiti.json":
                case "book.json":
                case "user.json":
                    if (Methods.ReloadData(Directory.GetCurrentDirectory() + @"\prestiti.json", "", ref Form1.prestiti)) OnPrestitiChange?.Invoke(null, null);
                    if (Methods.ReloadData(Directory.GetCurrentDirectory() + @"\books.json", "Isbn", ref Form1.libriElenco)) OnBookChange?.Invoke(null, null);
                    if (Methods.ReloadData(Directory.GetCurrentDirectory() + @"\users.json", "CodiceFiscale", ref Form1.usersElenco)) OnUsersChange?.Invoke(null, null);
                    break;
                //case "books.json":
                //    Methods.ReloadData(Directory.GetCurrentDirectory() + @"\books.json", "Isbn", ref Form1.libriElenco);
                //    //ReloadBooks();
                //    OnBookChange?.Invoke(null, null);
                //    break;
                //case "users.json":
                //    Methods.ReloadData(Directory.GetCurrentDirectory() + @"\users.json", "CodiceFiscale", ref Form1.usersElenco);
                //    OnUsersChange?.Invoke(null, null);
                //    break;
                default:
                    break;
            }
            //Console.WriteLine("{0}, with path {1} has been {2}", e.Name, e.FullPath, e.ChangeType);
        }

        //public static void ReloadBooks()
        //{
        //    Form1.libriElenco = null;
        //    Methods.Deserialize(Directory.GetCurrentDirectory() + @"\books.json", "Isbn", out Form1.libriElenco);
        //}
        //public static void ReloadPrestiti()
        //{
        //    Form1.prestiti = null;
        //    Methods.Deserialize(Directory.GetCurrentDirectory() + @"\prestiti.json", "", out Form1.prestiti);
        //}
        public void ChangeForm(object form)
        {
            this.pnlCentralPage.Controls.Clear();
            currentForm = ((Form)form).Tag.ToString();

            Form f = form as Form;
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.pnlCentralPage.Controls.Add(f);
            f.Show();

        }
        
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentFormBtn != (IconButton)btnSender)
                {
                    DisableButton();
                    currentFormBtn = (IconButton)btnSender;
                    currentForm = "";
                    currentFormBtn.BackColor = Color.Red;
                    //currentButton.ForeColor = Color.White;
                    //currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    //panelTitleBar.BackColor = color;
                    //panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    //ThemeColor.PrimaryColor = color;
                    //ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    //btnCloseChildForm.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in pnlMain.Controls)
            {
                if (previousBtn.GetType() == typeof(IconButton))
                {
                    previousBtn.BackColor = Color.Green;
                    //previousBtn.ForeColor = Color.Gainsboro;
                    //previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        public bool CheckCurrentForm(string actualForm)
        {
            if (actualForm != currentForm) return true;

            return false;

        }
        private void ButtonClick(object sender, EventArgs e)
        {
            string form = ((IconButton)sender).Tag.ToString();
            currentFormBtn = (IconButton)sender;
            if (CheckCurrentForm(form))
            {
                ActivateButton(sender);
                ChangeForm(formReference[form]);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.Istance.Show();
        }
    }
}
