namespace Sinema_Otomasyonu.Forms.Actor
{
    partial class ActorUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActorUpdate));
            error_img = new Label();
            img_up = new Button();
            groupBox2 = new GroupBox();
            r_img = new PictureBox();
            error_sname = new Label();
            error_name = new Label();
            label4 = new Label();
            error_bio = new Label();
            error_surname = new Label();
            r_bio = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            female = new RadioButton();
            male = new RadioButton();
            label7 = new Label();
            r_date = new DateTimePicker();
            label6 = new Label();
            r_surname = new TextBox();
            label3 = new Label();
            r_name = new TextBox();
            label2 = new Label();
            r_save = new Button();
            ex_button = new Button();
            label1 = new Label();
            panel1 = new Panel();
            r_id = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)r_img).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // error_img
            // 
            error_img.AutoSize = true;
            error_img.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Underline);
            error_img.ForeColor = Color.Red;
            error_img.Location = new Point(58, 412);
            error_img.Margin = new Padding(4, 0, 4, 0);
            error_img.Name = "error_img";
            error_img.Size = new Size(0, 19);
            error_img.TabIndex = 4;
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
            img_up.Click += img_up_Click;
            // 
            // groupBox2
            // 
            groupBox2.AutoSize = true;
            groupBox2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox2.Controls.Add(error_img);
            groupBox2.Controls.Add(r_img);
            groupBox2.Controls.Add(img_up);
            groupBox2.Font = new Font("Arial", 15.75F);
            groupBox2.Location = new Point(588, 0);
            groupBox2.Margin = new Padding(0);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(360, 459);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
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
            // 
            // error_sname
            // 
            error_sname.AutoSize = true;
            error_sname.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            error_sname.ForeColor = Color.Red;
            error_sname.Location = new Point(307, 92);
            error_sname.Margin = new Padding(4, 0, 4, 0);
            error_sname.Name = "error_sname";
            error_sname.Size = new Size(0, 20);
            error_sname.TabIndex = 42;
            // 
            // error_name
            // 
            error_name.AutoSize = true;
            error_name.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            error_name.ForeColor = Color.Red;
            error_name.Location = new Point(6, 92);
            error_name.Margin = new Padding(4, 0, 4, 0);
            error_name.Name = "error_name";
            error_name.Size = new Size(0, 20);
            error_name.TabIndex = 41;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 59, 111);
            label4.Location = new Point(8, 278);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(94, 22);
            label4.TabIndex = 40;
            label4.Text = "Biyografi";
            // 
            // error_bio
            // 
            error_bio.AutoSize = true;
            error_bio.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Underline);
            error_bio.ForeColor = Color.Red;
            error_bio.Location = new Point(14, 603);
            error_bio.Margin = new Padding(4, 0, 4, 0);
            error_bio.Name = "error_bio";
            error_bio.Size = new Size(0, 19);
            error_bio.TabIndex = 39;
            // 
            // error_surname
            // 
            error_surname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            error_surname.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Underline);
            error_surname.ForeColor = Color.Red;
            error_surname.Location = new Point(312, 92);
            error_surname.Margin = new Padding(4, 0, 4, 0);
            error_surname.MaximumSize = new Size(260, 35);
            error_surname.Name = "error_surname";
            error_surname.Size = new Size(260, 35);
            error_surname.TabIndex = 38;
            // 
            // r_bio
            // 
            r_bio.Location = new Point(0, 303);
            r_bio.Margin = new Padding(4, 3, 4, 3);
            r_bio.Multiline = true;
            r_bio.Name = "r_bio";
            r_bio.Size = new Size(576, 173);
            r_bio.TabIndex = 36;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(436, 180);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 35;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(335, 180);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(groupBox2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 46);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1371, 742);
            flowLayoutPanel1.TabIndex = 11;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.Controls.Add(error_sname);
            panel2.Controls.Add(error_name);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(error_bio);
            panel2.Controls.Add(error_surname);
            panel2.Controls.Add(r_bio);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(female);
            panel2.Controls.Add(male);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(r_date);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(r_surname);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(r_name);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(4, 3);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(580, 678);
            panel2.TabIndex = 8;
            // 
            // female
            // 
            female.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            female.AutoSize = true;
            female.Location = new Point(413, 194);
            female.Margin = new Padding(4, 3, 4, 3);
            female.Name = "female";
            female.Size = new Size(14, 13);
            female.TabIndex = 33;
            female.UseVisualStyleBackColor = true;
            female.Click += female_CheckedChanged;
            // 
            // male
            // 
            male.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            male.AutoSize = true;
            male.Checked = true;
            male.Location = new Point(312, 194);
            male.Margin = new Padding(4, 3, 4, 3);
            male.Name = "male";
            male.Size = new Size(14, 13);
            male.TabIndex = 32;
            male.TabStop = true;
            male.UseVisualStyleBackColor = true;
            male.Click += male_CheckedChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(0, 59, 111);
            label7.Location = new Point(309, 149);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(85, 22);
            label7.TabIndex = 31;
            label7.Text = "Cinsiyet";
            // 
            // r_date
            // 
            r_date.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            r_date.CustomFormat = "dd-MM-yyyy";
            r_date.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            r_date.Format = DateTimePickerFormat.Short;
            r_date.Location = new Point(13, 194);
            r_date.Margin = new Padding(4, 3, 4, 3);
            r_date.Name = "r_date";
            r_date.Size = new Size(207, 29);
            r_date.TabIndex = 30;
            r_date.Value = new DateTime(2024, 10, 8, 0, 0, 0, 0);
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(0, 59, 111);
            label6.Location = new Point(6, 151);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(135, 22);
            label6.TabIndex = 29;
            label6.Text = "Doğum Tarihi";
            // 
            // r_surname
            // 
            r_surname.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            r_surname.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            r_surname.Location = new Point(312, 42);
            r_surname.Margin = new Padding(4, 3, 4, 3);
            r_surname.Name = "r_surname";
            r_surname.Size = new Size(257, 32);
            r_surname.TabIndex = 28;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 59, 111);
            label3.Location = new Point(312, 9);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(69, 22);
            label3.TabIndex = 27;
            label3.Text = "Soyad";
            // 
            // r_name
            // 
            r_name.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            r_name.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            r_name.Location = new Point(10, 42);
            r_name.Margin = new Padding(4, 3, 4, 3);
            r_name.Name = "r_name";
            r_name.Size = new Size(237, 32);
            r_name.TabIndex = 26;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 59, 111);
            label2.Location = new Point(8, 9);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(35, 22);
            label2.TabIndex = 25;
            label2.Text = "Ad";
            // 
            // r_save
            // 
            r_save.BackColor = Color.FromArgb(0, 59, 111);
            r_save.Dock = DockStyle.Bottom;
            r_save.FlatAppearance.BorderSize = 0;
            r_save.FlatStyle = FlatStyle.Flat;
            r_save.Font = new Font("Arial Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            r_save.ForeColor = Color.Snow;
            r_save.Location = new Point(0, 733);
            r_save.Margin = new Padding(4, 3, 4, 3);
            r_save.Name = "r_save";
            r_save.Size = new Size(1371, 55);
            r_save.TabIndex = 10;
            r_save.Text = "KAYDET";
            r_save.UseVisualStyleBackColor = false;
            r_save.Click += r_save_Click;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(4, 7);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(206, 28);
            label1.TabIndex = 0;
            label1.Text = "[OYUNCU KAYIT]";
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
            panel1.TabIndex = 9;
            // 
            // r_id
            // 
            r_id.AutoSize = true;
            r_id.BackColor = SystemColors.ActiveCaption;
            r_id.ForeColor = SystemColors.Control;
            r_id.Location = new Point(1320, 759);
            r_id.Margin = new Padding(4, 0, 4, 0);
            r_id.Name = "r_id";
            r_id.Size = new Size(38, 15);
            r_id.TabIndex = 44;
            r_id.Text = "label4";
            // 
            // ActorUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 788);
            Controls.Add(r_save);
            Controls.Add(r_id);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "ActorUpdate";
            Text = "ActorUpdate";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)r_img).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public PictureBox r_img;
        public Label error_img;
        public Button img_up;
        public GroupBox groupBox2;
        public Label error_sname;
        public Label error_name;
        public Label label4;
        public Label error_bio;
        public Label error_surname;
        public TextBox r_bio;
        public PictureBox pictureBox2;
        public PictureBox pictureBox1;
        public FlowLayoutPanel flowLayoutPanel1;
        public Panel panel2;
        public RadioButton female;
        public RadioButton male;
        public Label label7;
        public DateTimePicker r_date;
        public Label label6;
        public TextBox r_surname;
        public Label label3;
        public TextBox r_name;
        public Label label2;
        public Button r_save;
        public Button ex_button;
        public Label label1;
        public Panel panel1;
        public Label r_id;
    }
}