using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Sinema_Otomasyonu.Classes;

namespace Sinema_Otomasyonu.Forms.Actor
{
    public partial class ActorUpdate : Form
    {
        public ActorUpdate()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ex_button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private string imgpath;
        public string TargetDir;

        private void img_up_Click(object sender, EventArgs e)
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

        private void r_save_Click(object sender, EventArgs e)
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
                string LocalDir = $@"C:\Users\{Account_Name}\AppData\Local\Achi Cinema\Actor_Images";

                if (!Directory.Exists(LocalDir))
                {
                    Directory.CreateDirectory(LocalDir);

                    /*string ImgDir = Path.Combine(LocalDir, "Director_Images");

                    if (!Directory.Exists(ImgDir))
                    {
                        Directory.CreateDirectory(ImgDir);
                    }*/
                }

                using (AchiDBContext ac = new AchiDBContext(Secrets.DB_Path))
                {

                

                

                
                    int Actor_ID = int.Parse(r_id.Text);
                    var Actor_Update = ac.Actors
                    .FirstOrDefault(d => d.ID == Actor_ID);

                    if(imgpath == null)
                    {
                        TargetDir = Actor_Update.RESIM;
                    }

                    else
                    {
                        TargetDir = Path.Combine(LocalDir, Path.GetFileName(imgpath));
                        File.Copy(imgpath, TargetDir, true);
                        r_img.Image = Image.FromFile(TargetDir);
                    }


                    Actor_Update.AD = r_name.Text;
                    Actor_Update.SOYAD = r_surname.Text;
                    Actor_Update.CINSIYET = r_gender;
                    Actor_Update.DOGUM = r_date.Value;
                    Actor_Update.RESIM = TargetDir;
                    Actor_Update.BIO = r_bio.Text;

                    ac.SubmitChanges();
                }

                MessageBox.Show("Yönetmen Güncellendi");

                this.Close();
                MainPage mp = new MainPage();
                ActorList ActList = new ActorList();
                Functions.ShowFormCentered(ActList, mp.panel1, mp.panel2, mp.panel3);




            }
        }

        public char r_gender = 'M';
        private void male_CheckedChanged(object sender, EventArgs e)
        {
            r_gender = 'M';
        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {
            r_gender = 'F';
        }
    }
}
