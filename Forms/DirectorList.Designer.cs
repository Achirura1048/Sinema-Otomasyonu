namespace Sinema_Otomasyonu
{
    partial class DirectorList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ex_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(111)))));
            this.panel1.Controls.Add(this.search);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ex_button);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1159, 79);
            this.panel1.TabIndex = 3;
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
            this.ex_button.Location = new System.Drawing.Point(1119, 0);
            this.ex_button.Name = "ex_button";
            this.ex_button.Size = new System.Drawing.Size(40, 79);
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
            this.label1.Size = new System.Drawing.Size(261, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "[YÖNETMEN LİSTESİ]";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ListPanel
            // 
            this.ListPanel.AutoScroll = true;
            this.ListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ListPanel.Location = new System.Drawing.Point(0, 79);
            this.ListPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ListPanel.Name = "ListPanel";
            this.ListPanel.Size = new System.Drawing.Size(1159, 603);
            this.ListPanel.TabIndex = 4;
            this.ListPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ListPanel_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "İsim",
            "Cinsiyet (Erkek - Kadın)",
            "Cinsiyet (Kadın - Erkek)",
            "Yaş (Büyükten Küçüğe)",
            "Yaş (Küçükten Büyüğe)"});
            this.comboBox1.Location = new System.Drawing.Point(350, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(183, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(284, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sırala";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ara";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(59, 51);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(154, 20);
            this.search.TabIndex = 5;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // DirectorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 682);
            this.Controls.Add(this.ListPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DirectorList";
            this.Text = "DirectorList";
            this.Load += new System.EventHandler(this.DirectorList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ex_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel ListPanel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label3;
    }
}