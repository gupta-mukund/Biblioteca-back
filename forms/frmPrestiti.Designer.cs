
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStorico = new System.Windows.Forms.DataGridView();
            this.tbcPrenotazioni.SuspendLayout();
            this.tbpInCorso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestiti)).BeginInit();
            this.tbpPrenotazioni.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorico)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcPrenotazioni
            // 
            this.tbcPrenotazioni.Controls.Add(this.tbpInCorso);
            this.tbcPrenotazioni.Controls.Add(this.tbpPrenotazioni);
            this.tbcPrenotazioni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcPrenotazioni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.tbpPrenotazioni.Controls.Add(this.tableLayoutPanel1);
            this.tbpPrenotazioni.Location = new System.Drawing.Point(4, 29);
            this.tbpPrenotazioni.Name = "tbpPrenotazioni";
            this.tbpPrenotazioni.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPrenotazioni.Size = new System.Drawing.Size(792, 417);
            this.tbpPrenotazioni.TabIndex = 1;
            this.tbpPrenotazioni.Text = "Elenco";
            this.tbpPrenotazioni.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvStorico, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 411);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(786, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Storico Prestiti";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvStorico
            // 
            this.dgvStorico.AllowUserToAddRows = false;
            this.dgvStorico.AllowUserToDeleteRows = false;
            this.dgvStorico.AllowUserToResizeColumns = false;
            this.dgvStorico.AllowUserToResizeRows = false;
            this.dgvStorico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStorico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStorico.Location = new System.Drawing.Point(0, 50);
            this.dgvStorico.Margin = new System.Windows.Forms.Padding(0);
            this.dgvStorico.Name = "dgvStorico";
            this.dgvStorico.RowHeadersVisible = false;
            this.dgvStorico.RowHeadersWidth = 51;
            this.dgvStorico.RowTemplate.Height = 24;
            this.dgvStorico.Size = new System.Drawing.Size(786, 361);
            this.dgvStorico.TabIndex = 1;
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
            this.tbpPrenotazioni.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcPrenotazioni;
        private System.Windows.Forms.TabPage tbpInCorso;
        private System.Windows.Forms.TabPage tbpPrenotazioni;
        private System.Windows.Forms.DataGridView dgvPrestiti;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvStorico;
    }
}