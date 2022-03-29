
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnFiltra = new System.Windows.Forms.Button();
            this.cmbGenres = new System.Windows.Forms.ComboBox();
            this.txtBookName = new Biblioteca.components.LoginCustomTextBox();
            this.txtAutori = new Biblioteca.components.LoginCustomTextBox();
            this.dgvLibri = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvUtenti = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtLoginCodice = new Biblioteca.components.LoginCustomTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEntraUser = new Biblioteca.CustomButton();
            this.lblNome = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibri)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtenti)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 66);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 384);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 355);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 349);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.btnFiltra, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.cmbGenres, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.txtBookName, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtAutori, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(200, 349);
            this.tableLayoutPanel5.TabIndex = 17;
            // 
            // btnFiltra
            // 
            this.btnFiltra.Location = new System.Drawing.Point(3, 157);
            this.btnFiltra.Name = "btnFiltra";
            this.btnFiltra.Size = new System.Drawing.Size(75, 23);
            this.btnFiltra.TabIndex = 1;
            this.btnFiltra.Text = "Filtra";
            this.btnFiltra.UseVisualStyleBackColor = true;
            this.btnFiltra.Click += new System.EventHandler(this.btnFiltra_Click);
            // 
            // cmbGenres
            // 
            this.cmbGenres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbGenres.FormattingEnabled = true;
            this.cmbGenres.Location = new System.Drawing.Point(3, 234);
            this.cmbGenres.Name = "cmbGenres";
            this.cmbGenres.Size = new System.Drawing.Size(194, 24);
            this.cmbGenres.TabIndex = 3;
            // 
            // txtBookName
            // 
            this.txtBookName.BackColor = System.Drawing.SystemColors.Window;
            this.txtBookName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtBookName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtBookName.BorderSize = 2;
            this.txtBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookName.ForeColor = System.Drawing.Color.DimGray;
            this.txtBookName.Location = new System.Drawing.Point(3, 4);
            this.txtBookName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBookName.Multiline = false;
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Padding = new System.Windows.Forms.Padding(7);
            this.txtBookName.PasswordChar = false;
            this.txtBookName.Size = new System.Drawing.Size(194, 35);
            this.txtBookName.TabIndex = 4;
            this.txtBookName.Texts = "";
            this.txtBookName.UnderlinedStyle = false;
            // 
            // txtAutori
            // 
            this.txtAutori.BackColor = System.Drawing.SystemColors.Window;
            this.txtAutori.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtAutori.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtAutori.BorderSize = 2;
            this.txtAutori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutori.ForeColor = System.Drawing.Color.DimGray;
            this.txtAutori.Location = new System.Drawing.Point(3, 81);
            this.txtAutori.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAutori.Multiline = false;
            this.txtAutori.Name = "txtAutori";
            this.txtAutori.Padding = new System.Windows.Forms.Padding(7);
            this.txtAutori.PasswordChar = false;
            this.txtAutori.Size = new System.Drawing.Size(194, 35);
            this.txtAutori.TabIndex = 5;
            this.txtAutori.Texts = "";
            this.txtAutori.UnderlinedStyle = false;
            // 
            // dgvLibri
            // 
            this.dgvLibri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLibri.Location = new System.Drawing.Point(203, 3);
            this.dgvLibri.Name = "dgvLibri";
            this.dgvLibri.RowHeadersVisible = false;
            this.dgvLibri.RowHeadersWidth = 51;
            this.dgvLibri.RowTemplate.Height = 24;
            this.dgvLibri.Size = new System.Drawing.Size(580, 343);
            this.dgvLibri.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvUtenti);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 355);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvUtenti
            // 
            this.dgvUtenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUtenti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUtenti.Location = new System.Drawing.Point(3, 3);
            this.dgvUtenti.Name = "dgvUtenti";
            this.dgvUtenti.RowHeadersVisible = false;
            this.dgvUtenti.RowHeadersWidth = 51;
            this.dgvUtenti.RowTemplate.Height = 24;
            this.dgvUtenti.Size = new System.Drawing.Size(786, 349);
            this.dgvUtenti.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 355);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(792, 355);
            this.tableLayoutPanel2.TabIndex = 0;
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
            this.txtLoginCodice.Location = new System.Drawing.Point(299, 156);
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
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(296, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codice Fiscale";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnEntraUser.Location = new System.Drawing.Point(299, 205);
            this.btnEntraUser.Name = "btnEntraUser";
            this.btnEntraUser.Size = new System.Drawing.Size(194, 40);
            this.btnEntraUser.TabIndex = 2;
            this.btnEntraUser.Text = "Entra";
            this.btnEntraUser.TextColor = System.Drawing.Color.White;
            this.btnEntraUser.UseVisualStyleBackColor = false;
            this.btnEntraUser.Click += new System.EventHandler(this.btnEntraUser_Click);
            // 
            // lblNome
            // 
            this.lblNome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNome.Location = new System.Drawing.Point(0, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(800, 66);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "label2";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibri)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtenti)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvUtenti;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvLibri;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnFiltra;
        private System.Windows.Forms.ComboBox cmbGenres;
        private components.LoginCustomTextBox txtBookName;
        private components.LoginCustomTextBox txtAutori;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private components.LoginCustomTextBox txtLoginCodice;
        private System.Windows.Forms.Label label1;
        private CustomButton btnEntraUser;
        private System.Windows.Forms.Label lblNome;
    }
}