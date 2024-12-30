namespace Achi_Sinema.Forms.Ticket
{
    partial class TicketReg
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
            panel1 = new Panel();
            ex_button = new Button();
            label1 = new Label();
            r_save = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox1 = new GroupBox();
            movie_list_tk = new CheckedListBox();
            groupBox2 = new GroupBox();
            HourList = new CheckedListBox();
            vizyon_tk = new DateTimePicker();
            groupBox4 = new GroupBox();
            SaloonList = new CheckedListBox();
            groupBox3 = new GroupBox();
            SeatList = new CheckedListBox();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 59, 111);
            panel1.Controls.Add(ex_button);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1371, 46);
            panel1.TabIndex = 7;
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
            ex_button.Location = new Point(1324, 0);
            ex_button.Margin = new Padding(4, 3, 4, 3);
            ex_button.Name = "ex_button";
            ex_button.Size = new Size(47, 46);
            ex_button.TabIndex = 1;
            ex_button.Text = "X";
            ex_button.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(4, 7);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(206, 28);
            label1.TabIndex = 0;
            label1.Text = "[OYUNCU KAYIT]";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // r_save
            // 
            r_save.BackColor = Color.FromArgb(0, 59, 111);
            r_save.Dock = DockStyle.Bottom;
            r_save.FlatAppearance.BorderSize = 0;
            r_save.FlatStyle = FlatStyle.Flat;
            r_save.Font = new Font("Arial Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            r_save.ForeColor = Color.Snow;
            r_save.Location = new Point(0, 632);
            r_save.Margin = new Padding(4, 3, 4, 3);
            r_save.Name = "r_save";
            r_save.Size = new Size(1371, 55);
            r_save.TabIndex = 8;
            r_save.Text = "KAYDET";
            r_save.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(groupBox1);
            flowLayoutPanel1.Controls.Add(groupBox2);
            flowLayoutPanel1.Controls.Add(groupBox4);
            flowLayoutPanel1.Controls.Add(groupBox3);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 46);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1371, 586);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(movie_list_tk);
            groupBox1.Font = new Font("Arial", 12F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(0, 59, 111);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(320, 577);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Film";
            // 
            // movie_list_tk
            // 
            movie_list_tk.Dock = DockStyle.Fill;
            movie_list_tk.FormattingEnabled = true;
            movie_list_tk.Location = new Point(3, 22);
            movie_list_tk.Name = "movie_list_tk";
            movie_list_tk.Size = new Size(314, 552);
            movie_list_tk.TabIndex = 0;
            movie_list_tk.SelectedIndexChanged += movie_list_tk_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(HourList);
            groupBox2.Controls.Add(vizyon_tk);
            groupBox2.Font = new Font("Arial", 12F, FontStyle.Bold);
            groupBox2.ForeColor = Color.FromArgb(0, 59, 111);
            groupBox2.Location = new Point(329, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(260, 293);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Vizyon";
            // 
            // HourList
            // 
            HourList.Dock = DockStyle.Fill;
            HourList.FormattingEnabled = true;
            HourList.Location = new Point(3, 48);
            HourList.Name = "HourList";
            HourList.Size = new Size(254, 242);
            HourList.TabIndex = 1;
            // 
            // vizyon_tk
            // 
            vizyon_tk.CustomFormat = "dd-MM-yyyy";
            vizyon_tk.Dock = DockStyle.Top;
            vizyon_tk.Format = DateTimePickerFormat.Custom;
            vizyon_tk.Location = new Point(3, 22);
            vizyon_tk.Name = "vizyon_tk";
            vizyon_tk.Size = new Size(254, 26);
            vizyon_tk.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(SaloonList);
            groupBox4.Font = new Font("Arial", 12F, FontStyle.Bold);
            groupBox4.ForeColor = Color.FromArgb(0, 59, 111);
            groupBox4.Location = new Point(329, 302);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(260, 275);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Salon";
            // 
            // SaloonList
            // 
            SaloonList.Dock = DockStyle.Fill;
            SaloonList.FormattingEnabled = true;
            SaloonList.Location = new Point(3, 22);
            SaloonList.Name = "SaloonList";
            SaloonList.Size = new Size(254, 250);
            SaloonList.TabIndex = 0;
            SaloonList.SelectedIndexChanged += SaloonList_SelectedIndexChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(SeatList);
            groupBox3.Font = new Font("Arial", 12F, FontStyle.Bold);
            groupBox3.ForeColor = Color.FromArgb(0, 59, 111);
            groupBox3.Location = new Point(595, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(633, 583);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Koltuk";
            // 
            // SeatList
            // 
            SeatList.Dock = DockStyle.Fill;
            SeatList.FormattingEnabled = true;
            SeatList.Location = new Point(3, 22);
            SeatList.Name = "SeatList";
            SeatList.Size = new Size(627, 558);
            SeatList.TabIndex = 0;
            // 
            // TicketReg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 687);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(r_save);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TicketReg";
            Text = "TicketReg";
            Load += TicketReg_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button ex_button;
        private Label label1;
        private Button r_save;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBox1;
        private CheckedListBox movie_list_tk;
        private GroupBox groupBox2;
        private DateTimePicker vizyon_tk;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private CheckedListBox SaloonList;
        private CheckedListBox SeatList;
        private CheckedListBox HourList;
    }
}