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
using System.Xml.Linq;
using System.IO;
using System.Security.Cryptography;
using Achi_Sinema.Classes;
using Achi_Sinema.Tables;
namespace Sinema_Otomasyonu
{
    public partial class DirectorUpdate : Form
    {
       
        public DirectorUpdate()
        {
            InitializeComponent();    
        }
        private void AdminReg_Load(object sender, EventArgs e)
        {

            

        }

        private void ex_button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void min_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private string imgpath;
        public string TargetDir;
        private void button1_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "RESİM SEÇME EKRANI";
            ofd.Filter = "Resim Dosyaları | *.jpg; *.jpeg; *.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {   
                 imgpath = ofd.FileName;

                r_img.Image = Image.FromFile(imgpath);

                
            }
        }

        private void rimg_Click(object sender, EventArgs e)
        {

        }

        private void r_img_Click(object sender, EventArgs e)
        {
            
        }
        public string r_gender = "M";
        public void male_CheckedChanged(object sender, EventArgs e)
        {
            r_gender = "M";
        }

        

        public void female_CheckedChanged(object sender, EventArgs e)
        {
            r_gender = "F";
        }




        private void button2_Click(object sender, EventArgs e)
        {
            if (r_name.Text == "" || r_surname.Text == "" || r_bio.Text == "" || r_img.ImageLocation == null)
            {

                System.Media.SystemSounds.Beep.Play();

                switch (r_name.Text)
                {

                    case "":
                        error_name.Text = "İsim Alanı Boş Bırakılamaz";
                        break;
                    case null:
                        error_name.Text = "İsim Alanı Boş Bırakılamaz";
                        break;
                }

                switch (r_surname.Text)
                {
                    case "":
                        error_surname.Text = "Soyisim Alanı Boş Bırakılamaz";
                        break;
                    case null:
                        error_surname.Text = "Soyisim Alanı Boş Bırakılamaz";
                        break;
                }

                switch (r_bio.Text)
                {
                    case "":
                        error_bio.Text = "Biyografi Alanı Boş Bırakılamaz";
                        break;
                    case null:
                        error_bio.Text = "Biyografi Alanı Boş Bırakılamaz";
                        break;
                }

                switch (r_img.Image)
                {
                    case null:
                        error_img.Text = "Resim Seçilmedi";
                        break;
                }
            }

            else
            {
                //if (!string.IsNullOrEmpty(imgpath))
                // {

                string Account_Name = Environment.UserName;
                string LocalDir = $@"C:\Users\{Account_Name}\AppData\Local\Achi Cinema\Director_Images";

                if (!Directory.Exists(LocalDir))
                {
                    Directory.CreateDirectory(LocalDir);

                    /*string ImgDir = Path.Combine(LocalDir, "Director_Images");

                    if (!Directory.Exists(ImgDir))
                    {
                        Directory.CreateDirectory(ImgDir);
                    }*/
                }





                using (var ac = new AchiDbContext(AchiDbContext.Options))
                {
                    int Director_ID = int.Parse(r_id.Text);
                    var Director_Update = ac.Directors
                    .FirstOrDefault(d => d.DirectorID == Director_ID);

                    if (imgpath == null)
                    {
                        TargetDir = Director_Update.DirectorImage;
                    }

                    else
                    {
                        TargetDir = Path.Combine(LocalDir, Path.GetFileName(imgpath));
                        File.Copy(imgpath, TargetDir, true);
                        r_img.Image = Image.FromFile(TargetDir);
                    }

                    Director_Update.DirectorName = r_name.Text;
                    Director_Update.DirectorSurname = r_surname.Text;
                    Director_Update.DirectorGender = r_gender;
                    Director_Update.DirectorBirthDate = r_date.Value;
                    Director_Update.DirectorImage = TargetDir;
                    Director_Update.DirectorImage = r_bio.Text;

                    ac.Update(Director_Update);
                    ac.SaveChanges();
                }

                MessageBox.Show("Yönetmen Güncellendi");

                this.Close();
                MainPage mp = new MainPage();
                DirectorList DrcList = new DirectorList();
                Functions.ShowFormCentered(DrcList , mp.panel1 , mp.panel2 , mp.panel3);




            }
        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void r_surname_TextChanged(object sender, EventArgs e)
        {

        }

        private void r_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_Enter(object sender, EventArgs e)
        {


        }

        private void textBox3_Leave(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void r_img_Click_1(object sender, EventArgs e)
        {

        }

        private void r_bio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
