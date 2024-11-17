﻿using Achi_Sinema.Forms.Movie;
using Sinema_Otomasyonu.Forms.Actor;
using Sinema_Otomasyonu.Forms.Movie;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sinema_Otomasyonu
{
    public partial class MainPage : Form
    {
        public static string name;
        public static string surname;
        public MainPage()
        {
            InitializeComponent();
        }

        private void ex_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void min_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            label2.Text = "Hoş Geldin " + name + " " + surname.ToUpper();
        }

        public void adminreg_Click(object sender, EventArgs e)
        {
            DirectorReg DrcReg = new DirectorReg();

            Functions.ShowFormCentered(DrcReg, panel1, panel2, panel3);

        }

        private void adminreg_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void DrcList_Click(object sender, EventArgs e)
        {
            DirectorList DrcList = new DirectorList();
            Functions.ShowFormCentered(DrcList, panel1, panel2, panel3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActorReg ActReg = new ActorReg();
            Functions.ShowFormCentered(ActReg, panel1, panel2, panel3);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Act_List_Click(object sender, EventArgs e)
        {
            ActorList ActList = new ActorList();
            Functions.ShowFormCentered(ActList, panel1, panel2, panel3);

        }

        private void Saloon_Reg_Click(object sender, EventArgs e)
        {
            // SaloonReg SalReg = new SaloonReg();
            //Functions.ShowFormCentered(SalReg, panel1, panel2, panel3);
        }

        private void movie_reg_Click(object sender, EventArgs e)
        {
            MovieReg movieReg = new MovieReg();
            Functions.ShowFormCentered(movieReg, panel1, panel2, panel3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MovieList movieList = new MovieList();
            Functions.ShowFormCentered(movieList, panel1, panel2, panel3);
        }
    }
}
