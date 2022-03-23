
namespace Biblioteca.forms
{
    partial class frmBooks
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRight = new FontAwesome.Sharp.IconButton();
            this.btnLeft = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPages = new System.Windows.Forms.Label();
            this.txtCurrentPages = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnFiltra = new System.Windows.Forms.Button();
            this.cmbGenres = new System.Windows.Forms.ComboBox();
            this.txtBookName = new Biblioteca.components.LoginCustomTextBox();
            this.txtAutori = new Biblioteca.components.LoginCustomTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(300, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(500, 450);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.tlpMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 350);
            this.panel1.TabIndex = 15;
            // 
            // tlpMain
            // 
            this.tlpMain.AutoSize = true;
            this.tlpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Size = new System.Drawing.Size(500, 0);
            this.tlpMain.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.Controls.Add(this.btnRight, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnLeft, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 350);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(500, 100);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // btnRight
            // 
            this.btnRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRight.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRight.IconColor = System.Drawing.Color.Black;
            this.btnRight.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRight.Location = new System.Drawing.Point(215, 20);
            this.btnRight.Margin = new System.Windows.Forms.Padding(0);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(70, 60);
            this.btnRight.TabIndex = 2;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLeft.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLeft.IconColor = System.Drawing.Color.Black;
            this.btnLeft.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLeft.Location = new System.Drawing.Point(145, 20);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(0);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(70, 60);
            this.btnLeft.TabIndex = 0;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.lblPages, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtCurrentPages, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(285, 5);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(69, 90);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPages.Location = new System.Drawing.Point(34, 45);
            this.lblPages.Margin = new System.Windows.Forms.Padding(0);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(35, 45);
            this.lblPages.TabIndex = 1;
            this.lblPages.Text = "label1";
            // 
            // txtCurrentPages
            // 
            this.txtCurrentPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCurrentPages.Location = new System.Drawing.Point(0, 45);
            this.txtCurrentPages.Margin = new System.Windows.Forms.Padding(0);
            this.txtCurrentPages.Name = "txtCurrentPages";
            this.txtCurrentPages.Size = new System.Drawing.Size(34, 22);
            this.txtCurrentPages.TabIndex = 2;
            this.txtCurrentPages.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCurrentPages_KeyDown);
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
            this.tableLayoutPanel5.Size = new System.Drawing.Size(300, 450);
            this.tableLayoutPanel5.TabIndex = 16;
            // 
            // btnFiltra
            // 
            this.btnFiltra.Location = new System.Drawing.Point(3, 201);
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
            this.cmbGenres.Location = new System.Drawing.Point(3, 300);
            this.cmbGenres.Name = "cmbGenres";
            this.cmbGenres.Size = new System.Drawing.Size(294, 24);
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
            this.txtBookName.Size = new System.Drawing.Size(250, 35);
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
            this.txtAutori.Location = new System.Drawing.Point(3, 103);
            this.txtAutori.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAutori.Multiline = false;
            this.txtAutori.Name = "txtAutori";
            this.txtAutori.Padding = new System.Windows.Forms.Padding(7);
            this.txtAutori.PasswordChar = false;
            this.txtAutori.Size = new System.Drawing.Size(250, 35);
            this.txtAutori.TabIndex = 5;
            this.txtAutori.Texts = "";
            this.txtAutori.UnderlinedStyle = false;
            // 
            // frmBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmBooks";
            this.Tag = "UserBooks";
            this.Text = "frmBooks";
            this.Load += new System.EventHandler(this.frmBooks_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private FontAwesome.Sharp.IconButton btnRight;
        private FontAwesome.Sharp.IconButton btnLeft;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.TextBox txtCurrentPages;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.ComboBox cmbGenres;
        private components.LoginCustomTextBox txtBookName;
        private components.LoginCustomTextBox txtAutori;
        private System.Windows.Forms.Button btnFiltra;
    }
}