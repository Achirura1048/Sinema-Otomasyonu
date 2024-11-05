namespace Sinema_Otomasyonu.UserControls
{
    partial class SaloonListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaloonListControl));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ID = new System.Windows.Forms.Label();
            this.edit = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.r_scap = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.n_error = new System.Windows.Forms.Label();
            this.c_error = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.r_sname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(241, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(52, 2);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(0, 13);
            this.ID.TabIndex = 14;
            this.ID.Visible = false;
            // 
            // edit
            // 
            this.edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.edit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.edit.Image = ((System.Drawing.Image)(resources.GetObject("edit.Image")));
            this.edit.Location = new System.Drawing.Point(241, 16);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(50, 50);
            this.edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.edit.TabIndex = 13;
            this.edit.TabStop = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(111)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 142);
            this.panel1.TabIndex = 8;
            // 
            // r_scap
            // 
            this.r_scap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.r_scap.BackColor = System.Drawing.SystemColors.Control;
            this.r_scap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.r_scap.Enabled = false;
            this.r_scap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r_scap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(111)))));
            this.r_scap.Location = new System.Drawing.Point(17, 73);
            this.r_scap.Name = "r_scap";
            this.r_scap.Size = new System.Drawing.Size(122, 19);
            this.r_scap.TabIndex = 17;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(111)))));
            this.save.Enabled = false;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.Snow;
            this.save.Location = new System.Drawing.Point(160, 116);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 18;
            this.save.Text = "KAYDET";
            this.save.UseVisualStyleBackColor = false;
            this.save.Visible = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // n_error
            // 
            this.n_error.AutoSize = true;
            this.n_error.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_error.ForeColor = System.Drawing.Color.Red;
            this.n_error.Location = new System.Drawing.Point(17, 53);
            this.n_error.Name = "n_error";
            this.n_error.Size = new System.Drawing.Size(0, 16);
            this.n_error.TabIndex = 19;
            // 
            // c_error
            // 
            this.c_error.AutoSize = true;
            this.c_error.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_error.ForeColor = System.Drawing.Color.Red;
            this.c_error.Location = new System.Drawing.Point(17, 95);
            this.c_error.Name = "c_error";
            this.c_error.Size = new System.Drawing.Size(0, 16);
            this.c_error.TabIndex = 20;
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.Red;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.Color.Snow;
            this.cancel.Location = new System.Drawing.Point(79, 116);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 21;
            this.cancel.Text = "İPTAL";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Visible = false;
            this.cancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // r_sname
            // 
            this.r_sname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.r_sname.BackColor = System.Drawing.SystemColors.Control;
            this.r_sname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.r_sname.Enabled = false;
            this.r_sname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r_sname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(111)))));
            this.r_sname.Location = new System.Drawing.Point(20, 31);
            this.r_sname.Name = "r_sname";
            this.r_sname.Size = new System.Drawing.Size(122, 19);
            this.r_sname.TabIndex = 22;
            this.r_sname.TextChanged += new System.EventHandler(this.r_sname_TextChanged_1);
            // 
            // SaloonListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.r_sname);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.c_error);
            this.Controls.Add(this.n_error);
            this.Controls.Add(this.save);
            this.Controls.Add(this.r_scap);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.panel1);
            this.Name = "SaloonListControl";
            this.Size = new System.Drawing.Size(294, 142);
            this.Load += new System.EventHandler(this.SaloonListControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label ID;
        private System.Windows.Forms.PictureBox edit;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox r_scap;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label n_error;
        private System.Windows.Forms.Label c_error;
        private System.Windows.Forms.Button cancel;
        public System.Windows.Forms.TextBox r_sname;
    }
}
