namespace Sinema_Otomasyonu.UserControls
{
    partial class ActorListMovie
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.actor_name = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(111)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(39, 33);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.actor_name_Click);
            this.panel1.MouseLeave += new System.EventHandler(this.actor_name_MouseLeave);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.actor_name_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "+";
            // 
            // actor_name
            // 
            this.actor_name.AutoSize = true;
            this.actor_name.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actor_name.Location = new System.Drawing.Point(45, 7);
            this.actor_name.Name = "actor_name";
            this.actor_name.Size = new System.Drawing.Size(0, 20);
            this.actor_name.TabIndex = 1;
            this.actor_name.Click += new System.EventHandler(this.actor_name_Click);
            this.actor_name.MouseLeave += new System.EventHandler(this.actor_name_MouseLeave);
            this.actor_name.MouseMove += new System.Windows.Forms.MouseEventHandler(this.actor_name_MouseMove);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Dock = System.Windows.Forms.DockStyle.Right;
            this.ID.ForeColor = System.Drawing.SystemColors.Control;
            this.ID.Location = new System.Drawing.Point(228, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(0, 15);
            this.ID.TabIndex = 2;
            // 
            // ActorListMovie
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.ID);
            this.Controls.Add(this.actor_name);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ActorListMovie";
            this.Size = new System.Drawing.Size(228, 33);
            this.Load += new System.EventHandler(this.ActorListMovie_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label ID;
        public System.Windows.Forms.Label actor_name;
        private System.Windows.Forms.Label label1;
    }
}
