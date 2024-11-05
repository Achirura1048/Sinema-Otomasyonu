namespace Sinema_Otomasyonu.Forms.Movie
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ex_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.r_save = new System.Windows.Forms.Button();
            this.movie_name = new System.Windows.Forms.GroupBox();
            this.m_name_reg = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.movie_genre = new System.Windows.Forms.GroupBox();
            this.genre_check = new System.Windows.Forms.CheckedListBox();
            this.movie_type = new System.Windows.Forms.GroupBox();
            this.type_check = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.director_search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.actor_search = new System.Windows.Forms.TextBox();
            this.Actor_List = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.r_date = new System.Windows.Forms.DateTimePicker();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.IMBD = new System.Windows.Forms.NumericUpDown();
            this.movie_rating = new System.Windows.Forms.GroupBox();
            this.rating_check = new System.Windows.Forms.CheckedListBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.r_img = new System.Windows.Forms.PictureBox();
            this.img_up = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.m_detail_reg = new System.Windows.Forms.TextBox();
            this.Director_List = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.movie_name.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.movie_genre.SuspendLayout();
            this.movie_type.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMBD)).BeginInit();
            this.movie_rating.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.r_img)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(111)))));
            this.panel1.Controls.Add(this.ex_button);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1175, 40);
            this.panel1.TabIndex = 7;
            // 
            // ex_button
            // 
            this.ex_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(54)))), ((int)(((byte)(22)))));
            this.ex_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ex_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.ex_button.FlatAppearance.BorderSize = 0;
            this.ex_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ex_button.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ex_button.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.ex_button.Location = new System.Drawing.Point(1135, 0);
            this.ex_button.Name = "ex_button";
            this.ex_button.Size = new System.Drawing.Size(40, 40);
            this.ex_button.TabIndex = 1;
            this.ex_button.Text = "X";
            this.ex_button.UseVisualStyleBackColor = false;
            this.ex_button.Click += new System.EventHandler(this.ex_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "[FILM KAYIT]";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // r_save
            // 
            this.r_save.AutoSize = true;
            this.r_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(111)))));
            this.r_save.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.r_save.FlatAppearance.BorderSize = 0;
            this.r_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.r_save.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.r_save.ForeColor = System.Drawing.Color.Snow;
            this.r_save.Location = new System.Drawing.Point(0, 585);
            this.r_save.Name = "r_save";
            this.r_save.Size = new System.Drawing.Size(1175, 48);
            this.r_save.TabIndex = 9;
            this.r_save.Text = "KAYDET";
            this.r_save.UseVisualStyleBackColor = false;
            this.r_save.Click += new System.EventHandler(this.r_save_Click);
            // 
            // movie_name
            // 
            this.movie_name.Controls.Add(this.m_name_reg);
            this.movie_name.Dock = System.Windows.Forms.DockStyle.Left;
            this.movie_name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movie_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(111)))));
            this.movie_name.Location = new System.Drawing.Point(3, 3);
            this.movie_name.Name = "movie_name";
            this.movie_name.Size = new System.Drawing.Size(245, 60);
            this.movie_name.TabIndex = 0;
            this.movie_name.TabStop = false;
            this.movie_name.Text = "Film Adı";
            // 
            // m_name_reg
            // 
            this.m_name_reg.BackColor = System.Drawing.SystemColors.Control;
            this.m_name_reg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_name_reg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_name_reg.Location = new System.Drawing.Point(3, 38);
            this.m_name_reg.Name = "m_name_reg";
            this.m_name_reg.Size = new System.Drawing.Size(239, 19);
            this.m_name_reg.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.movie_name);
            this.flowLayoutPanel1.Controls.Add(this.movie_genre);
            this.flowLayoutPanel1.Controls.Add(this.movie_type);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox5);
            this.flowLayoutPanel1.Controls.Add(this.groupBox6);
            this.flowLayoutPanel1.Controls.Add(this.movie_rating);
            this.flowLayoutPanel1.Controls.Add(this.groupBox7);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1175, 434);
            this.flowLayoutPanel1.TabIndex = 8;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // movie_genre
            // 
            this.movie_genre.Controls.Add(this.genre_check);
            this.movie_genre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movie_genre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(111)))));
            this.movie_genre.Location = new System.Drawing.Point(3, 69);
            this.movie_genre.Name = "movie_genre";
            this.movie_genre.Size = new System.Drawing.Size(242, 237);
            this.movie_genre.TabIndex = 1;
            this.movie_genre.TabStop = false;
            this.movie_genre.Text = "Film Türü";
            // 
            // genre_check
            // 
            this.genre_check.Dock = System.Windows.Forms.DockStyle.Fill;
            this.genre_check.FormattingEnabled = true;
            this.genre_check.Items.AddRange(new object[] {
            "Aksiyon",
            "Dram",
            "Komedi",
            "Korku",
            "Bilim Kurgu",
            "Fantastik",
            "Macera",
            "Romantik",
            "Belgesel",
            "Gerilim",
            "Gizem",
            "Suç",
            "Savaş",
            "Western",
            "Animasyon",
            "Çocuk",
            "Aile",
            "Müzikal",
            "Tarih"});
            this.genre_check.Location = new System.Drawing.Point(3, 22);
            this.genre_check.Name = "genre_check";
            this.genre_check.Size = new System.Drawing.Size(236, 212);
            this.genre_check.TabIndex = 0;
            // 
            // movie_type
            // 
            this.movie_type.Controls.Add(this.type_check);
            this.movie_type.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movie_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(111)))));
            this.movie_type.Location = new System.Drawing.Point(3, 312);
            this.movie_type.Name = "movie_type";
            this.movie_type.Size = new System.Drawing.Size(239, 116);
            this.movie_type.TabIndex = 3;
            this.movie_type.TabStop = false;
            this.movie_type.Text = "Film Biçimi";
            // 
            // type_check
            // 
            this.type_check.Dock = System.Windows.Forms.DockStyle.Fill;
            this.type_check.FormattingEnabled = true;
            this.type_check.Items.AddRange(new object[] {
            "Türkçe Dublaj",
            "Türkçe Altyazı",
            "3D"});
            this.type_check.Location = new System.Drawing.Point(3, 22);
            this.type_check.Name = "type_check";
            this.type_check.Size = new System.Drawing.Size(233, 91);
            this.type_check.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Director_List);
            this.groupBox2.Controls.Add(this.director_search);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(111)))));
            this.groupBox2.Location = new System.Drawing.Point(254, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 210);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yönetmen(ler)";
            // 
            // director_search
            // 
            this.director_search.Location = new System.Drawing.Point(6, 181);
            this.director_search.Name = "director_search";
            this.director_search.Size = new System.Drawing.Size(141, 26);
            this.director_search.TabIndex = 3;
            this.director_search.TextChanged += new System.EventHandler(this.director_search_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yönetmen Ara";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.actor_search);
            this.groupBox1.Controls.Add(this.Actor_List);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(111)))));
            this.groupBox1.Location = new System.Drawing.Point(254, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 210);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oyuncu(lar)";
            // 
            // actor_search
            // 
            this.actor_search.Location = new System.Drawing.Point(6, 181);
            this.actor_search.Name = "actor_search";
            this.actor_search.Size = new System.Drawing.Size(147, 26);
            this.actor_search.TabIndex = 5;
            this.actor_search.TextChanged += new System.EventHandler(this.actor_search_TextChanged);
            // 
            // Actor_List
            // 
            this.Actor_List.AutoScroll = true;
            this.Actor_List.Dock = System.Windows.Forms.DockStyle.Top;
            this.Actor_List.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actor_List.Location = new System.Drawing.Point(3, 22);
            this.Actor_List.Name = "Actor_List";
            this.Actor_List.Size = new System.Drawing.Size(257, 158);
            this.Actor_List.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Oyuncu Ara";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.r_date);
            this.groupBox5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(111)))));
            this.groupBox5.Location = new System.Drawing.Point(523, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(183, 86);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Vizyon Tarihi";
            // 
            // r_date
            // 
            this.r_date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.r_date.CustomFormat = "dd-MM-yyyy";
            this.r_date.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.r_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.r_date.Location = new System.Drawing.Point(5, 38);
            this.r_date.Name = "r_date";
            this.r_date.Size = new System.Drawing.Size(178, 29);
            this.r_date.TabIndex = 31;
            this.r_date.Value = new System.DateTime(2024, 10, 8, 0, 0, 0, 0);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.IMBD);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(111)))));
            this.groupBox6.Location = new System.Drawing.Point(523, 95);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(183, 50);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "IMBD PUANI /10";
            // 
            // IMBD
            // 
            this.IMBD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IMBD.Location = new System.Drawing.Point(3, 22);
            this.IMBD.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.IMBD.Name = "IMBD";
            this.IMBD.Size = new System.Drawing.Size(177, 26);
            this.IMBD.TabIndex = 0;
            // 
            // movie_rating
            // 
            this.movie_rating.Controls.Add(this.rating_check);
            this.movie_rating.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movie_rating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(111)))));
            this.movie_rating.Location = new System.Drawing.Point(523, 151);
            this.movie_rating.Name = "movie_rating";
            this.movie_rating.Size = new System.Drawing.Size(183, 275);
            this.movie_rating.TabIndex = 2;
            this.movie_rating.TabStop = false;
            this.movie_rating.Text = "Film Özellikleri";
            // 
            // rating_check
            // 
            this.rating_check.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rating_check.FormattingEnabled = true;
            this.rating_check.Items.AddRange(new object[] {
            "6 Yaş Altı",
            "6 Yaş Üzeri",
            "10 Yaş Altı",
            "10 Yaş Üzeri",
            "13 Yaş Altı",
            "13 Yaş Üzeri",
            "16 Yaş Üzeri",
            "18 Yaş Üzeri",
            "Genel İzleyici",
            "Şiddet/Korku",
            "Cinsellik/Çıplaklık",
            "Olumsuz Örnek"});
            this.rating_check.Location = new System.Drawing.Point(3, 22);
            this.rating_check.Name = "rating_check";
            this.rating_check.Size = new System.Drawing.Size(177, 250);
            this.rating_check.TabIndex = 2;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox7.Controls.Add(this.r_img);
            this.groupBox7.Controls.Add(this.img_up);
            this.groupBox7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(111)))));
            this.groupBox7.Location = new System.Drawing.Point(712, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox7.Size = new System.Drawing.Size(319, 425);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Afiş";
            // 
            // r_img
            // 
            this.r_img.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("r_img.BackgroundImage")));
            this.r_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.r_img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.r_img.Dock = System.Windows.Forms.DockStyle.Fill;
            this.r_img.ErrorImage = null;
            this.r_img.ImageLocation = "/Assets/Diractor_Images";
            this.r_img.Location = new System.Drawing.Point(0, 19);
            this.r_img.Name = "r_img";
            this.r_img.Size = new System.Drawing.Size(319, 363);
            this.r_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.r_img.TabIndex = 5;
            this.r_img.TabStop = false;
            this.r_img.Click += new System.EventHandler(this.r_img_Click);
            // 
            // img_up
            // 
            this.img_up.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(111)))));
            this.img_up.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.img_up.FlatAppearance.BorderSize = 0;
            this.img_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.img_up.ForeColor = System.Drawing.Color.Snow;
            this.img_up.Location = new System.Drawing.Point(0, 382);
            this.img_up.Name = "img_up";
            this.img_up.Size = new System.Drawing.Size(319, 43);
            this.img_up.TabIndex = 4;
            this.img_up.Text = "Resim Yükle";
            this.img_up.UseVisualStyleBackColor = false;
            this.img_up.Click += new System.EventHandler(this.img_up_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.m_detail_reg);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(111)))));
            this.groupBox8.Location = new System.Drawing.Point(0, 472);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(1175, 113);
            this.groupBox8.TabIndex = 10;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Film Detay";
            // 
            // m_detail_reg
            // 
            this.m_detail_reg.BackColor = System.Drawing.SystemColors.Control;
            this.m_detail_reg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_detail_reg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_detail_reg.Location = new System.Drawing.Point(3, 22);
            this.m_detail_reg.Multiline = true;
            this.m_detail_reg.Name = "m_detail_reg";
            this.m_detail_reg.Size = new System.Drawing.Size(1169, 88);
            this.m_detail_reg.TabIndex = 1;
            // 
            // Director_List
            // 
            this.Director_List.AutoScroll = true;
            this.Director_List.Dock = System.Windows.Forms.DockStyle.Top;
            this.Director_List.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Director_List.Location = new System.Drawing.Point(3, 22);
            this.Director_List.Name = "Director_List";
            this.Director_List.Size = new System.Drawing.Size(257, 158);
            this.Director_List.TabIndex = 5;
            // 
            // MovieReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 633);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.r_save);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MovieReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MovieReg";
            this.Load += new System.EventHandler(this.MovieReg_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.movie_name.ResumeLayout(false);
            this.movie_name.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.movie_genre.ResumeLayout(false);
            this.movie_type.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IMBD)).EndInit();
            this.movie_rating.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.r_img)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.GroupBox movie_type;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox director_search;
        private System.Windows.Forms.TextBox actor_search;
        public System.Windows.Forms.FlowLayoutPanel Actor_List;
        private System.Windows.Forms.CheckedListBox rating_check;
        private System.Windows.Forms.CheckedListBox genre_check;
        private System.Windows.Forms.CheckedListBox type_check;
        private System.Windows.Forms.DateTimePicker r_date;
        public System.Windows.Forms.FlowLayoutPanel Director_List;
    }
}