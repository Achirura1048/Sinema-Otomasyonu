namespace Sinema_Otomasyonu
{
    partial class test
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
            this.ui_panel1 = new System.Windows.Forms.Panel();
            this.default_color = new System.Windows.Forms.Button();
            this.set_color = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ui_panel1
            // 
            this.ui_panel1.Location = new System.Drawing.Point(143, 24);
            this.ui_panel1.Name = "ui_panel1";
            this.ui_panel1.Size = new System.Drawing.Size(426, 100);
            this.ui_panel1.TabIndex = 0;
            // 
            // default_color
            // 
            this.default_color.Location = new System.Drawing.Point(180, 208);
            this.default_color.Name = "default_color";
            this.default_color.Size = new System.Drawing.Size(75, 23);
            this.default_color.TabIndex = 1;
            this.default_color.Text = "button1";
            this.default_color.UseVisualStyleBackColor = true;
            // 
            // set_color
            // 
            this.set_color.Location = new System.Drawing.Point(454, 208);
            this.set_color.Name = "set_color";
            this.set_color.Size = new System.Drawing.Size(75, 23);
            this.set_color.TabIndex = 2;
            this.set_color.Text = "button1";
            this.set_color.UseVisualStyleBackColor = true;
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.set_color);
            this.Controls.Add(this.default_color);
            this.Controls.Add(this.ui_panel1);
            this.Name = "test";
            this.Text = "test";
            this.Load += new System.EventHandler(this.test_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ui_panel1;
        private System.Windows.Forms.Button default_color;
        private System.Windows.Forms.Button set_color;
    }
}