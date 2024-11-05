namespace Sinema_Otomasyonu.UserControls
{
    partial class GenreList
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
            this.ID = new System.Windows.Forms.Label();
            this.genre_name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Dock = System.Windows.Forms.DockStyle.Right;
            this.ID.ForeColor = System.Drawing.SystemColors.Control;
            this.ID.Location = new System.Drawing.Point(228, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(0, 13);
            this.ID.TabIndex = 8;
            // 
            // genre_name
            // 
            this.genre_name.AutoSize = true;
            this.genre_name.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre_name.ForeColor = System.Drawing.Color.Black;
            this.genre_name.Location = new System.Drawing.Point(45, 8);
            this.genre_name.Name = "genre_name";
            this.genre_name.Size = new System.Drawing.Size(0, 20);
            this.genre_name.TabIndex = 7;
            this.genre_name.Click += new System.EventHandler(this.genre_name_Click);
            this.genre_name.MouseLeave += new System.EventHandler(this.genre_name_MouseLeave);
            this.genre_name.MouseMove += new System.Windows.Forms.MouseEventHandler(this.genre_name_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(111)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(39, 38);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "+";
            // 
            // GenreList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ID);
            this.Controls.Add(this.genre_name);
            this.Controls.Add(this.panel1);
            this.Name = "GenreList";
            this.Size = new System.Drawing.Size(228, 38);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label ID;
        public System.Windows.Forms.Label genre_name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
