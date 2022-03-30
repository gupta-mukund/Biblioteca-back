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
        
        // oggetto che vede i cambiamenti nei file
        public FileSystemWatcher watcher;

        // evnti che triggerò quando i file venogno cambiati e devono essere aggiornati
        public static event EventHandler OnPrestitiChange;
        public static event EventHandler OnBookChange;
        public static event EventHandler OnUsersChange;

        private string currentForm;

        //dizionario che mi permette di aggiungere i diversi form in un'unico form
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
            //attributi di quando il watcher mi deve notificare
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
            //quando il watcher vede cambiamenti, ricarico i dati e lo dico altri form che aggiornano i loro
            
            switch (e.Name)
            {
                case "prestiti.json":
                case "book.json":
                case "user.json":
                    if (Methods.ReloadData(Directory.GetCurrentDirectory() + @"\prestiti.json", "", ref Form1.prestiti)) OnPrestitiChange?.Invoke(null, null);
                    if (Methods.ReloadData(Directory.GetCurrentDirectory() + @"\books.json", "Isbn", ref Form1.libriElenco)) OnBookChange?.Invoke(null, null);
                    if (Methods.ReloadData(Directory.GetCurrentDirectory() + @"\users.json", "CodiceFiscale", ref Form1.usersElenco)) OnUsersChange?.Invoke(null, null);
                    break;
                default:
                    break;
            }
            //Console.WriteLine("{0}, with path {1} has been {2}", e.Name, e.FullPath, e.ChangeType);
        }

        //evento che uso per caricare i vari form
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
