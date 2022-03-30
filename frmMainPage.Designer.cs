
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
            this.btnCarta = new FontAwesome.Sharp.IconButton();
            this.btnRecensioni = new FontAwesome.Sharp.IconButton();
            this.btnPrestiti = new FontAwesome.Sharp.IconButton();
            this.btnBooks = new FontAwesome.Sharp.IconButton();
            this.pnlProfileInfo = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCodiceFiscale = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pcbProfile = new System.Windows.Forms.PictureBox();
            this.pnlMainTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlCentralPage = new System.Windows.Forms.Panel();
            this.btnLogOut = new FontAwesome.Sharp.IconButton();
            this.pnlMain.SuspendLayout();
            this.pnlProfileInfo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProfile)).BeginInit();
            this.pnlMainTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlMain.Controls.Add(this.btnLogOut);
            this.pnlMain.Controls.Add(this.btnCarta);
            this.pnlMain.Controls.Add(this.btnRecensioni);
            this.pnlMain.Controls.Add(this.btnPrestiti);
            this.pnlMain.Controls.Add(this.btnBooks);
            this.pnlMain.Controls.Add(this.pnlProfileInfo);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(300, 412);
            this.pnlMain.TabIndex = 0;
            // 
            // btnCarta
            // 
            this.btnCarta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCarta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarta.ForeColor = System.Drawing.Color.White;
            this.btnCarta.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.btnCarta.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCarta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCarta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarta.Location = new System.Drawing.Point(0, 300);
            this.btnCarta.Name = "btnCarta";
            this.btnCarta.Size = new System.Drawing.Size(300, 50);
            this.btnCarta.TabIndex = 5;
            this.btnCarta.Tag = "Carta";
            this.btnCarta.Text = "Cartà fedelta";
            this.btnCarta.UseVisualStyleBackColor = true;
            this.btnCarta.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btnRecensioni
            // 
            this.btnRecensioni.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecensioni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecensioni.ForeColor = System.Drawing.Color.White;
            this.btnRecensioni.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.btnRecensioni.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRecensioni.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRecensioni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecensioni.Location = new System.Drawing.Point(0, 250);
            this.btnRecensioni.Name = "btnRecensioni";
            this.btnRecensioni.Size = new System.Drawing.Size(300, 50);
            this.btnRecensioni.TabIndex = 4;
            this.btnRecensioni.Tag = "Recensioni";
            this.btnRecensioni.Text = "Recensioni";
            this.btnRecensioni.UseVisualStyleBackColor = true;
            this.btnRecensioni.Click += new System.EventHandler(this.ButtonClick);
            // 
            // btnPrestiti
            // 
            this.btnPrestiti.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrestiti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrestiti.ForeColor = System.Drawing.Color.White;
            this.btnPrestiti.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnPrestiti.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrestiti.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrestiti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrestiti.Location = new System.Drawing.Point(0, 200);
            this.btnPrestiti.Name = "btnPrestiti";
            this.btnPrestiti.Size = new System.Drawing.Size(300, 50);
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
            this.btnBooks.ForeColor = System.Drawing.Color.White;
            this.btnBooks.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnBooks.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBooks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBooks.Location = new System.Drawing.Point(0, 150);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(300, 50);
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
            this.pnlProfileInfo.Size = new System.Drawing.Size(300, 150);
            this.pnlProfileInfo.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblCodiceFiscale, 0, 3);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 150);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblCodiceFiscale
            // 
            this.lblCodiceFiscale.AutoSize = true;
            this.lblCodiceFiscale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCodiceFiscale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodiceFiscale.Location = new System.Drawing.Point(0, 107);
            this.lblCodiceFiscale.Margin = new System.Windows.Forms.Padding(0);
            this.lblCodiceFiscale.Name = "lblCodiceFiscale";
            this.lblCodiceFiscale.Size = new System.Drawing.Size(300, 27);
            this.lblCodiceFiscale.TabIndex = 4;
            this.lblCodiceFiscale.Text = "label1";
            this.lblCodiceFiscale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.pcbProfile, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 10);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(300, 90);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // pcbProfile
            // 
            this.pcbProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbProfile.Image = global::Biblioteca.Properties.Resources.user;
            this.pcbProfile.Location = new System.Drawing.Point(75, 0);
            this.pcbProfile.Margin = new System.Windows.Forms.Padding(0);
            this.pcbProfile.Name = "pcbProfile";
            this.pcbProfile.Size = new System.Drawing.Size(150, 90);
            this.pcbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbProfile.TabIndex = 0;
            this.pcbProfile.TabStop = false;
            // 
            // pnlMainTitle
            // 
            this.pnlMainTitle.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnlMainTitle.Controls.Add(this.lblTitle);
            this.pnlMainTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainTitle.Location = new System.Drawing.Point(300, 0);
            this.pnlMainTitle.Name = "pnlMainTitle";
            this.pnlMainTitle.Size = new System.Drawing.Size(501, 150);
            this.pnlMainTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(501, 150);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "MANCHESTER PUBLIC LIBRARY";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCentralPage
            // 
            this.pnlCentralPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentralPage.Location = new System.Drawing.Point(300, 150);
            this.pnlCentralPage.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCentralPage.Name = "pnlCentralPage";
            this.pnlCentralPage.Size = new System.Drawing.Size(501, 262);
            this.pnlCentralPage.TabIndex = 2;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.IconChar = FontAwesome.Sharp.IconChar.Earlybirds;
            this.btnLogOut.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(0, 362);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(300, 50);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Tag = "";
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.pcbProfile)).EndInit();
            this.pnlMainTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private FontAwesome.Sharp.IconButton btnBooks;
        private System.Windows.Forms.Panel pnlProfileInfo;
        private FontAwesome.Sharp.IconButton btnRecensioni;
        private FontAwesome.Sharp.IconButton btnPrestiti;
        private System.Windows.Forms.Panel pnlMainTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblCodiceFiscale;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblTitle;
        private FontAwesome.Sharp.IconButton btnCarta;
        private System.Windows.Forms.PictureBox pcbProfile;
        private System.Windows.Forms.Panel pnlCentralPage;
        private FontAwesome.Sharp.IconButton btnLogOut;
    }
}