namespace Sinema_Otomasyonu.UserControls
{
    partial class DirectorListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectorListControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.img = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.bio = new System.Windows.Forms.TextBox();
            this.edit = new System.Windows.Forms.PictureBox();
            this.ID = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(111)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 142);
            this.panel1.TabIndex = 0;
            // 
            // img
            // 
            this.img.Location = new System.Drawing.Point(16, 25);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(100, 100);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img.TabIndex = 1;
            this.img.TabStop = false;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(111)))));
            this.name.Location = new System.Drawing.Point(122, 43);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(0, 25);
            this.name.TabIndex = 2;
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold);
            this.year.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(111)))));
            this.year.Location = new System.Drawing.Point(122, 79);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(0, 25);
            this.year.TabIndex = 3;
            // 
            // bio
            // 
            this.bio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bio.Enabled = false;
            this.bio.Location = new System.Drawing.Point(319, 25);
            this.bio.Multiline = true;
            this.bio.Name = "bio";
            this.bio.Size = new System.Drawing.Size(230, 100);
            this.bio.TabIndex = 4;
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.edit.Image = ((System.Drawing.Image)(resources.GetObject("edit.Image")));
            this.edit.Location = new System.Drawing.Point(563, 18);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(50, 50);
            this.edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.edit.TabIndex = 5;
            this.edit.TabStop = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(17, 4);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(0, 13);
            this.ID.TabIndex = 6;
            this.ID.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(563, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DirectorListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.bio);
            this.Controls.Add(this.year);
            this.Controls.Add(this.name);
            this.Controls.Add(this.img);
            this.Controls.Add(this.panel1);
            this.Name = "DirectorListControl";
            this.Size = new System.Drawing.Size(616, 142);
            this.Load += new System.EventHandler(this.DirectorList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox img;
        public System.Windows.Forms.Label name;
        public System.Windows.Forms.Label year;
        public System.Windows.Forms.TextBox bio;
        private System.Windows.Forms.PictureBox edit;
        public System.Windows.Forms.Label ID;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
