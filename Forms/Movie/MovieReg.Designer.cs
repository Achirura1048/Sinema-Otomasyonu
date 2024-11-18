﻿namespace Sinema_Otomasyonu.Forms.Movie
{
    partial class MovieReg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieReg));
            panel1 = new Panel();
            ex_button = new Button();
            label1 = new Label();
            r_save = new Button();
            movie_name = new GroupBox();
            m_name_reg = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            movie_genre = new GroupBox();
            genre_check = new CheckedListBox();
            groupBox2 = new GroupBox();
            director_check = new CheckedListBox();
            groupBox1 = new GroupBox();
            actor_check = new CheckedListBox();
            groupBox5 = new GroupBox();
            r_date = new DateTimePicker();
            groupBox6 = new GroupBox();
            IMBD = new NumericUpDown();
            movie_rating = new GroupBox();
            rating_check = new CheckedListBox();
            groupBox7 = new GroupBox();
            r_img = new PictureBox();
            img_up = new Button();
            groupBox8 = new GroupBox();
            m_detail_reg = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            movie_name.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            movie_genre.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IMBD).BeginInit();
            movie_rating.SuspendLayout();
            groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)r_img).BeginInit();
            groupBox8.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 59, 111);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(ex_button);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1371, 46);
            panel1.TabIndex = 7;
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
            label1.Size = new Size(159, 28);
            label1.TabIndex = 0;
            label1.Text = "[FILM KAYIT]";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // r_save
            // 
            r_save.AutoSize = true;
            r_save.BackColor = Color.FromArgb(0, 59, 111);
            r_save.Dock = DockStyle.Bottom;
            r_save.FlatAppearance.BorderSize = 0;
            r_save.FlatStyle = FlatStyle.Flat;
            r_save.Font = new Font("Arial Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            r_save.ForeColor = Color.Snow;
            r_save.Location = new Point(0, 675);
            r_save.Margin = new Padding(4, 3, 4, 3);
            r_save.Name = "r_save";
            r_save.Size = new Size(1371, 55);
            r_save.TabIndex = 9;
            r_save.Text = "KAYDET";
            r_save.UseVisualStyleBackColor = false;
            r_save.Click += r_save_Click;
            // 
            // movie_name
            // 
            movie_name.Controls.Add(m_name_reg);
            movie_name.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            movie_name.ForeColor = Color.FromArgb(0, 59, 111);
            movie_name.Location = new Point(4, 3);
            movie_name.Margin = new Padding(4, 3, 4, 3);
            movie_name.Name = "movie_name";
            movie_name.Padding = new Padding(4, 3, 4, 3);
            movie_name.Size = new Size(286, 39);
            movie_name.TabIndex = 0;
            movie_name.TabStop = false;
            movie_name.Text = "Film Adı";
            // 
            // m_name_reg
            // 
            m_name_reg.BackColor = SystemColors.Control;
            m_name_reg.BorderStyle = BorderStyle.None;
            m_name_reg.Dock = DockStyle.Bottom;
            m_name_reg.Location = new Point(4, 17);
            m_name_reg.Margin = new Padding(4, 3, 4, 3);
            m_name_reg.Name = "m_name_reg";
            m_name_reg.Size = new Size(278, 19);
            m_name_reg.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(movie_name);
            flowLayoutPanel1.Controls.Add(movie_genre);
            flowLayoutPanel1.Controls.Add(groupBox2);
            flowLayoutPanel1.Controls.Add(groupBox1);
            flowLayoutPanel1.Controls.Add(groupBox5);
            flowLayoutPanel1.Controls.Add(groupBox6);
            flowLayoutPanel1.Controls.Add(movie_rating);
            flowLayoutPanel1.Controls.Add(groupBox7);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 46);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1371, 501);
            flowLayoutPanel1.TabIndex = 8;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // movie_genre
            // 
            movie_genre.Controls.Add(genre_check);
            movie_genre.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            movie_genre.ForeColor = Color.FromArgb(0, 59, 111);
            movie_genre.Location = new Point(4, 48);
            movie_genre.Margin = new Padding(4, 3, 4, 3);
            movie_genre.Name = "movie_genre";
            movie_genre.Padding = new Padding(4, 3, 4, 3);
            movie_genre.Size = new Size(282, 445);
            movie_genre.TabIndex = 1;
            movie_genre.TabStop = false;
            movie_genre.Text = "Film Türü";
            // 
            // genre_check
            // 
            genre_check.Dock = DockStyle.Fill;
            genre_check.FormattingEnabled = true;
            genre_check.Location = new Point(4, 22);
            genre_check.Margin = new Padding(4, 3, 4, 3);
            genre_check.Name = "genre_check";
            genre_check.Size = new Size(274, 420);
            genre_check.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(director_check);
            groupBox2.Dock = DockStyle.Left;
            groupBox2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.FromArgb(0, 59, 111);
            groupBox2.Location = new Point(298, 3);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(307, 242);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Yönetmen(ler)";
            // 
            // director_check
            // 
            director_check.Dock = DockStyle.Fill;
            director_check.FormattingEnabled = true;
            director_check.Location = new Point(4, 22);
            director_check.Margin = new Padding(4, 3, 4, 3);
            director_check.Name = "director_check";
            director_check.Size = new Size(299, 217);
            director_check.TabIndex = 4;
            director_check.SelectedIndexChanged += director_check_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(actor_check);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(0, 59, 111);
            groupBox1.Location = new Point(298, 251);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(307, 242);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Oyuncu(lar)";
            // 
            // actor_check
            // 
            actor_check.Dock = DockStyle.Fill;
            actor_check.FormattingEnabled = true;
            actor_check.Location = new Point(4, 22);
            actor_check.Margin = new Padding(4, 3, 4, 3);
            actor_check.Name = "actor_check";
            actor_check.Size = new Size(299, 217);
            actor_check.TabIndex = 6;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(r_date);
            groupBox5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox5.ForeColor = Color.FromArgb(0, 59, 111);
            groupBox5.Location = new Point(613, 3);
            groupBox5.Margin = new Padding(4, 3, 4, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4, 3, 4, 3);
            groupBox5.Size = new Size(214, 99);
            groupBox5.TabIndex = 7;
            groupBox5.TabStop = false;
            groupBox5.Text = "Vizyon Tarihi";
            // 
            // r_date
            // 
            r_date.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            r_date.CustomFormat = "dd-MM-yyyy";
            r_date.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            r_date.Format = DateTimePickerFormat.Short;
            r_date.Location = new Point(6, 44);
            r_date.Margin = new Padding(4, 3, 4, 3);
            r_date.Name = "r_date";
            r_date.Size = new Size(207, 29);
            r_date.TabIndex = 31;
            r_date.Value = new DateTime(2024, 10, 8, 0, 0, 0, 0);
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(IMBD);
            groupBox6.Dock = DockStyle.Left;
            groupBox6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox6.ForeColor = Color.FromArgb(0, 59, 111);
            groupBox6.Location = new Point(613, 108);
            groupBox6.Margin = new Padding(4, 3, 4, 3);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(4, 3, 4, 3);
            groupBox6.Size = new Size(214, 58);
            groupBox6.TabIndex = 8;
            groupBox6.TabStop = false;
            groupBox6.Text = "IMBD PUANI /10";
            // 
            // IMBD
            // 
            IMBD.Dock = DockStyle.Fill;
            IMBD.Location = new Point(4, 22);
            IMBD.Margin = new Padding(4, 3, 4, 3);
            IMBD.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            IMBD.Name = "IMBD";
            IMBD.Size = new Size(206, 26);
            IMBD.TabIndex = 0;
            // 
            // movie_rating
            // 
            movie_rating.Controls.Add(rating_check);
            movie_rating.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            movie_rating.ForeColor = Color.FromArgb(0, 59, 111);
            movie_rating.Location = new Point(613, 172);
            movie_rating.Margin = new Padding(4, 3, 4, 3);
            movie_rating.Name = "movie_rating";
            movie_rating.Padding = new Padding(4, 3, 4, 3);
            movie_rating.Size = new Size(214, 317);
            movie_rating.TabIndex = 2;
            movie_rating.TabStop = false;
            movie_rating.Text = "Film Özellikleri";
            // 
            // rating_check
            // 
            rating_check.Dock = DockStyle.Fill;
            rating_check.FormattingEnabled = true;
            rating_check.Location = new Point(4, 22);
            rating_check.Margin = new Padding(4, 3, 4, 3);
            rating_check.Name = "rating_check";
            rating_check.Size = new Size(206, 292);
            rating_check.TabIndex = 2;
            // 
            // groupBox7
            // 
            groupBox7.Anchor = AnchorStyles.Left;
            groupBox7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox7.Controls.Add(r_img);
            groupBox7.Controls.Add(img_up);
            groupBox7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox7.ForeColor = Color.FromArgb(0, 59, 111);
            groupBox7.Location = new Point(835, 3);
            groupBox7.Margin = new Padding(4, 3, 4, 3);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(0);
            groupBox7.Size = new Size(372, 490);
            groupBox7.TabIndex = 9;
            groupBox7.TabStop = false;
            groupBox7.Text = "Afiş";
            // 
            // r_img
            // 
            r_img.BackgroundImage = (Image)resources.GetObject("r_img.BackgroundImage");
            r_img.BackgroundImageLayout = ImageLayout.Zoom;
            r_img.BorderStyle = BorderStyle.FixedSingle;
            r_img.Dock = DockStyle.Fill;
            r_img.ErrorImage = null;
            r_img.ImageLocation = "/Assets/Diractor_Images";
            r_img.Location = new Point(0, 19);
            r_img.Margin = new Padding(4, 3, 4, 3);
            r_img.Name = "r_img";
            r_img.Size = new Size(372, 421);
            r_img.SizeMode = PictureBoxSizeMode.StretchImage;
            r_img.TabIndex = 5;
            r_img.TabStop = false;
            r_img.Click += r_img_Click;
            // 
            // img_up
            // 
            img_up.BackColor = Color.FromArgb(0, 59, 111);
            img_up.Dock = DockStyle.Bottom;
            img_up.FlatAppearance.BorderSize = 0;
            img_up.FlatStyle = FlatStyle.Flat;
            img_up.ForeColor = Color.Snow;
            img_up.Location = new Point(0, 440);
            img_up.Margin = new Padding(4, 3, 4, 3);
            img_up.Name = "img_up";
            img_up.Size = new Size(372, 50);
            img_up.TabIndex = 4;
            img_up.Text = "Resim Yükle";
            img_up.UseVisualStyleBackColor = false;
            img_up.Click += img_up_Click;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(m_detail_reg);
            groupBox8.Dock = DockStyle.Bottom;
            groupBox8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox8.ForeColor = Color.FromArgb(0, 59, 111);
            groupBox8.Location = new Point(0, 545);
            groupBox8.Margin = new Padding(4, 3, 4, 3);
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new Padding(4, 3, 4, 3);
            groupBox8.Size = new Size(1371, 130);
            groupBox8.TabIndex = 10;
            groupBox8.TabStop = false;
            groupBox8.Text = "Film Detay";
            // 
            // m_detail_reg
            // 
            m_detail_reg.BackColor = SystemColors.Control;
            m_detail_reg.BorderStyle = BorderStyle.None;
            m_detail_reg.Dock = DockStyle.Fill;
            m_detail_reg.Location = new Point(4, 22);
            m_detail_reg.Margin = new Padding(4, 3, 4, 3);
            m_detail_reg.Multiline = true;
            m_detail_reg.Name = "m_detail_reg";
            m_detail_reg.Size = new Size(1363, 105);
            m_detail_reg.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(0, 59, 111);
            label2.Location = new Point(210, 9);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 2;
            label2.Text = "r_id";
            // 
            // MovieReg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 730);
            Controls.Add(groupBox8);
            Controls.Add(r_save);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MovieReg";
            StartPosition = FormStartPosition.Manual;
            Text = "MovieReg";
            Load += MovieReg_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            movie_name.ResumeLayout(false);
            movie_name.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            movie_genre.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)IMBD).EndInit();
            movie_rating.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)r_img).EndInit();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ex_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button r_save;
        private System.Windows.Forms.GroupBox movie_name;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox m_name_reg;
        private System.Windows.Forms.GroupBox movie_genre;
        private System.Windows.Forms.GroupBox movie_rating;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.NumericUpDown IMBD;
        private System.Windows.Forms.TextBox m_detail_reg;
        public System.Windows.Forms.PictureBox r_img;
        private System.Windows.Forms.Button img_up;
        private System.Windows.Forms.CheckedListBox rating_check;
        private System.Windows.Forms.CheckedListBox genre_check;
        private System.Windows.Forms.DateTimePicker r_date;
        private System.Windows.Forms.CheckedListBox director_check;
        private System.Windows.Forms.CheckedListBox actor_check;
        private Label label2;
    }
}