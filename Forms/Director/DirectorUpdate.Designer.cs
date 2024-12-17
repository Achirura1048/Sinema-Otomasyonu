namespace Sinema_Otomasyonu
{
    partial class DirectorUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectorUpdate));
            groupBox1 = new GroupBox();
            error_bio = new Label();
            error_surname = new Label();
            error_name = new Label();
            r_bio = new TextBox();
            label8 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            female = new RadioButton();
            male = new RadioButton();
            label7 = new Label();
            r_date = new DateTimePicker();
            label6 = new Label();
            r_surname = new TextBox();
            label3 = new Label();
            r_name = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            error_img = new Label();
            r_img = new PictureBox();
            img_up = new Button();
            r_save = new Button();
            label1 = new Label();
            panel1 = new Panel();
            ex_button = new Button();
            groupBox3 = new GroupBox();
            r_id = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)r_img).BeginInit();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(error_bio);
            groupBox1.Controls.Add(error_surname);
            groupBox1.Controls.Add(error_name);
            groupBox1.Controls.Add(r_bio);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(female);
            groupBox1.Controls.Add(male);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(r_date);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(r_surname);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(r_name);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.ForeColor = Color.FromArgb(0, 59, 111);
            groupBox1.Location = new Point(28, 22);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(791, 708);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // error_bio
            // 
            error_bio.AutoSize = true;
            error_bio.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Underline);
            error_bio.ForeColor = Color.Red;
            error_bio.Location = new Point(12, 651);
            error_bio.Margin = new Padding(4, 0, 4, 0);
            error_bio.Name = "error_bio";
            error_bio.Size = new Size(0, 19);
            error_bio.TabIndex = 24;
            // 
            // error_surname
            // 
            error_surname.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Underline);
            error_surname.ForeColor = Color.Red;
            error_surname.Location = new Point(399, 115);
            error_surname.Margin = new Padding(4, 0, 4, 0);
            error_surname.MaximumSize = new Size(260, 35);
            error_surname.Name = "error_surname";
            error_surname.Size = new Size(260, 35);
            error_surname.TabIndex = 23;
            // 
            // error_name
            // 
            error_name.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            error_name.ForeColor = Color.Red;
            error_name.ImageAlign = ContentAlignment.TopLeft;
            error_name.Location = new Point(96, 115);
            error_name.Margin = new Padding(4, 0, 4, 0);
            error_name.Name = "error_name";
            error_name.Size = new Size(243, 35);
            error_name.TabIndex = 22;
            // 
            // r_bio
            // 
            r_bio.Location = new Point(12, 355);
            r_bio.Margin = new Padding(4, 3, 4, 3);
            r_bio.Multiline = true;
            r_bio.Name = "r_bio";
            r_bio.Size = new Size(767, 287);
            r_bio.TabIndex = 21;
            r_bio.TextChanged += r_bio_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 321);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(93, 24);
            label8.TabIndex = 20;
            label8.Text = "Biyografi";
            label8.Click += label8_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(524, 203);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 83);
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(422, 203);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 83);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // female
            // 
            female.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            female.AutoSize = true;
            female.Location = new Point(500, 217);
            female.Margin = new Padding(4, 3, 4, 3);
            female.Name = "female";
            female.Size = new Size(14, 13);
            female.TabIndex = 17;
            female.UseVisualStyleBackColor = true;
            female.CheckedChanged += female_CheckedChanged;
            // 
            // male
            // 
            male.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            male.AutoSize = true;
            male.Checked = true;
            male.Location = new Point(399, 217);
            male.Margin = new Padding(4, 3, 4, 3);
            male.Name = "male";
            male.Size = new Size(14, 13);
            male.TabIndex = 16;
            male.TabStop = true;
            male.UseVisualStyleBackColor = true;
            male.CheckedChanged += male_CheckedChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(397, 172);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(86, 24);
            label7.TabIndex = 15;
            label7.Text = "Cinsiyet";
            label7.Click += label7_Click;
            // 
            // r_date
            // 
            r_date.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            r_date.CustomFormat = "dd-MM-yyyy";
            r_date.Format = DateTimePickerFormat.Short;
            r_date.Location = new Point(128, 203);
            r_date.Margin = new Padding(4, 3, 4, 3);
            r_date.Name = "r_date";
            r_date.Size = new Size(207, 32);
            r_date.TabIndex = 14;
            r_date.Value = new DateTime(2024, 10, 8, 0, 0, 0, 0);
            r_date.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(131, 172);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(131, 24);
            label6.TabIndex = 13;
            label6.Text = "Doğum Tarihi";
            label6.Click += label6_Click;
            // 
            // r_surname
            // 
            r_surname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            r_surname.Location = new Point(401, 65);
            r_surname.Margin = new Padding(4, 3, 4, 3);
            r_surname.Name = "r_surname";
            r_surname.Size = new Size(257, 32);
            r_surname.TabIndex = 7;
            r_surname.TextChanged += r_surname_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(397, 32);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 24);
            label3.TabIndex = 6;
            label3.Text = "Soyad";
            label3.Click += label3_Click;
            // 
            // r_name
            // 
            r_name.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            r_name.Location = new Point(100, 65);
            r_name.Margin = new Padding(4, 3, 4, 3);
            r_name.Name = "r_name";
            r_name.Size = new Size(237, 32);
            r_name.TabIndex = 5;
            r_name.TextChanged += r_name_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(96, 32);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(34, 24);
            label2.TabIndex = 4;
            label2.Text = "Ad";
            label2.Click += label2_Click;
            // 
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.Controls.Add(error_img);
            groupBox2.Controls.Add(r_img);
            groupBox2.Controls.Add(img_up);
            groupBox2.Font = new Font("Arial", 15.75F);
            groupBox2.Location = new Point(826, 22);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(415, 466);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // error_img
            // 
            error_img.AutoSize = true;
            error_img.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Underline);
            error_img.ForeColor = Color.Red;
            error_img.Location = new Point(56, 412);
            error_img.Margin = new Padding(4, 0, 4, 0);
            error_img.Name = "error_img";
            error_img.Size = new Size(0, 19);
            error_img.TabIndex = 4;
            // 
            // r_img
            // 
            r_img.BackgroundImage = (Image)resources.GetObject("r_img.BackgroundImage");
            r_img.BackgroundImageLayout = ImageLayout.Zoom;
            r_img.BorderStyle = BorderStyle.FixedSingle;
            r_img.ErrorImage = null;
            r_img.ImageLocation = "/Assets/Diractor_Images";
            r_img.Location = new Point(61, 25);
            r_img.Margin = new Padding(4, 3, 4, 3);
            r_img.Name = "r_img";
            r_img.Size = new Size(291, 288);
            r_img.SizeMode = PictureBoxSizeMode.StretchImage;
            r_img.TabIndex = 3;
            r_img.TabStop = false;
            r_img.Click += r_img_Click_1;
            // 
            // img_up
            // 
            img_up.BackColor = Color.FromArgb(0, 59, 111);
            img_up.FlatAppearance.BorderSize = 0;
            img_up.FlatStyle = FlatStyle.Flat;
            img_up.ForeColor = Color.Snow;
            img_up.Location = new Point(149, 321);
            img_up.Margin = new Padding(4, 3, 4, 3);
            img_up.Name = "img_up";
            img_up.Size = new Size(104, 74);
            img_up.TabIndex = 1;
            img_up.Text = "Resim Yükle";
            img_up.UseVisualStyleBackColor = false;
            img_up.Click += button1_Click;
            // 
            // r_save
            // 
            r_save.BackColor = Color.FromArgb(0, 59, 111);
            r_save.Dock = DockStyle.Bottom;
            r_save.FlatAppearance.BorderSize = 0;
            r_save.FlatStyle = FlatStyle.Flat;
            r_save.Font = new Font("Arial Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            r_save.ForeColor = Color.Snow;
            r_save.Location = new Point(0, 714);
            r_save.Margin = new Padding(4, 3, 4, 3);
            r_save.Name = "r_save";
            r_save.Size = new Size(1371, 74);
            r_save.TabIndex = 2;
            r_save.Text = "KAYDET";
            r_save.UseVisualStyleBackColor = false;
            r_save.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(4, 7);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(339, 28);
            label1.TabIndex = 0;
            label1.Text = "[YÖNETMEN GÜNCELLEME]";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 59, 111);
            panel1.Controls.Add(ex_button);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1371, 46);
            panel1.TabIndex = 2;
            // 
            // ex_button
            // 
            ex_button.BackColor = Color.FromArgb(194, 54, 22);
            ex_button.Cursor = Cursors.Hand;
            ex_button.Dock = DockStyle.Right;
            ex_button.FlatAppearance.BorderSize = 0;
            ex_button.FlatStyle = FlatStyle.Flat;
            ex_button.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ex_button.ForeColor = SystemColors.InactiveBorder;
            ex_button.Location = new Point(1324, 0);
            ex_button.Margin = new Padding(4, 3, 4, 3);
            ex_button.Name = "ex_button";
            ex_button.Size = new Size(47, 46);
            ex_button.TabIndex = 1;
            ex_button.Text = "X";
            ex_button.UseVisualStyleBackColor = false;
            ex_button.Click += ex_button_Click;
            // 
            // groupBox3
            // 
            groupBox3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox3.Controls.Add(r_id);
            groupBox3.Controls.Add(groupBox2);
            groupBox3.Controls.Add(groupBox1);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 46);
            groupBox3.Margin = new Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 3, 4, 3);
            groupBox3.Size = new Size(1371, 668);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Enter += groupBox3_Enter;
            // 
            // r_id
            // 
            r_id.AutoSize = true;
            r_id.BackColor = SystemColors.ActiveCaption;
            r_id.ForeColor = SystemColors.Control;
            r_id.Location = new Point(1324, 690);
            r_id.Margin = new Padding(4, 0, 4, 0);
            r_id.Name = "r_id";
            r_id.Size = new Size(38, 15);
            r_id.TabIndex = 5;
            r_id.Text = "label4";
            // 
            // DirectorUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(1371, 788);
            Controls.Add(groupBox3);
            Controls.Add(r_save);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "DirectorUpdate";
            StartPosition = FormStartPosition.Manual;
            Text = "AdminReg";
            Load += AdminReg_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)r_img).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button img_up;
        private System.Windows.Forms.Button r_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ex_button;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.PictureBox r_img;
        private System.Windows.Forms.Label error_bio;
        private System.Windows.Forms.Label error_surname;
        private System.Windows.Forms.Label error_name;
        private System.Windows.Forms.Label error_img;
        public System.Windows.Forms.TextBox r_name;
        public System.Windows.Forms.TextBox r_surname;
        public System.Windows.Forms.DateTimePicker r_date;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.TextBox r_bio;
        public System.Windows.Forms.Label r_id;
    }
}