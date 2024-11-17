namespace Sinema_Otomasyonu.UserControls
{
    partial class ActorListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActorListControl));
            pictureBox1 = new PictureBox();
            ID = new Label();
            edit = new PictureBox();
            bio = new TextBox();
            year = new Label();
            name = new Label();
            img = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)edit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(659, 87);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(22, 5);
            ID.Margin = new Padding(4, 0, 4, 0);
            ID.Name = "ID";
            ID.Size = new Size(0, 15);
            ID.TabIndex = 14;
            ID.Visible = false;
            // 
            // edit
            // 
            edit.BackColor = Color.WhiteSmoke;
            edit.Image = (Image)resources.GetObject("edit.Image");
            edit.Location = new Point(659, 21);
            edit.Margin = new Padding(4, 3, 4, 3);
            edit.Name = "edit";
            edit.Size = new Size(58, 58);
            edit.SizeMode = PictureBoxSizeMode.Zoom;
            edit.TabIndex = 13;
            edit.TabStop = false;
            edit.Click += edit_Click;
            // 
            // bio
            // 
            bio.BorderStyle = BorderStyle.FixedSingle;
            bio.Enabled = false;
            bio.Location = new Point(374, 29);
            bio.Margin = new Padding(4, 3, 4, 3);
            bio.Multiline = true;
            bio.Name = "bio";
            bio.Size = new Size(268, 115);
            bio.TabIndex = 12;
            // 
            // year
            // 
            year.AutoSize = true;
            year.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold);
            year.ForeColor = Color.FromArgb(0, 59, 111);
            year.Location = new Point(145, 91);
            year.Margin = new Padding(4, 0, 4, 0);
            year.Name = "year";
            year.Size = new Size(0, 25);
            year.TabIndex = 11;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name.ForeColor = Color.FromArgb(0, 59, 111);
            name.Location = new Point(145, 50);
            name.Margin = new Padding(4, 0, 4, 0);
            name.Name = "name";
            name.Size = new Size(0, 25);
            name.TabIndex = 10;
            // 
            // img
            // 
            img.Location = new Point(21, 29);
            img.Margin = new Padding(4, 3, 4, 3);
            img.Name = "img";
            img.Size = new Size(117, 115);
            img.SizeMode = PictureBoxSizeMode.Zoom;
            img.TabIndex = 9;
            img.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 59, 111);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(12, 164);
            panel1.TabIndex = 8;
            // 
            // ActorListControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(ID);
            Controls.Add(edit);
            Controls.Add(bio);
            Controls.Add(year);
            Controls.Add(name);
            Controls.Add(img);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ActorListControl";
            Size = new Size(719, 164);
            Load += ActorListControl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)edit).EndInit();
            ((System.ComponentModel.ISupportInitialize)img).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label ID;
        private System.Windows.Forms.PictureBox edit;
        public System.Windows.Forms.TextBox bio;
        public System.Windows.Forms.Label year;
        public System.Windows.Forms.Label name;
        public System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.Panel panel1;
    }
}
