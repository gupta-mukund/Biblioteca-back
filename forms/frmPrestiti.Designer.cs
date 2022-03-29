
namespace Biblioteca.forms
{
    partial class frmPrestiti
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
            this.tbcPrenotazioni = new System.Windows.Forms.TabControl();
            this.tbpInCorso = new System.Windows.Forms.TabPage();
            this.dgvPrestiti = new System.Windows.Forms.DataGridView();
            this.tbpPrenotazioni = new System.Windows.Forms.TabPage();
            this.tbcPrenotazioni.SuspendLayout();
            this.tbpInCorso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestiti)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcPrenotazioni
            // 
            this.tbcPrenotazioni.Controls.Add(this.tbpInCorso);
            this.tbcPrenotazioni.Controls.Add(this.tbpPrenotazioni);
            this.tbcPrenotazioni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcPrenotazioni.Location = new System.Drawing.Point(0, 0);
            this.tbcPrenotazioni.Name = "tbcPrenotazioni";
            this.tbcPrenotazioni.SelectedIndex = 0;
            this.tbcPrenotazioni.Size = new System.Drawing.Size(800, 450);
            this.tbcPrenotazioni.TabIndex = 0;
            // 
            // tbpInCorso
            // 
            this.tbpInCorso.Controls.Add(this.dgvPrestiti);
            this.tbpInCorso.Location = new System.Drawing.Point(4, 25);
            this.tbpInCorso.Name = "tbpInCorso";
            this.tbpInCorso.Padding = new System.Windows.Forms.Padding(3);
            this.tbpInCorso.Size = new System.Drawing.Size(792, 421);
            this.tbpInCorso.TabIndex = 0;
            this.tbpInCorso.Text = "In Corso";
            this.tbpInCorso.UseVisualStyleBackColor = true;
            // 
            // dgvPrestiti
            // 
            this.dgvPrestiti.AllowUserToAddRows = false;
            this.dgvPrestiti.AllowUserToDeleteRows = false;
            this.dgvPrestiti.AllowUserToResizeColumns = false;
            this.dgvPrestiti.AllowUserToResizeRows = false;
            this.dgvPrestiti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrestiti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestiti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrestiti.Location = new System.Drawing.Point(3, 3);
            this.dgvPrestiti.Name = "dgvPrestiti";
            this.dgvPrestiti.RowHeadersVisible = false;
            this.dgvPrestiti.RowHeadersWidth = 51;
            this.dgvPrestiti.RowTemplate.Height = 24;
            this.dgvPrestiti.Size = new System.Drawing.Size(786, 415);
            this.dgvPrestiti.TabIndex = 1;
            // 
            // tbpPrenotazioni
            // 
            this.tbpPrenotazioni.Location = new System.Drawing.Point(4, 25);
            this.tbpPrenotazioni.Name = "tbpPrenotazioni";
            this.tbpPrenotazioni.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPrenotazioni.Size = new System.Drawing.Size(792, 421);
            this.tbpPrenotazioni.TabIndex = 1;
            this.tbpPrenotazioni.Text = "Prenotazioni";
            this.tbpPrenotazioni.UseVisualStyleBackColor = true;
            // 
            // frmPrestiti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbcPrenotazioni);
            this.Name = "frmPrestiti";
            this.Tag = "UserPrestiti";
            this.Text = "frmPrestiti";
            this.tbcPrenotazioni.ResumeLayout(false);
            this.tbpInCorso.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestiti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcPrenotazioni;
        private System.Windows.Forms.TabPage tbpInCorso;
        private System.Windows.Forms.TabPage tbpPrenotazioni;
        private System.Windows.Forms.DataGridView dgvPrestiti;
    }
}