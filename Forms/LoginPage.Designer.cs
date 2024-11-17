namespace Sinema_Otomasyonu
{
    partial class Sinema
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            min_button = new Button();
            ex_button = new Button();
            label1 = new Label();
            staff_login = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            staff_psw = new TextBox();
            label2 = new Label();
            label3 = new Label();
            login = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 59, 111);
            panel1.Controls.Add(min_button);
            panel1.Controls.Add(ex_button);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 46);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // min_button
            // 
            min_button.BackColor = Color.FromArgb(113, 128, 147);
            min_button.Cursor = Cursors.Hand;
            min_button.FlatAppearance.BorderSize = 0;
            min_button.FlatStyle = FlatStyle.Flat;
            min_button.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point, 162);
            min_button.ForeColor = SystemColors.InactiveBorder;
            min_button.Location = new Point(351, -15);
            min_button.Margin = new Padding(4, 3, 4, 3);
            min_button.Name = "min_button";
            min_button.Size = new Size(52, 61);
            min_button.TabIndex = 2;
            min_button.Text = "-";
            min_button.UseVisualStyleBackColor = false;
            min_button.Click += min_button_Click;
            // 
            // ex_button
            // 
            ex_button.BackColor = Color.FromArgb(194, 54, 22);
            ex_button.Cursor = Cursors.Hand;
            ex_button.FlatAppearance.BorderSize = 0;
            ex_button.FlatStyle = FlatStyle.Flat;
            ex_button.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ex_button.ForeColor = SystemColors.InactiveBorder;
            ex_button.Location = new Point(404, 0);
            ex_button.Margin = new Padding(4, 3, 4, 3);
            ex_button.Name = "ex_button";
            ex_button.Size = new Size(47, 46);
            ex_button.TabIndex = 1;
            ex_button.Text = "X";
            ex_button.UseVisualStyleBackColor = false;
            ex_button.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(4, 7);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(156, 28);
            label1.TabIndex = 0;
            label1.Text = "Achi Cinema";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // staff_login
            // 
            staff_login.Location = new Point(145, 90);
            staff_login.Margin = new Padding(4, 3, 4, 3);
            staff_login.Name = "staff_login";
            staff_login.Size = new Size(266, 23);
            staff_login.TabIndex = 1;
            staff_login.TextChanged += user_TextChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // staff_psw
            // 
            staff_psw.Location = new Point(145, 158);
            staff_psw.Margin = new Padding(4, 3, 4, 3);
            staff_psw.Name = "staff_psw";
            staff_psw.Size = new Size(266, 23);
            staff_psw.TabIndex = 3;
            staff_psw.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(39, 60, 117);
            label2.Location = new Point(14, 89);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 18);
            label2.TabIndex = 4;
            label2.Text = "Kullanıcı Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(39, 60, 117);
            label3.Location = new Point(68, 157);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 18);
            label3.TabIndex = 5;
            label3.Text = "Parola";
            // 
            // login
            // 
            login.BackColor = Color.FromArgb(0, 59, 111);
            login.Cursor = Cursors.Hand;
            login.FlatAppearance.BorderSize = 0;
            login.Font = new Font("Arial Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login.ForeColor = Color.FromArgb(0, 151, 230);
            login.Location = new Point(145, 198);
            login.Margin = new Padding(4, 3, 4, 3);
            login.Name = "login";
            login.Size = new Size(163, 52);
            login.TabIndex = 6;
            login.Text = "GİRİŞ YAP";
            login.UseVisualStyleBackColor = false;
            login.Click += button1_Click_1;
            // 
            // Sinema
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 329);
            Controls.Add(login);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(staff_psw);
            Controls.Add(staff_login);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            HelpButton = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Sinema";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ex_button;
        private System.Windows.Forms.Button min_button;
        private System.Windows.Forms.TextBox staff_login;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox staff_psw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button login;
    }
}

