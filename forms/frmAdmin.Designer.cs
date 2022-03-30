
namespace Biblioteca
{
    partial class frmAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNome = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvLibri = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvUtenti = new System.Windows.Forms.DataGridView();
            this.btnModifica = new Biblioteca.CustomButton();
            this.btnElimina = new Biblioteca.CustomButton();
            this.btnReset = new Biblioteca.CustomButton();
            this.btnFiltra = new Biblioteca.CustomButton();
            this.txtBookName = new Biblioteca.components.LoginCustomTextBox();
            this.txtNewIsbn = new Biblioteca.components.LoginCustomTextBox();
            this.btnAdd = new Biblioteca.CustomButton();
            this.btnModificaUser = new Biblioteca.CustomButton();
            this.btnEliminaUser = new Biblioteca.CustomButton();
            this.btnResetUSer = new Biblioteca.CustomButton();
            this.btnFiltraUser = new Biblioteca.CustomButton();
            this.txtNome = new Biblioteca.components.LoginCustomTextBox();
            this.txtNewUser = new Biblioteca.components.LoginCustomTextBox();
            this.btnNewUser = new Biblioteca.CustomButton();
            this.txtLoginCodice = new Biblioteca.components.LoginCustomTextBox();
            this.btnEntraUser = new Biblioteca.CustomButton();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibri)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtenti)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1170, 40);
            this.panel1.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNome.Location = new System.Drawing.Point(0, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(1170, 40);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "label2";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1170, 520);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1162, 491);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Libri";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvLibri, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1156, 485);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel8, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel7, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(200, 485);
            this.tableLayoutPanel5.TabIndex = 17;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Controls.Add(this.btnModifica, 0, 1);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 387);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 3;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(200, 98);
            this.tableLayoutPanel8.TabIndex = 10;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Controls.Add(this.btnElimina, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 290);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(200, 97);
            this.tableLayoutPanel7.TabIndex = 9;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.txtBookName, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(200, 145);
            this.tableLayoutPanel6.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome Libro";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnReset, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnFiltra, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 86);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 59);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.txtNewIsbn, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnAdd, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 145);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.84211F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.31579F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.31579F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(200, 145);
            this.tableLayoutPanel4.TabIndex = 8;
            // 
            // dgvLibri
            // 
            this.dgvLibri.AllowUserToAddRows = false;
            this.dgvLibri.AllowUserToDeleteRows = false;
            this.dgvLibri.AllowUserToResizeColumns = false;
            this.dgvLibri.AllowUserToResizeRows = false;
            this.dgvLibri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLibri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLibri.Location = new System.Drawing.Point(203, 3);
            this.dgvLibri.Name = "dgvLibri";
            this.dgvLibri.RowHeadersVisible = false;
            this.dgvLibri.RowHeadersWidth = 51;
            this.dgvLibri.RowTemplate.Height = 24;
            this.dgvLibri.Size = new System.Drawing.Size(950, 479);
            this.dgvLibri.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel9);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1162, 491);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Utenti";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1162, 491);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Resituzione";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.txtLoginCodice, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnEntraUser, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1162, 491);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(481, 197);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codice Fiscale";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.dgvUtenti, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel10, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(1156, 485);
            this.tableLayoutPanel9.TabIndex = 1;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel11, 0, 3);
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel12, 0, 2);
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel13, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel15, 0, 1);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 4;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(200, 485);
            this.tableLayoutPanel10.TabIndex = 17;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 1;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel11.Controls.Add(this.btnModificaUser, 0, 1);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(0, 387);
            this.tableLayoutPanel11.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 3;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(200, 98);
            this.tableLayoutPanel11.TabIndex = 10;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 1;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel12.Controls.Add(this.btnEliminaUser, 0, 1);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(0, 290);
            this.tableLayoutPanel12.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 3;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(200, 97);
            this.tableLayoutPanel12.TabIndex = 9;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 1;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel13.Controls.Add(this.tableLayoutPanel14, 0, 2);
            this.tableLayoutPanel13.Controls.Add(this.txtNome, 0, 1);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel13.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 3;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(200, 145);
            this.tableLayoutPanel13.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Location = new System.Drawing.Point(3, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.ColumnCount = 2;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.Controls.Add(this.btnResetUSer, 0, 0);
            this.tableLayoutPanel14.Controls.Add(this.btnFiltraUser, 0, 0);
            this.tableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel14.Location = new System.Drawing.Point(0, 86);
            this.tableLayoutPanel14.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 1;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(200, 59);
            this.tableLayoutPanel14.TabIndex = 7;
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.ColumnCount = 1;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel15.Controls.Add(this.txtNewUser, 0, 1);
            this.tableLayoutPanel15.Controls.Add(this.btnNewUser, 0, 2);
            this.tableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel15.Location = new System.Drawing.Point(0, 145);
            this.tableLayoutPanel15.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 4;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.84211F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.31579F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.31579F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(200, 145);
            this.tableLayoutPanel15.TabIndex = 8;
            // 
            // dgvUtenti
            // 
            this.dgvUtenti.AllowUserToAddRows = false;
            this.dgvUtenti.AllowUserToDeleteRows = false;
            this.dgvUtenti.AllowUserToResizeColumns = false;
            this.dgvUtenti.AllowUserToResizeRows = false;
            this.dgvUtenti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUtenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUtenti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUtenti.Location = new System.Drawing.Point(203, 3);
            this.dgvUtenti.Name = "dgvUtenti";
            this.dgvUtenti.RowHeadersVisible = false;
            this.dgvUtenti.RowHeadersWidth = 51;
            this.dgvUtenti.RowTemplate.Height = 24;
            this.dgvUtenti.Size = new System.Drawing.Size(950, 479);
            this.dgvUtenti.TabIndex = 18;
            // 
            // btnModifica
            // 
            this.btnModifica.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnModifica.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnModifica.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnModifica.BorderRadius = 0;
            this.btnModifica.BorderSize = 0;
            this.btnModifica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModifica.FlatAppearance.BorderSize = 0;
            this.btnModifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifica.ForeColor = System.Drawing.Color.White;
            this.btnModifica.Location = new System.Drawing.Point(3, 32);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(194, 34);
            this.btnModifica.TabIndex = 1;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.TextColor = System.Drawing.Color.White;
            this.btnModifica.UseVisualStyleBackColor = false;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnElimina
            // 
            this.btnElimina.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnElimina.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnElimina.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnElimina.BorderRadius = 0;
            this.btnElimina.BorderSize = 0;
            this.btnElimina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnElimina.FlatAppearance.BorderSize = 0;
            this.btnElimina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElimina.ForeColor = System.Drawing.Color.White;
            this.btnElimina.Location = new System.Drawing.Point(3, 31);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(194, 34);
            this.btnElimina.TabIndex = 1;
            this.btnElimina.Text = "Elimina";
            this.btnElimina.TextColor = System.Drawing.Color.White;
            this.btnElimina.UseVisualStyleBackColor = false;
            this.btnElimina.Click += new System.EventHandler(this.btnElimina_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnReset.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnReset.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnReset.BorderRadius = 0;
            this.btnReset.BorderSize = 0;
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(103, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 27);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.TextColor = System.Drawing.Color.White;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnFiltra
            // 
            this.btnFiltra.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnFiltra.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnFiltra.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnFiltra.BorderRadius = 0;
            this.btnFiltra.BorderSize = 0;
            this.btnFiltra.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFiltra.FlatAppearance.BorderSize = 0;
            this.btnFiltra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltra.ForeColor = System.Drawing.Color.White;
            this.btnFiltra.Location = new System.Drawing.Point(3, 3);
            this.btnFiltra.Name = "btnFiltra";
            this.btnFiltra.Size = new System.Drawing.Size(94, 27);
            this.btnFiltra.TabIndex = 12;
            this.btnFiltra.Text = "Filtra";
            this.btnFiltra.TextColor = System.Drawing.Color.White;
            this.btnFiltra.UseVisualStyleBackColor = false;
            this.btnFiltra.Click += new System.EventHandler(this.btnFiltra_Click);
            // 
            // txtBookName
            // 
            this.txtBookName.BackColor = System.Drawing.SystemColors.Window;
            this.txtBookName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtBookName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtBookName.BorderSize = 2;
            this.txtBookName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookName.ForeColor = System.Drawing.Color.DimGray;
            this.txtBookName.Location = new System.Drawing.Point(3, 47);
            this.txtBookName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBookName.Multiline = false;
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Padding = new System.Windows.Forms.Padding(7);
            this.txtBookName.PasswordChar = false;
            this.txtBookName.Size = new System.Drawing.Size(194, 35);
            this.txtBookName.TabIndex = 8;
            this.txtBookName.Texts = "";
            this.txtBookName.UnderlinedStyle = false;
            // 
            // txtNewIsbn
            // 
            this.txtNewIsbn.BackColor = System.Drawing.SystemColors.Window;
            this.txtNewIsbn.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNewIsbn.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNewIsbn.BorderSize = 2;
            this.txtNewIsbn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtNewIsbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewIsbn.ForeColor = System.Drawing.Color.DimGray;
            this.txtNewIsbn.Location = new System.Drawing.Point(3, 29);
            this.txtNewIsbn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewIsbn.Multiline = false;
            this.txtNewIsbn.Name = "txtNewIsbn";
            this.txtNewIsbn.Padding = new System.Windows.Forms.Padding(7);
            this.txtNewIsbn.PasswordChar = false;
            this.txtNewIsbn.Size = new System.Drawing.Size(194, 35);
            this.txtNewIsbn.TabIndex = 9;
            this.txtNewIsbn.Texts = "";
            this.txtNewIsbn.UnderlinedStyle = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAdd.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd.BorderRadius = 0;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(3, 71);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(194, 32);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Nuovo";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModificaUser
            // 
            this.btnModificaUser.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnModificaUser.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnModificaUser.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnModificaUser.BorderRadius = 0;
            this.btnModificaUser.BorderSize = 0;
            this.btnModificaUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModificaUser.FlatAppearance.BorderSize = 0;
            this.btnModificaUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificaUser.ForeColor = System.Drawing.Color.White;
            this.btnModificaUser.Location = new System.Drawing.Point(3, 32);
            this.btnModificaUser.Name = "btnModificaUser";
            this.btnModificaUser.Size = new System.Drawing.Size(194, 34);
            this.btnModificaUser.TabIndex = 1;
            this.btnModificaUser.Text = "Modifica";
            this.btnModificaUser.TextColor = System.Drawing.Color.White;
            this.btnModificaUser.UseVisualStyleBackColor = false;
            this.btnModificaUser.Click += new System.EventHandler(this.btnModificaUser_Click);
            // 
            // btnEliminaUser
            // 
            this.btnEliminaUser.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEliminaUser.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEliminaUser.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEliminaUser.BorderRadius = 0;
            this.btnEliminaUser.BorderSize = 0;
            this.btnEliminaUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminaUser.FlatAppearance.BorderSize = 0;
            this.btnEliminaUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminaUser.ForeColor = System.Drawing.Color.White;
            this.btnEliminaUser.Location = new System.Drawing.Point(3, 31);
            this.btnEliminaUser.Name = "btnEliminaUser";
            this.btnEliminaUser.Size = new System.Drawing.Size(194, 34);
            this.btnEliminaUser.TabIndex = 1;
            this.btnEliminaUser.Text = "Elimina";
            this.btnEliminaUser.TextColor = System.Drawing.Color.White;
            this.btnEliminaUser.UseVisualStyleBackColor = false;
            this.btnEliminaUser.Click += new System.EventHandler(this.btnEliminaUser_Click);
            // 
            // btnResetUSer
            // 
            this.btnResetUSer.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnResetUSer.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnResetUSer.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnResetUSer.BorderRadius = 0;
            this.btnResetUSer.BorderSize = 0;
            this.btnResetUSer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResetUSer.FlatAppearance.BorderSize = 0;
            this.btnResetUSer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetUSer.ForeColor = System.Drawing.Color.White;
            this.btnResetUSer.Location = new System.Drawing.Point(103, 3);
            this.btnResetUSer.Name = "btnResetUSer";
            this.btnResetUSer.Size = new System.Drawing.Size(94, 27);
            this.btnResetUSer.TabIndex = 13;
            this.btnResetUSer.Text = "Reset";
            this.btnResetUSer.TextColor = System.Drawing.Color.White;
            this.btnResetUSer.UseVisualStyleBackColor = false;
            this.btnResetUSer.Click += new System.EventHandler(this.btnResetUSer_Click);
            // 
            // btnFiltraUser
            // 
            this.btnFiltraUser.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnFiltraUser.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnFiltraUser.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnFiltraUser.BorderRadius = 0;
            this.btnFiltraUser.BorderSize = 0;
            this.btnFiltraUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFiltraUser.FlatAppearance.BorderSize = 0;
            this.btnFiltraUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltraUser.ForeColor = System.Drawing.Color.White;
            this.btnFiltraUser.Location = new System.Drawing.Point(3, 3);
            this.btnFiltraUser.Name = "btnFiltraUser";
            this.btnFiltraUser.Size = new System.Drawing.Size(94, 27);
            this.btnFiltraUser.TabIndex = 12;
            this.btnFiltraUser.Text = "Filtra";
            this.btnFiltraUser.TextColor = System.Drawing.Color.White;
            this.btnFiltraUser.UseVisualStyleBackColor = false;
            this.btnFiltraUser.Click += new System.EventHandler(this.btnFiltraUser_Click);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtNome.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNome.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNome.BorderSize = 2;
            this.txtNome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.DimGray;
            this.txtNome.Location = new System.Drawing.Point(3, 47);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.Padding = new System.Windows.Forms.Padding(7);
            this.txtNome.PasswordChar = false;
            this.txtNome.Size = new System.Drawing.Size(194, 35);
            this.txtNome.TabIndex = 8;
            this.txtNome.Texts = "";
            this.txtNome.UnderlinedStyle = false;
            // 
            // txtNewUser
            // 
            this.txtNewUser.BackColor = System.Drawing.SystemColors.Window;
            this.txtNewUser.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNewUser.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNewUser.BorderSize = 2;
            this.txtNewUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewUser.ForeColor = System.Drawing.Color.DimGray;
            this.txtNewUser.Location = new System.Drawing.Point(3, 29);
            this.txtNewUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewUser.Multiline = false;
            this.txtNewUser.Name = "txtNewUser";
            this.txtNewUser.Padding = new System.Windows.Forms.Padding(7);
            this.txtNewUser.PasswordChar = false;
            this.txtNewUser.Size = new System.Drawing.Size(194, 35);
            this.txtNewUser.TabIndex = 9;
            this.txtNewUser.Texts = "";
            this.txtNewUser.UnderlinedStyle = false;
            // 
            // btnNewUser
            // 
            this.btnNewUser.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnNewUser.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnNewUser.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNewUser.BorderRadius = 0;
            this.btnNewUser.BorderSize = 0;
            this.btnNewUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNewUser.FlatAppearance.BorderSize = 0;
            this.btnNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewUser.ForeColor = System.Drawing.Color.White;
            this.btnNewUser.Location = new System.Drawing.Point(3, 71);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(194, 32);
            this.btnNewUser.TabIndex = 1;
            this.btnNewUser.Text = "Nuovo";
            this.btnNewUser.TextColor = System.Drawing.Color.White;
            this.btnNewUser.UseVisualStyleBackColor = false;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // txtLoginCodice
            // 
            this.txtLoginCodice.BackColor = System.Drawing.SystemColors.Window;
            this.txtLoginCodice.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtLoginCodice.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtLoginCodice.BorderSize = 2;
            this.txtLoginCodice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLoginCodice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginCodice.ForeColor = System.Drawing.Color.DimGray;
            this.txtLoginCodice.Location = new System.Drawing.Point(484, 224);
            this.txtLoginCodice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLoginCodice.Multiline = false;
            this.txtLoginCodice.Name = "txtLoginCodice";
            this.txtLoginCodice.Padding = new System.Windows.Forms.Padding(7);
            this.txtLoginCodice.PasswordChar = false;
            this.txtLoginCodice.Size = new System.Drawing.Size(194, 35);
            this.txtLoginCodice.TabIndex = 0;
            this.txtLoginCodice.Texts = "";
            this.txtLoginCodice.UnderlinedStyle = false;
            // 
            // btnEntraUser
            // 
            this.btnEntraUser.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEntraUser.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEntraUser.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEntraUser.BorderRadius = 0;
            this.btnEntraUser.BorderSize = 0;
            this.btnEntraUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEntraUser.FlatAppearance.BorderSize = 0;
            this.btnEntraUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntraUser.ForeColor = System.Drawing.Color.White;
            this.btnEntraUser.Location = new System.Drawing.Point(484, 273);
            this.btnEntraUser.Name = "btnEntraUser";
            this.btnEntraUser.Size = new System.Drawing.Size(194, 40);
            this.btnEntraUser.TabIndex = 2;
            this.btnEntraUser.Text = "Entra";
            this.btnEntraUser.TextColor = System.Drawing.Color.White;
            this.btnEntraUser.UseVisualStyleBackColor = false;
            this.btnEntraUser.Click += new System.EventHandler(this.btnEntraUser_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 560);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibri)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtenti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvLibri;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private components.LoginCustomTextBox txtLoginCodice;
        private System.Windows.Forms.Label label1;
        private CustomButton btnEntraUser;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private CustomButton btnFiltra;
        private CustomButton btnReset;
        private components.LoginCustomTextBox txtBookName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private CustomButton btnModifica;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private CustomButton btnElimina;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private components.LoginCustomTextBox txtNewIsbn;
        private CustomButton btnAdd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private CustomButton btnModificaUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private CustomButton btnEliminaUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private CustomButton btnResetUSer;
        private CustomButton btnFiltraUser;
        private components.LoginCustomTextBox txtNome;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel15;
        private components.LoginCustomTextBox txtNewUser;
        private CustomButton btnNewUser;
        private System.Windows.Forms.DataGridView dgvUtenti;
    }
}