namespace Achi_Sinema.UserControls
{
    partial class MovieListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieListControl));
            panel1 = new Panel();
            ListMovieID = new Label();
            ListMovieName = new Label();
            ListMoviePanel = new FlowLayoutPanel();
            ListMovieImg = new PictureBox();
            ListMovieActors = new FlowLayoutPanel();
            panel3 = new Panel();
            label2 = new Label();
            ListMovieRatings = new FlowLayoutPanel();
            panel4 = new Panel();
            label3 = new Label();
            ListRatingCheck = new CheckedListBox();
            ListMovieDirector = new Panel();
            ListDirectorName = new Label();
            label1 = new Label();
            ListDirectorImg = new PictureBox();
            panel6 = new Panel();
            ListMovieDate = new DateTimePicker();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            edit = new PictureBox();
            panel7 = new Panel();
            ListMovieSum = new TextBox();
            panel9 = new Panel();
            label6 = new Label();
            panel8 = new Panel();
            ListMovieGenre = new CheckedListBox();
            panel10 = new Panel();
            label7 = new Label();
            panel5 = new Panel();
            ListMovieRate = new NumericUpDown();
            label4 = new Label();
            panel1.SuspendLayout();
            ListMoviePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ListMovieImg).BeginInit();
            ListMovieActors.SuspendLayout();
            panel3.SuspendLayout();
            ListMovieRatings.SuspendLayout();
            panel4.SuspendLayout();
            ListMovieDirector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ListDirectorImg).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)edit).BeginInit();
            panel7.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel10.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ListMovieRate).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 59, 111);
            panel1.Controls.Add(ListMovieID);
            panel1.Controls.Add(ListMovieName);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(656, 40);
            panel1.TabIndex = 0;
            // 
            // ListMovieID
            // 
            ListMovieID.AutoSize = true;
            ListMovieID.ForeColor = Color.FromArgb(0, 59, 111);
            ListMovieID.Location = new Point(557, 6);
            ListMovieID.Name = "ListMovieID";
            ListMovieID.Size = new Size(38, 15);
            ListMovieID.TabIndex = 1;
            ListMovieID.Text = "label8";
            // 
            // ListMovieName
            // 
            ListMovieName.AutoSize = true;
            ListMovieName.Font = new Font("Arial", 18F, FontStyle.Bold | FontStyle.Italic);
            ListMovieName.ForeColor = Color.White;
            ListMovieName.Location = new Point(3, 6);
            ListMovieName.Name = "ListMovieName";
            ListMovieName.Size = new Size(80, 28);
            ListMovieName.TabIndex = 0;
            ListMovieName.Text = "label1";
            ListMovieName.Click += label1_Click;
            // 
            // ListMoviePanel
            // 
            ListMoviePanel.Controls.Add(ListMovieImg);
            ListMoviePanel.Controls.Add(ListMovieActors);
            ListMoviePanel.Controls.Add(ListMovieRatings);
            ListMoviePanel.Controls.Add(ListMovieDirector);
            ListMoviePanel.Controls.Add(panel6);
            ListMoviePanel.Controls.Add(pictureBox2);
            ListMoviePanel.Controls.Add(edit);
            ListMoviePanel.Controls.Add(panel7);
            ListMoviePanel.Controls.Add(panel8);
            ListMoviePanel.Controls.Add(panel5);
            ListMoviePanel.Dock = DockStyle.Fill;
            ListMoviePanel.Location = new Point(0, 40);
            ListMoviePanel.Name = "ListMoviePanel";
            ListMoviePanel.Size = new Size(656, 614);
            ListMoviePanel.TabIndex = 1;
            // 
            // ListMovieImg
            // 
            ListMovieImg.Location = new Point(3, 3);
            ListMovieImg.Name = "ListMovieImg";
            ListMovieImg.Size = new Size(200, 267);
            ListMovieImg.SizeMode = PictureBoxSizeMode.Zoom;
            ListMovieImg.TabIndex = 0;
            ListMovieImg.TabStop = false;
            // 
            // ListMovieActors
            // 
            ListMovieActors.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            ListMovieActors.AutoScroll = true;
            ListMovieActors.Controls.Add(panel3);
            ListMovieActors.FlowDirection = FlowDirection.TopDown;
            ListMovieActors.Location = new Point(209, 3);
            ListMovieActors.Name = "ListMovieActors";
            ListMovieActors.Size = new Size(224, 267);
            ListMovieActors.TabIndex = 2;
            ListMovieActors.WrapContents = false;
            ListMovieActors.Paint += ListMovieActors_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 59, 111);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(212, 27);
            panel3.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 4);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 0;
            label2.Text = "Oyuncular";
            // 
            // ListMovieRatings
            // 
            ListMovieRatings.Controls.Add(panel4);
            ListMovieRatings.Controls.Add(ListRatingCheck);
            ListMovieRatings.Location = new Point(439, 3);
            ListMovieRatings.Name = "ListMovieRatings";
            ListMovieRatings.Size = new Size(200, 267);
            ListMovieRatings.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 59, 111);
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(197, 27);
            panel4.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 4);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 0;
            label3.Text = "Sınıflandırma";
            // 
            // ListRatingCheck
            // 
            ListRatingCheck.Enabled = false;
            ListRatingCheck.FormattingEnabled = true;
            ListRatingCheck.Location = new Point(3, 36);
            ListRatingCheck.Name = "ListRatingCheck";
            ListRatingCheck.Size = new Size(197, 220);
            ListRatingCheck.TabIndex = 2;
            // 
            // ListMovieDirector
            // 
            ListMovieDirector.BorderStyle = BorderStyle.FixedSingle;
            ListMovieDirector.Controls.Add(ListDirectorName);
            ListMovieDirector.Controls.Add(label1);
            ListMovieDirector.Controls.Add(ListDirectorImg);
            ListMovieDirector.Location = new Point(3, 276);
            ListMovieDirector.Name = "ListMovieDirector";
            ListMovieDirector.Size = new Size(303, 75);
            ListMovieDirector.TabIndex = 3;
            // 
            // ListDirectorName
            // 
            ListDirectorName.AutoSize = true;
            ListDirectorName.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ListDirectorName.Location = new Point(76, 34);
            ListDirectorName.Name = "ListDirectorName";
            ListDirectorName.Size = new Size(46, 20);
            ListDirectorName.TabIndex = 2;
            ListDirectorName.Text = "label4";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(76, 14);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 1;
            label1.Text = "Yönetmen";
            // 
            // ListDirectorImg
            // 
            ListDirectorImg.Dock = DockStyle.Left;
            ListDirectorImg.Location = new Point(0, 0);
            ListDirectorImg.Name = "ListDirectorImg";
            ListDirectorImg.Size = new Size(70, 73);
            ListDirectorImg.SizeMode = PictureBoxSizeMode.Zoom;
            ListDirectorImg.TabIndex = 0;
            ListDirectorImg.TabStop = false;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(ListMovieDate);
            panel6.Controls.Add(label5);
            panel6.Location = new Point(312, 276);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 75);
            panel6.TabIndex = 5;
            // 
            // ListMovieDate
            // 
            ListMovieDate.Dock = DockStyle.Bottom;
            ListMovieDate.Enabled = false;
            ListMovieDate.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            ListMovieDate.Location = new Point(0, 44);
            ListMovieDate.Name = "ListMovieDate";
            ListMovieDate.Size = new Size(198, 29);
            ListMovieDate.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(38, 10);
            label5.Name = "label5";
            label5.Size = new Size(123, 25);
            label5.TabIndex = 1;
            label5.Text = "Vizyon Tarihi";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.WhiteSmoke;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(519, 276);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(58, 75);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // edit
            // 
            edit.BackColor = Color.WhiteSmoke;
            edit.Image = (Image)resources.GetObject("edit.Image");
            edit.Location = new Point(585, 276);
            edit.Margin = new Padding(4, 3, 4, 3);
            edit.Name = "edit";
            edit.Size = new Size(55, 74);
            edit.SizeMode = PictureBoxSizeMode.Zoom;
            edit.TabIndex = 8;
            edit.TabStop = false;
            // 
            // panel7
            // 
            panel7.Controls.Add(ListMovieSum);
            panel7.Controls.Add(panel9);
            panel7.Location = new Point(3, 357);
            panel7.Name = "panel7";
            panel7.Size = new Size(303, 254);
            panel7.TabIndex = 6;
            // 
            // ListMovieSum
            // 
            ListMovieSum.Dock = DockStyle.Fill;
            ListMovieSum.Enabled = false;
            ListMovieSum.Location = new Point(0, 27);
            ListMovieSum.Multiline = true;
            ListMovieSum.Name = "ListMovieSum";
            ListMovieSum.Size = new Size(303, 227);
            ListMovieSum.TabIndex = 2;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(0, 59, 111);
            panel9.Controls.Add(label6);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(303, 27);
            panel9.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 4);
            label6.Name = "label6";
            label6.Size = new Size(102, 20);
            label6.TabIndex = 0;
            label6.Text = "Film Açıklaması";
            // 
            // panel8
            // 
            panel8.Controls.Add(ListMovieGenre);
            panel8.Controls.Add(panel10);
            panel8.Location = new Point(312, 357);
            panel8.Name = "panel8";
            panel8.Size = new Size(195, 254);
            panel8.TabIndex = 7;
            // 
            // ListMovieGenre
            // 
            ListMovieGenre.Dock = DockStyle.Top;
            ListMovieGenre.Enabled = false;
            ListMovieGenre.FormattingEnabled = true;
            ListMovieGenre.Location = new Point(0, 27);
            ListMovieGenre.Name = "ListMovieGenre";
            ListMovieGenre.Size = new Size(195, 220);
            ListMovieGenre.TabIndex = 3;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(0, 59, 111);
            panel10.Controls.Add(label7);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(195, 27);
            panel10.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 4);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 0;
            label7.Text = "Film Türleri";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(ListMovieRate);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(513, 357);
            panel5.Name = "panel5";
            panel5.Size = new Size(127, 75);
            panel5.TabIndex = 4;
            // 
            // ListMovieRate
            // 
            ListMovieRate.Dock = DockStyle.Bottom;
            ListMovieRate.Enabled = false;
            ListMovieRate.Font = new Font("Arial", 14.25F, FontStyle.Bold);
            ListMovieRate.Location = new Point(0, 44);
            ListMovieRate.Name = "ListMovieRate";
            ListMovieRate.Size = new Size(125, 29);
            ListMovieRate.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 16);
            label4.Name = "label4";
            label4.Size = new Size(113, 25);
            label4.TabIndex = 0;
            label4.Text = "IMDB PUANI";
            // 
            // MovieListControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(ListMoviePanel);
            Controls.Add(panel1);
            Name = "MovieListControl";
            Size = new Size(656, 654);
            Load += MovieListControl_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ListMoviePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ListMovieImg).EndInit();
            ListMovieActors.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ListMovieRatings.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ListMovieDirector.ResumeLayout(false);
            ListMovieDirector.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ListDirectorImg).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)edit).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ListMovieRate).EndInit();
            ResumeLayout(false);
        }

        #endregion
        public FlowLayoutPanel ListMoviePanel;
        public Panel panel1;
        public Label ListMovieName;
        public PictureBox ListMovieImg;
        public FlowLayoutPanel ListMovieActors;
        public FlowLayoutPanel ListMovieRatings;
        public Panel panel3;
        public Label label2;
        public Panel panel4;
        public Label label3;
        public Panel ListMovieDirector;
        public Label ListDirectorName;
        public Label label1;
        public PictureBox ListDirectorImg;
        public Panel panel5;
        public Label label4;
        public NumericUpDown ListMovieRate;
        public Panel panel6;
        public DateTimePicker ListMovieDate;
        public Label label5;
        public Panel panel7;
        public Panel panel9;
        public Label label6;
        public Panel panel8;
        public Panel panel10;
        public Label label7;
        public CheckedListBox ListRatingCheck;
        public TextBox ListMovieSum;
        public CheckedListBox ListMovieGenre;
        public PictureBox pictureBox2;
        public PictureBox edit;
        public Label ListMovieID;
    }
}
