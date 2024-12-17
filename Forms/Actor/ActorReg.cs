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
using Microsoft.EntityFrameworkCore;
using Achi_Sinema.Classes;
using Achi_Sinema.Tables;

namespace Sinema_Otomasyonu.Forms.Actor
{
    public partial class ActorReg : Form
    {
        public ActorReg()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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


                string TargetDir = Path.Combine(LocalDir, Path.GetFileName(imgpath));
                File.Copy(imgpath, TargetDir, true);
                r_img.Image = Image.FromFile(TargetDir);


                using (var ac = new AchiDbContext(AchiDbContext.Options))
                {
                    Achi_Sinema.Tables.Actor newActor = new Achi_Sinema.Tables.Actor
                    {
                        ActorName = r_name.Text,
                        ActorSurname = r_surname.Text,
                        ActorGender = r_gender,
                        ActorBirthDate = r_date.Value,
                        ActorImage = TargetDir,
                        ActorBiography = r_bio.Text

                    };

                    ac.Actors.Add(newActor);
                    ac.SaveChanges();

                }

                MessageBox.Show("Oyuncu Kaydı Başarılı");
                r_name.Text = "";
                r_surname.Text = "";
                r_bio.Text = "";
                r_img.Image = null;
                error_bio.Text = "";
                error_img.Text = "";
                error_name.Text = "";
                error_surname.Text = "";
                r_name.Focus();



               


            }
        }

        private void r_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void ex_button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private string imgpath = null;

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

        public static string r_gender = "M";

        private void male_CheckedChanged(object sender, EventArgs e)
        {
            r_gender = "M";
        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {
            r_gender = "F";
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void ActorReg_Load(object sender, EventArgs e)
        {

        }
    }
}
