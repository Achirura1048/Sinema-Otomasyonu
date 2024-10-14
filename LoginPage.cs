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
namespace Sinema_Otomasyonu
{
    public partial class Sinema : Form
    {

        

        public Sinema()
        {
            InitializeComponent();
        }
        
        SqlConnection connection = new SqlConnection(Secrets.DB_Path);

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
             connection.Open();
             SqlCommand sorgula = new SqlCommand("select KADI,KSIFRE,AD,SOYAD from User_Info WHERE KADI=@usr AND KSIFRE=@psw",connection);
             sorgula.Parameters.AddWithValue("@usr", user.Text);
             sorgula.Parameters.AddWithValue("@psw", psw.Text);
             
            SqlDataReader rd = sorgula.ExecuteReader();
            
            if (rd.Read())
            {
                MainPage mainPage = new MainPage();
                MainPage.name = rd["AD"].ToString();
                MainPage.surname = rd["SOYAD"].ToString();


                var workingAreaWidth = Screen.PrimaryScreen.Bounds.Width;
                var workingAreaHeight = Screen.PrimaryScreen.Bounds.Height;


                mainPage.Size = new System.Drawing.Size(workingAreaWidth, workingAreaHeight);

                mainPage.Show();



                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı");
                psw.Text = "";
            }
            


            user.Focus();


            connection.Close();
        }

    }
}
