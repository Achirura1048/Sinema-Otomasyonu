using Sinema_Otomasyonu.Classes;
using Sinema_Otomasyonu.Forms.Saloon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Otomasyonu.UserControls
{
    public partial class SaloonListControl : UserControl
    {
        public SaloonListControl()
        {
            InitializeComponent();
        }

        private void SaloonListControl_Load(object sender, EventArgs e)
        {

            

        }

        private void edit_Click(object sender, EventArgs e)
        {

            save.Show();
            cancel.Show();

            using (AchiDBContext ac = new AchiDBContext(Secrets.DB_Path))
            {
                var Saloon_Edit = ac.Saloons
                    .FirstOrDefault(s => s.ID == int.Parse(ID.Text));


                r_sname.Text = Saloon_Edit.SALONADI.ToString();
                r_scap.Text = Saloon_Edit.KOLTUKSAYISI.ToString();

                r_sname.Enabled = true;
                r_scap.Enabled = true;
                save.Enabled = true;
                
                


            }
        }

        private void save_Click(object sender, EventArgs e)
        {

            if (r_sname.Text == "" || r_scap.Text == "")
            {
                System.Media.SystemSounds.Beep.Play();

                switch (r_sname.Text)
                {
                    case "":
                       n_error.Text = "Salon Adı Alanı Boş Bırakılamaz";
                        break;
                    case null:
                        n_error.Text = "Salon Adı Alanı Boş Bırakılamaz";
                        break;
                }

                switch (r_scap.Text)
                {
                    case "":
                        c_error.Text = "Kapasite Alanı Boş Bırakılamaz";
                        break;
                    case null:
                        c_error.Text = "Kapasite Alanı Boş Bırakılamaz";
                        break;
                }

            }
            else
            {
                using (AchiDBContext ac = new AchiDBContext(Secrets.DB_Path))
                {
                    var Saloon_Edit = ac.Saloons
                        .FirstOrDefault(s => s.ID == int.Parse(ID.Text));

                    Saloon_Edit.SALONADI = r_sname.Text;
                    Saloon_Edit.KOLTUKSAYISI = int.Parse(r_scap.Text);
                    
                    ac.SubmitChanges();

                    MessageBox.Show("Salon Başarıyla Güncellendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    save.Hide();
                    cancel.Hide();
                    r_sname.Enabled = false;
                    r_scap.Enabled = false;
                    r_sname.Focus();

                }
            }
        }

        private void r_sname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            save.Hide();
            cancel.Hide();
            r_sname.Enabled = false;
            r_scap.Enabled = false;
            r_sname.Focus();
        }

        private void r_sname_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Silmek İstedğinizden Emin Misiniz ?", "SALON SİLME İŞLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


            if (result == DialogResult.Yes)
            {

                using (AchiDBContext ac = new AchiDBContext(Secrets.DB_Path))
                {
                    int Saloon_ID = int.Parse(ID.Text);

                    var Saloon_Delete = ac.Saloons.FirstOrDefault(a => a.ID == Saloon_ID);

                    ac.Saloons.DeleteOnSubmit(Saloon_Delete);

                    ac.SubmitChanges();


                }



                MessageBox.Show("SALON BAŞARIYLA SİLİNDİ", "SALON SİLME İŞLEMİ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Hide();

            }

            else if (result == DialogResult.No)
            {
                MessageBox.Show("SALON SİLME İŞLEMİ İPTAL EDİLDİ", "SALON SİLME İŞLEMİ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}
