using Achi_Sinema.Classes;
using Achi_Sinema.Tables;
using Sinema_Otomasyonu.Forms.Actor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Otomasyonu.UserControls
{
    public partial class ActorListControl : UserControl
    {
        public ActorListControl()
        {
            InitializeComponent();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            ActorUpdate AU = new ActorUpdate();

            using (var ac = new AchiDbContext(AchiDbContext.Options))
            {
                int Actor_ID = int.Parse(ID.Text);

                var Actor_Edit = ac.Actors
                    .FirstOrDefault(a => a.ActorID == Actor_ID);

                AU.r_id.Text = Actor_Edit.ActorID.ToString();
                AU.r_name.Text = Actor_Edit.ActorName.ToString();
                AU.r_surname.Text = Actor_Edit.ActorSurname.ToString();
                AU.r_gender = Actor_Edit.ActorGender;
                AU.r_date.Value = Actor_Edit.ActorBirthDate;
                AU.r_bio.Text = Actor_Edit.ActorBiography.ToString();
                AU.r_img.ImageLocation = Actor_Edit.ActorImage.ToString();

            }

            MainPage mp = new MainPage();
            Functions.ShowFormCentered(AU, mp.panel1, mp.panel2, mp.panel3);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OYUNCU SİLMEK ÜZERESİNİZ BU İŞLEMİN GERİ DÖNÜŞÜ YOKTUR !", "OYUNCU SİLME İŞLEMİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            DialogResult result = MessageBox.Show("Silmek İstedğinizden Emin Misiniz ?", "OYUNCU SİLME İŞLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


            if (result == DialogResult.Yes)
            {

                using (var ac = new AchiDbContext(AchiDbContext.Options))
                {
                    int Actor_ID = int.Parse(ID.Text);

                    var Actor_Delete = ac.Actors.FirstOrDefault(a => a.ActorID == Actor_ID);
                    MessageBox.Show(Actor_Delete.ActorImage);
                    File.Delete(Actor_Delete.ActorImage);

                    ac.Remove(Actor_Delete);
                    ac.SaveChanges();


                }
                

                
                MessageBox.Show("OYUNCU BAŞARIYLA SİLİNDİ", "OYUNCU SİLME İŞLEMİ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Hide();

            }

            else if (result == DialogResult.No)
            {
                MessageBox.Show("OYUNCU SİLME İŞLEMİ İPTAL EDİLDİ", "OYUNCU SİLME İŞLEMİ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}
