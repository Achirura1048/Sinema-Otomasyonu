namespace Sinema_Otomasyonu.Forms.Saloon
{
    partial class SaloonReg
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.r_cnum = new System.Windows.Forms.TextBox();
            this.r_save = new System.Windows.Forms.Button();
            this.error_cNum = new System.Windows.Forms.Label();
            this.error_saloonName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.r_saloonName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SaloonListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.search = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.TabIndex = 2;
            // 
            // ex_button
            // 
            this.ex_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(54)))), ((int)(((byte)(22)))));
            this.ex_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ex_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.ex_button.FlatAppearance.BorderSize = 0;
            this.ex_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ex_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
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
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(238)))), ((int)(((byte)(244)))));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = " [SALON KAYIT]";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.r_cnum);
            this.groupBox1.Controls.Add(this.r_save);
            this.groupBox1.Controls.Add(this.error_cNum);
            this.groupBox1.Controls.Add(this.error_saloonName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.r_saloonName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(111)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1175, 209);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // r_cnum
            // 
            this.r_cnum.Location = new System.Drawing.Point(344, 56);
            this.r_cnum.Name = "r_cnum";
            this.r_cnum.Size = new System.Drawing.Size(204, 32);
            this.r_cnum.TabIndex = 26;
            // 
            // r_save
            // 
            this.r_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(111)))));
            this.r_save.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.r_save.FlatAppearance.BorderSize = 0;
            this.r_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.r_save.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.r_save.ForeColor = System.Drawing.Color.Snow;
            this.r_save.Location = new System.Drawing.Point(3, 142);
            this.r_save.Name = "r_save";
            this.r_save.Size = new System.Drawing.Size(1169, 64);
            this.r_save.TabIndex = 25;
            this.r_save.Text = "KAYDET";
            this.r_save.UseVisualStyleBackColor = false;
            this.r_save.Click += new System.EventHandler(this.r_save_Click);
            // 
            // error_cNum
            // 
            this.error_cNum.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.error_cNum.ForeColor = System.Drawing.Color.Red;
            this.error_cNum.Location = new System.Drawing.Point(342, 100);
            this.error_cNum.Name = "error_cNum";
            this.error_cNum.Size = new System.Drawing.Size(208, 30);
            this.error_cNum.TabIndex = 23;
            // 
            // error_saloonName
            // 
            this.error_saloonName.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.error_saloonName.ForeColor = System.Drawing.Color.Red;
            this.error_saloonName.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.error_saloonName.Location = new System.Drawing.Point(82, 100);
            this.error_saloonName.Name = "error_saloonName";
            this.error_saloonName.Size = new System.Drawing.Size(208, 30);
            this.error_saloonName.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Koltuk Sayısı";
            // 
            // r_saloonName
            // 
            this.r_saloonName.Location = new System.Drawing.Point(86, 56);
            this.r_saloonName.Name = "r_saloonName";
            this.r_saloonName.Size = new System.Drawing.Size(204, 32);
            this.r_saloonName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Salon Adı";
            // 
            // SaloonListPanel
            // 
            this.SaloonListPanel.AutoScroll = true;
            this.SaloonListPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SaloonListPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.SaloonListPanel.Location = new System.Drawing.Point(0, 249);
            this.SaloonListPanel.Name = "SaloonListPanel";
            this.SaloonListPanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.SaloonListPanel.Size = new System.Drawing.Size(1175, 472);
            this.SaloonListPanel.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(111)))));
            this.panel2.Controls.Add(this.search);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 249);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1175, 31);
            this.panel2.TabIndex = 6;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(42, 6);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(154, 20);
            this.search.TabIndex = 9;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ara";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "İsim",
            "Kapasite(Büyükten - Küçüğe)",
            "Kapasite(Küçükten - Büyüğe)"});
            this.comboBox1.Location = new System.Drawing.Point(301, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(183, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(235, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Sırala";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SaloonReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 721);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SaloonListPanel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaloonReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SaloonReg";
            this.Load += new System.EventHandler(this.SaloonReg_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ex_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label error_cNum;
        private System.Windows.Forms.Label error_saloonName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button r_save;
        public System.Windows.Forms.FlowLayoutPanel SaloonListPanel;
        public System.Windows.Forms.TextBox r_saloonName;
        public System.Windows.Forms.TextBox r_cnum;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
    }
}