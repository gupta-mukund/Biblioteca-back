
namespace Biblioteca.components
{
    partial class Rating
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
            this.btn1 = new FontAwesome.Sharp.IconPictureBox();
            this.btn4 = new FontAwesome.Sharp.IconPictureBox();
            this.btn5 = new FontAwesome.Sharp.IconPictureBox();
            this.btn3 = new FontAwesome.Sharp.IconPictureBox();
            this.btn2 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.Control;
            this.btn1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn1.IconChar = FontAwesome.Sharp.IconChar.NetworkWired;
            this.btn1.IconColor = System.Drawing.SystemColors.ControlText;
            this.btn1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn1.Location = new System.Drawing.Point(21, 21);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(32, 32);
            this.btn1.TabIndex = 0;
            this.btn1.TabStop = false;
            this.btn1.Tag = "1";
            this.btn1.Click += new System.EventHandler(this.StarClick);
            this.btn1.MouseLeave += new System.EventHandler(this.StarOut);
            this.btn1.MouseHover += new System.EventHandler(this.StarHover);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.Control;
            this.btn4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn4.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn4.IconColor = System.Drawing.SystemColors.ControlText;
            this.btn4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn4.Location = new System.Drawing.Point(135, 21);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(32, 32);
            this.btn4.TabIndex = 1;
            this.btn4.TabStop = false;
            this.btn4.Tag = "4";
            this.btn4.Click += new System.EventHandler(this.StarClick);
            this.btn4.MouseLeave += new System.EventHandler(this.StarOut);
            this.btn4.MouseHover += new System.EventHandler(this.StarHover);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.Control;
            this.btn5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn5.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn5.IconColor = System.Drawing.SystemColors.ControlText;
            this.btn5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn5.Location = new System.Drawing.Point(173, 21);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(32, 32);
            this.btn5.TabIndex = 2;
            this.btn5.TabStop = false;
            this.btn5.Tag = "5";
            this.btn5.Click += new System.EventHandler(this.StarClick);
            this.btn5.MouseLeave += new System.EventHandler(this.StarOut);
            this.btn5.MouseHover += new System.EventHandler(this.StarHover);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.Control;
            this.btn3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn3.IconColor = System.Drawing.SystemColors.ControlText;
            this.btn3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn3.Location = new System.Drawing.Point(97, 21);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(32, 32);
            this.btn3.TabIndex = 3;
            this.btn3.TabStop = false;
            this.btn3.Tag = "3";
            this.btn3.Click += new System.EventHandler(this.StarClick);
            this.btn3.MouseLeave += new System.EventHandler(this.StarOut);
            this.btn3.MouseHover += new System.EventHandler(this.StarHover);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.Control;
            this.btn2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn2.IconColor = System.Drawing.SystemColors.ControlText;
            this.btn2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn2.Location = new System.Drawing.Point(59, 21);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(32, 32);
            this.btn2.TabIndex = 4;
            this.btn2.TabStop = false;
            this.btn2.Tag = "2";
            this.btn2.Click += new System.EventHandler(this.StarClick);
            this.btn2.MouseLeave += new System.EventHandler(this.StarOut);
            this.btn2.MouseHover += new System.EventHandler(this.StarHover);
            // 
            // Rating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn1);
            this.Name = "Rating";
            this.Size = new System.Drawing.Size(274, 145);
            ((System.ComponentModel.ISupportInitialize)(this.btn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox btn1;
        private FontAwesome.Sharp.IconPictureBox btn4;
        private FontAwesome.Sharp.IconPictureBox btn5;
        private FontAwesome.Sharp.IconPictureBox btn3;
        private FontAwesome.Sharp.IconPictureBox btn2;
    }
}
