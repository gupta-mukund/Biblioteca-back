
namespace Biblioteca
{
    partial class frmRestituzione
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
            this.dgvPrestiti = new System.Windows.Forms.DataGridView();
            this.clmRestituisci = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestiti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrestiti
            // 
            this.dgvPrestiti.AllowUserToAddRows = false;
            this.dgvPrestiti.AllowUserToDeleteRows = false;
            this.dgvPrestiti.AllowUserToResizeColumns = false;
            this.dgvPrestiti.AllowUserToResizeRows = false;
            this.dgvPrestiti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrestiti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestiti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmRestituisci});
            this.dgvPrestiti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrestiti.Location = new System.Drawing.Point(0, 0);
            this.dgvPrestiti.Name = "dgvPrestiti";
            this.dgvPrestiti.ReadOnly = true;
            this.dgvPrestiti.RowHeadersVisible = false;
            this.dgvPrestiti.RowHeadersWidth = 51;
            this.dgvPrestiti.RowTemplate.Height = 24;
            this.dgvPrestiti.Size = new System.Drawing.Size(800, 450);
            this.dgvPrestiti.TabIndex = 2;
            this.dgvPrestiti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrestiti_CellContentClick);
            // 
            // clmRestituisci
            // 
            this.clmRestituisci.HeaderText = "Restituisci";
            this.clmRestituisci.MinimumWidth = 6;
            this.clmRestituisci.Name = "clmRestituisci";
            this.clmRestituisci.ReadOnly = true;
            // 
            // frmRestituzione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPrestiti);
            this.Name = "frmRestituzione";
            this.Text = "Restituzione";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestiti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrestiti;
        private System.Windows.Forms.DataGridViewButtonColumn clmRestituisci;
    }
}