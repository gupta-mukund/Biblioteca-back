
namespace Biblioteca
{
    partial class frmMainPage
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnRecensioni = new FontAwesome.Sharp.IconButton();
            this.btnScaffale = new FontAwesome.Sharp.IconButton();
            this.btnPrestiti = new FontAwesome.Sharp.IconButton();
            this.btnBooks = new FontAwesome.Sharp.IconButton();
            this.pnlProfileInfo = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNome = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pbxProfilePic = new FontAwesome.Sharp.IconPictureBox();
            this.pnlMainTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlCentralPage = new System.Windows.Forms.Panel();
            this.pnlMain.SuspendLayout();
            this.pnlProfileInfo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProfilePic)).BeginInit();
            this.pnlMainTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlMain.Controls.Add(this.btnRecensioni);
            this.pnlMain.Controls.Add(this.btnScaffale);
            this.pnlMain.Controls.Add(this.btnPrestiti);
            this.pnlMain.Controls.Add(this.btnBooks);
            this.pnlMain.Controls.Add(this.pnlProfileInfo);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(200, 412);
            this.pnlMain.TabIndex = 0;
            // 
            // btnRecensioni
            // 
            this.btnRecensioni.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecensioni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecensioni.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRecensioni.IconColor = System.Drawing.Color.Black;
            this.btnRecensioni.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRecensioni.Location = new System.Drawing.Point(0, 300);
            this.btnRecensioni.Name = "btnRecensioni";
            this.btnRecensioni.Size = new System.Drawing.Size(200, 50);
            this.btnRecensioni.TabIndex = 4;
            this.btnRecensioni.Text = "Recensioni";
            this.btnRecensioni.UseVisualStyleBackColor = true;
            this.btnRecensioni.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btnScaffale
            // 
            this.btnScaffale.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnScaffale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScaffale.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnScaffale.IconColor = System.Drawing.Color.Black;
            this.btnScaffale.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnScaffale.Location = new System.Drawing.Point(0, 250);
            this.btnScaffale.Name = "btnScaffale";
            this.btnScaffale.Size = new System.Drawing.Size(200, 50);
            this.btnScaffale.TabIndex = 3;
            this.btnScaffale.Text = "Scaffale";
            this.btnScaffale.UseVisualStyleBackColor = true;
            this.btnScaffale.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btnPrestiti
            // 
            this.btnPrestiti.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrestiti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrestiti.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnPrestiti.IconColor = System.Drawing.Color.Black;
            this.btnPrestiti.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrestiti.Location = new System.Drawing.Point(0, 200);
            this.btnPrestiti.Name = "btnPrestiti";
            this.btnPrestiti.Size = new System.Drawing.Size(200, 50);
            this.btnPrestiti.TabIndex = 2;
            this.btnPrestiti.Tag = "UserPrestiti";
            this.btnPrestiti.Text = "Prenotazioni";
            this.btnPrestiti.UseVisualStyleBackColor = true;
            this.btnPrestiti.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btnBooks
            // 
            this.btnBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooks.IconChar = FontAwesome.Sharp.IconChar.Neuter;
            this.btnBooks.IconColor = System.Drawing.Color.Black;
            this.btnBooks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBooks.Location = new System.Drawing.Point(0, 150);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(200, 50);
            this.btnBooks.TabIndex = 1;
            this.btnBooks.Tag = "UserBooks";
            this.btnBooks.Text = "Libri";
            this.btnBooks.UseVisualStyleBackColor = true;
            this.btnBooks.Click += new System.EventHandler(this.ButtonClick);
            // 
            // pnlProfileInfo
            // 
            this.pnlProfileInfo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlProfileInfo.Controls.Add(this.tableLayoutPanel1);
            this.pnlProfileInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProfileInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlProfileInfo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlProfileInfo.Name = "pnlProfileInfo";
            this.pnlProfileInfo.Size = new System.Drawing.Size(200, 150);
            this.pnlProfileInfo.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblNome, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 150);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(0, 107);
            this.lblNome.Margin = new System.Windows.Forms.Padding(0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(200, 27);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "label1";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.pbxProfilePic, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 10);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 90);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // pbxProfilePic
            // 
            this.pbxProfilePic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbxProfilePic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxProfilePic.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pbxProfilePic.IconChar = FontAwesome.Sharp.IconChar.None;
            this.pbxProfilePic.IconColor = System.Drawing.SystemColors.ControlText;
            this.pbxProfilePic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbxProfilePic.IconSize = 90;
            this.pbxProfilePic.Location = new System.Drawing.Point(50, 0);
            this.pbxProfilePic.Margin = new System.Windows.Forms.Padding(0);
            this.pbxProfilePic.Name = "pbxProfilePic";
            this.pbxProfilePic.Size = new System.Drawing.Size(100, 90);
            this.pbxProfilePic.TabIndex = 4;
            this.pbxProfilePic.TabStop = false;
            // 
            // pnlMainTitle
            // 
            this.pnlMainTitle.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnlMainTitle.Controls.Add(this.lblTitle);
            this.pnlMainTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainTitle.Location = new System.Drawing.Point(200, 0);
            this.pnlMainTitle.Name = "pnlMainTitle";
            this.pnlMainTitle.Size = new System.Drawing.Size(601, 100);
            this.pnlMainTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(601, 100);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "MANCHESTER PUBLIC LIBRARY";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCentralPage
            // 
            this.pnlCentralPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentralPage.Location = new System.Drawing.Point(200, 100);
            this.pnlCentralPage.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCentralPage.Name = "pnlCentralPage";
            this.pnlCentralPage.Size = new System.Drawing.Size(601, 312);
            this.pnlCentralPage.TabIndex = 2;
            // 
            // frmMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 412);
            this.Controls.Add(this.pnlCentralPage);
            this.Controls.Add(this.pnlMainTitle);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmMainPage";
            this.Text = "frmMainPage";
            this.pnlMain.ResumeLayout(false);
            this.pnlProfileInfo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxProfilePic)).EndInit();
            this.pnlMainTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private FontAwesome.Sharp.IconButton btnBooks;
        private System.Windows.Forms.Panel pnlProfileInfo;
        private FontAwesome.Sharp.IconButton btnRecensioni;
        private FontAwesome.Sharp.IconButton btnScaffale;
        private FontAwesome.Sharp.IconButton btnPrestiti;
        private System.Windows.Forms.Panel pnlMainTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private FontAwesome.Sharp.IconPictureBox pbxProfilePic;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlCentralPage;
    }
}