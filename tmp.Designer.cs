namespace Biblioteca
{
    partial class tmp
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDescrizione = new System.Windows.Forms.Label();
            this.lblAnno = new System.Windows.Forms.Label();
            this.lblTitolo = new System.Windows.Forms.Label();
            this.lblAutore = new System.Windows.Forms.Label();
            this.lblGenere = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRight = new FontAwesome.Sharp.IconButton();
            this.btnLeft = new FontAwesome.Sharp.IconButton();
            this.lblPages = new System.Windows.Forms.Label();
            this.btnPrenota = new Biblioteca.CustomButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Location = new System.Drawing.Point(22, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(62, 68);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(50, 39);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 22);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(53, 10);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 22);
            this.txtUsername.TabIndex = 0;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.ColumnHeadersVisible = false;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgv.Location = new System.Drawing.Point(248, 12);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(63, 62);
            this.dgv.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(359, 102);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(340, 302);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // lblDescrizione
            // 
            this.lblDescrizione.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescrizione.Location = new System.Drawing.Point(0, 0);
            this.lblDescrizione.Margin = new System.Windows.Forms.Padding(0);
            this.lblDescrizione.Name = "lblDescrizione";
            this.lblDescrizione.Size = new System.Drawing.Size(804, 450);
            this.lblDescrizione.TabIndex = 9;
            this.lblDescrizione.Text = "label1";
            this.lblDescrizione.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAnno
            // 
            this.lblAnno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAnno.Location = new System.Drawing.Point(0, 0);
            this.lblAnno.Margin = new System.Windows.Forms.Padding(0);
            this.lblAnno.Name = "lblAnno";
            this.lblAnno.Size = new System.Drawing.Size(804, 450);
            this.lblAnno.TabIndex = 8;
            this.lblAnno.Text = "label1";
            this.lblAnno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitolo
            // 
            this.lblTitolo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitolo.Location = new System.Drawing.Point(0, 0);
            this.lblTitolo.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(804, 450);
            this.lblTitolo.TabIndex = 7;
            this.lblTitolo.Text = "label1";
            this.lblTitolo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAutore
            // 
            this.lblAutore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAutore.Location = new System.Drawing.Point(0, 0);
            this.lblAutore.Margin = new System.Windows.Forms.Padding(0);
            this.lblAutore.Name = "lblAutore";
            this.lblAutore.Size = new System.Drawing.Size(804, 450);
            this.lblAutore.TabIndex = 6;
            this.lblAutore.Text = "label1";
            this.lblAutore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGenere
            // 
            this.lblGenere.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGenere.Location = new System.Drawing.Point(0, 0);
            this.lblGenere.Margin = new System.Windows.Forms.Padding(0);
            this.lblGenere.Name = "lblGenere";
            this.lblGenere.Size = new System.Drawing.Size(804, 450);
            this.lblGenere.TabIndex = 5;
            this.lblGenere.Text = "label1";
            this.lblGenere.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRight, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLeft, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPages, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(804, 450);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // btnRight
            // 
            this.btnRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRight.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRight.IconColor = System.Drawing.Color.Black;
            this.btnRight.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRight.Location = new System.Drawing.Point(369, 5);
            this.btnRight.Margin = new System.Windows.Forms.Padding(0);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(70, 440);
            this.btnRight.TabIndex = 2;
            this.btnRight.UseVisualStyleBackColor = true;
            // 
            // btnLeft
            // 
            this.btnLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLeft.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLeft.IconColor = System.Drawing.Color.Black;
            this.btnLeft.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLeft.Location = new System.Drawing.Point(299, 5);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(0);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(70, 440);
            this.btnLeft.TabIndex = 0;
            this.btnLeft.UseVisualStyleBackColor = true;
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPages.Location = new System.Drawing.Point(442, 425);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(59, 20);
            this.lblPages.TabIndex = 3;
            this.lblPages.Text = "label1";
            // 
            // btnPrenota
            // 
            this.btnPrenota.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPrenota.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPrenota.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPrenota.BorderRadius = 0;
            this.btnPrenota.BorderSize = 0;
            this.btnPrenota.FlatAppearance.BorderSize = 0;
            this.btnPrenota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrenota.ForeColor = System.Drawing.Color.White;
            this.btnPrenota.Location = new System.Drawing.Point(350, 210);
            this.btnPrenota.Name = "btnPrenota";
            this.btnPrenota.Size = new System.Drawing.Size(100, 30);
            this.btnPrenota.TabIndex = 10;
            this.btnPrenota.Text = "Prenota";
            this.btnPrenota.TextColor = System.Drawing.Color.White;
            this.btnPrenota.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(7, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 400);
            this.panel2.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(292, 0);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnPrenota);
            this.Controls.Add(this.lblDescrizione);
            this.Controls.Add(this.lblAnno);
            this.Controls.Add(this.lblTitolo);
            this.Controls.Add(this.lblAutore);
            this.Controls.Add(this.lblGenere);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.panel1);
            this.Name = "tmp";
            this.Text = "tmp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.Label lblDescrizione;
        public System.Windows.Forms.Label lblAnno;
        public System.Windows.Forms.Label lblTitolo;
        public System.Windows.Forms.Label lblAutore;
        public System.Windows.Forms.Label lblGenere;
        private CustomButton btnPrenota;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton btnRight;
        private FontAwesome.Sharp.IconButton btnLeft;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}