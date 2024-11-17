namespace Achi_Sinema.Forms.Movie
{
    partial class MovieList
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
            ListPanel = new FlowLayoutPanel();
            panel1 = new Panel();
            search = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            ex_button = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ListPanel
            // 
            ListPanel.AutoScroll = true;
            ListPanel.Dock = DockStyle.Fill;
            ListPanel.FlowDirection = FlowDirection.TopDown;
            ListPanel.Location = new Point(0, 91);
            ListPanel.Margin = new Padding(0);
            ListPanel.Name = "ListPanel";
            ListPanel.Size = new Size(1352, 696);
            ListPanel.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 59, 111);
            panel1.Controls.Add(search);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(ex_button);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1352, 91);
            panel1.TabIndex = 7;
            // 
            // search
            // 
            search.Location = new Point(69, 59);
            search.Margin = new Padding(4, 3, 4, 3);
            search.Name = "search";
            search.Size = new Size(179, 23);
            search.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(14, 52);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(41, 25);
            label3.TabIndex = 4;
            label3.Text = "Ara";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "İsim", "Cinsiyet (Erkek - Kadın)", "Cinsiyet (Kadın - Erkek)", "Yaş (Büyükten Küçüğe)", "Yaş (Küçükten Büyüğe)" });
            comboBox1.Location = new Point(408, 57);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(213, 23);
            comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(331, 52);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 2;
            label2.Text = "Sırala";
            label2.TextAlign = ContentAlignment.MiddleLeft;
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
            ex_button.Location = new Point(1305, 0);
            ex_button.Margin = new Padding(4, 3, 4, 3);
            ex_button.Name = "ex_button";
            ex_button.Size = new Size(47, 91);
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
            label1.Size = new Size(181, 28);
            label1.TabIndex = 0;
            label1.Text = "[FİLM LİSTESİ]";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MovieList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1352, 787);
            Controls.Add(ListPanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MovieList";
            Text = "MovieList";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel ListPanel;
        private Panel panel1;
        private TextBox search;
        private Label label3;
        private ComboBox comboBox1;
        private Label label2;
        private Button ex_button;
        private Label label1;
    }
}