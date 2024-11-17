using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.EntityFrameworkCore;
using Achi_Sinema.Tables;
using Achi_Sinema.Classes;

namespace Sinema_Otomasyonu
{
    public partial class Sinema : Form
    {
        


        public Sinema()
        {
            InitializeComponent();
        }
        
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void min_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           


        }

        private void button1_Click_1(object sender, EventArgs e)
        {


            using (var ac = new AchiDbContext(AchiDbContext.Options))
            {
                var user_info = ac.Users
                    .FirstOrDefault(u => u.StaffLogin == staff_login.Text && u.StaffPassword == staff_psw.Text);

                if (user_info != null)
                {
                    MainPage.name = user_info.StaffName;
                    MainPage.surname = user_info.StaffSurname;

                    MainPage mainpage = new MainPage();
                    var workingAreaWidth = Screen.PrimaryScreen.Bounds.Width;
                    var workingAreaHeight = Screen.PrimaryScreen.Bounds.Height;


                    mainpage.Size = new System.Drawing.Size(workingAreaWidth, workingAreaHeight);
                    mainpage.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
                }
            }
                    /*using (AchiDBContext ac = new AchiDBContext(Secrets.DB_Path))
                    {
                        var user_info = ac.Users
                            .FirstOrDefault(u => u.KADI == user.Text && u.KSIFRE == psw.Text);

                        if(user_info != null)
                        {
                            MainPage.name = user_info.AD;
                            MainPage.surname = user_info.SOYAD;


                            MainPage mainpage = new MainPage();
                            var workingAreaWidth = Screen.PrimaryScreen.Bounds.Width;
                            var workingAreaHeight = Screen.PrimaryScreen.Bounds.Height;


                            mainpage.Size = new System.Drawing.Size(workingAreaWidth, workingAreaHeight);
                            mainpage.Show();
                            this.Hide();
                        }

                        else
                        {
                            MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
                        }
                    }*/



                    staff_login.Focus();


            
        }

        private void user_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
