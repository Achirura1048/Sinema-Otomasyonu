namespace Achi_Sinema.UserControls
{
    partial class MovieListActor
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
            panel1 = new Panel();
            MLActor = new PictureBox();
            MLActorName = new Label();
            ((System.ComponentModel.ISupportInitialize)MLActor).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 59, 111);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 75);
            panel1.TabIndex = 0;
            // 
            // MLActor
            // 
            MLActor.Dock = DockStyle.Left;
            MLActor.Location = new Point(10, 0);
            MLActor.Name = "MLActor";
            MLActor.Size = new Size(76, 75);
            MLActor.SizeMode = PictureBoxSizeMode.Zoom;
            MLActor.TabIndex = 1;
            MLActor.TabStop = false;
            // 
            // MLActorName
            // 
            MLActorName.AutoSize = true;
            MLActorName.Location = new Point(92, 28);
            MLActorName.Name = "MLActorName";
            MLActorName.Size = new Size(38, 15);
            MLActorName.TabIndex = 2;
            MLActorName.Text = "label1";
            // 
            // MovieListActor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MLActorName);
            Controls.Add(MLActor);
            Controls.Add(panel1);
            Name = "MovieListActor";
            Size = new Size(200, 75);
            ((System.ComponentModel.ISupportInitialize)MLActor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Panel panel1;
        public PictureBox MLActor;
        public Label MLActorName;
    }
}
