
namespace Biblioteca.components
{
    partial class BookTextCell
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDescrizione = new System.Windows.Forms.Label();
            this.lblAnno = new System.Windows.Forms.Label();
            this.lblTitolo = new System.Windows.Forms.Label();
            this.lblAutore = new System.Windows.Forms.Label();
            this.lblGenere = new System.Windows.Forms.Label();
            this.btnPrenota = new Biblioteca.CustomButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pcbPicture = new System.Windows.Forms.PictureBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(703, 404);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lblRating, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblDescrizione, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblAnno, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblTitolo, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblAutore, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblGenere, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnPrenota, 0, 6);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(210, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(493, 404);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lblDescrizione
            // 
            this.lblDescrizione.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescrizione.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescrizione.Location = new System.Drawing.Point(0, 150);
            this.lblDescrizione.Margin = new System.Windows.Forms.Padding(0);
            this.lblDescrizione.Name = "lblDescrizione";
            this.lblDescrizione.Size = new System.Drawing.Size(493, 55);
            this.lblDescrizione.TabIndex = 15;
            this.lblDescrizione.Text = "label1";
            // 
            // lblAnno
            // 
            this.lblAnno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAnno.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnno.Location = new System.Drawing.Point(0, 125);
            this.lblAnno.Margin = new System.Windows.Forms.Padding(0);
            this.lblAnno.Name = "lblAnno";
            this.lblAnno.Size = new System.Drawing.Size(493, 25);
            this.lblAnno.TabIndex = 14;
            this.lblAnno.Text = "label1";
            this.lblAnno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitolo
            // 
            this.lblTitolo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitolo.Location = new System.Drawing.Point(0, 75);
            this.lblTitolo.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitolo.Name = "lblTitolo";
            this.lblTitolo.Size = new System.Drawing.Size(493, 50);
            this.lblTitolo.TabIndex = 13;
            this.lblTitolo.Text = "label1";
            this.lblTitolo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAutore
            // 
            this.lblAutore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAutore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutore.Location = new System.Drawing.Point(0, 35);
            this.lblAutore.Margin = new System.Windows.Forms.Padding(0);
            this.lblAutore.Name = "lblAutore";
            this.lblAutore.Size = new System.Drawing.Size(493, 40);
            this.lblAutore.TabIndex = 12;
            this.lblAutore.Text = "label1";
            this.lblAutore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGenere
            // 
            this.lblGenere.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGenere.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenere.Location = new System.Drawing.Point(0, 0);
            this.lblGenere.Margin = new System.Windows.Forms.Padding(0);
            this.lblGenere.Name = "lblGenere";
            this.lblGenere.Size = new System.Drawing.Size(493, 35);
            this.lblGenere.TabIndex = 10;
            this.lblGenere.Text = "label1";
            this.lblGenere.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnPrenota.Location = new System.Drawing.Point(3, 233);
            this.btnPrenota.Name = "btnPrenota";
            this.btnPrenota.Size = new System.Drawing.Size(150, 40);
            this.btnPrenota.TabIndex = 16;
            this.btnPrenota.Text = "Prenota";
            this.btnPrenota.TextColor = System.Drawing.Color.White;
            this.btnPrenota.UseVisualStyleBackColor = false;
            this.btnPrenota.Click += new System.EventHandler(this.btnPrenota_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.pcbPicture, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(210, 404);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // pcbPicture
            // 
            this.pcbPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbPicture.Location = new System.Drawing.Point(0, 0);
            this.pcbPicture.Margin = new System.Windows.Forms.Padding(0);
            this.pcbPicture.Name = "pcbPicture";
            this.pcbPicture.Size = new System.Drawing.Size(210, 250);
            this.pcbPicture.TabIndex = 0;
            this.pcbPicture.TabStop = false;
            // 
            // lblRating
            // 
            this.lblRating.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.Location = new System.Drawing.Point(0, 205);
            this.lblRating.Margin = new System.Windows.Forms.Padding(0);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(493, 25);
            this.lblRating.TabIndex = 17;
            this.lblRating.Text = "label1";
            this.lblRating.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BookTextCell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "BookTextCell";
            this.Size = new System.Drawing.Size(703, 404);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pcbPicture;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.Label lblGenere;
        public System.Windows.Forms.Label lblAutore;
        public System.Windows.Forms.Label lblTitolo;
        public System.Windows.Forms.Label lblAnno;
        public System.Windows.Forms.Label lblDescrizione;
        private CustomButton btnPrenota;
        public System.Windows.Forms.Label lblRating;
    }
}
