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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.min_button = new System.Windows.Forms.Button();
            this.ex_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.psw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(111)))));
            this.panel1.Controls.Add(this.min_button);
            this.panel1.Controls.Add(this.ex_button);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 40);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // min_button
            // 
            this.min_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(147)))));
            this.min_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.min_button.FlatAppearance.BorderSize = 0;
            this.min_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.min_button.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.min_button.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.min_button.Location = new System.Drawing.Point(301, -13);
            this.min_button.Name = "min_button";
            this.min_button.Size = new System.Drawing.Size(45, 53);
            this.min_button.TabIndex = 2;
            this.min_button.Text = "-";
            this.min_button.UseVisualStyleBackColor = false;
            this.min_button.Click += new System.EventHandler(this.min_button_Click);
            // 
            // ex_button
            // 
            this.ex_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(54)))), ((int)(((byte)(22)))));
            this.ex_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ex_button.FlatAppearance.BorderSize = 0;
            this.ex_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ex_button.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ex_button.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.ex_button.Location = new System.Drawing.Point(346, 0);
            this.ex_button.Name = "ex_button";
            this.ex_button.Size = new System.Drawing.Size(40, 40);
            this.ex_button.TabIndex = 1;
            this.ex_button.Text = "X";
            this.ex_button.UseVisualStyleBackColor = false;
            this.ex_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Achi Cinema";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(124, 78);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(229, 20);
            this.user.TabIndex = 1;
            this.user.TextChanged += new System.EventHandler(this.user_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // psw
            // 
            this.psw.Location = new System.Drawing.Point(124, 137);
            this.psw.Name = "psw";
            this.psw.Size = new System.Drawing.Size(229, 20);
            this.psw.TabIndex = 3;
            this.psw.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kullanıcı Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.label3.Location = new System.Drawing.Point(58, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Parola";
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(111)))));
            this.login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login.FlatAppearance.BorderSize = 0;
            this.login.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.login.Location = new System.Drawing.Point(124, 172);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(140, 45);
            this.login.TabIndex = 6;
            this.login.Text = "GİRİŞ YAP";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Sinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 285);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.psw);
            this.Controls.Add(this.user);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "Sinema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ex_button;
        private System.Windows.Forms.Button min_button;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox psw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button login;
    }
}

