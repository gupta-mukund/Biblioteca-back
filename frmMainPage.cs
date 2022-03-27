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
        public static Dictionary<string, Libro> libriElenco;
        public static List<Prestito> prestiti;
        public static DateTime ExecutedTime;
        public FileSystemWatcher watcher;

        public static event EventHandler OnPrestitiChange;
        public static event EventHandler OnBookChange;
        public static event EventHandler OnUsersChange;

        private string currentForm;

        private Dictionary<string, Form> formReference;
        public frmMainPage(User user)
        {
            InitializeComponent();
            libriElenco = new Dictionary<string, Libro>();
            Methods.Deserialize(Directory.GetCurrentDirectory() + @"\books.json", "Isbn", out libriElenco);
            Methods.Deserialize(Directory.GetCurrentDirectory() + @"\prestiti.json", "", out prestiti);
            watcher = new FileSystemWatcher();
            watcher.Path = Directory.GetCurrentDirectory();
            ExecutedTime = DateTime.Now;
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
            lblNome.Text = currentUser.GetFullName();
            
            BooksForm = new forms.frmBooks();
            PrestitiForm = new forms.frmPrestiti();
            formReference.Add("UserBooks", BooksForm);
            formReference.Add("UserPrestiti", PrestitiForm);
            currentForm = "UserBook";
            ChangeForm(formReference["UserBooks"]);
        }

        public static void OnChanged(object source, FileSystemEventArgs e)
        {
            switch (e.Name)
            {
                case "prestiti.json":
                    ReloadPrestiti();
                    OnPrestitiChange?.Invoke(null, null);
                    break;
                case "books.json":
                    ReloadBooks();
                    OnBookChange?.Invoke(null, null);
                    break;
                case "users.json":
                    Form1.ReloadUsers();
                    OnUsersChange?.Invoke(null, null);
                    break;
                default:
                    break;
            }
            //Console.WriteLine("{0}, with path {1} has been {2}", e.Name, e.FullPath, e.ChangeType);
        }

        public static void ReloadBooks()
        {
            libriElenco = null;
            Methods.Deserialize(Directory.GetCurrentDirectory() + @"\books.json", "Isbn", out libriElenco);
        }
        public static void ReloadPrestiti()
        {
            prestiti = null;
            Methods.Deserialize(Directory.GetCurrentDirectory() + @"\prestiti.json", "", out prestiti);
        }
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
    }
}
