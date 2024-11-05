using Sinema_Otomasyonu.Classes.Tables;
using Sinema_Otomasyonu.Classes;
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
using Sinema_Otomasyonu.UserControls;

namespace Sinema_Otomasyonu.Forms.Saloon
{
    public partial class SaloonReg : Form
    {
        public SaloonReg()
        {
            InitializeComponent();
        }

        private void ex_button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void r_save_Click(object sender, EventArgs e)
        {
            if (r_saloonName.Text == "" || r_cnum.Text == "")
            {
                System.Media.SystemSounds.Beep.Play();

                switch (r_saloonName.Text)
                {
                    case "":
                        error_saloonName.Text = "Salon Adı Alanı Boş Bırakılamaz";
                        break;
                    case null:
                        error_saloonName.Text = "Salon Adı Alanı Boş Bırakılamaz";
                        break;
                }

                switch (r_cnum.Text)
                {
                    case "":
                        error_cNum.Text = "Kapasite Alanı Boş Bırakılamaz";
                        break;
                    case null:
                        error_cNum.Text = "Kapasite Alanı Boş Bırakılamaz";
                        break;
                }

            }
            else
            {

                using (AchiDBContext ac = new AchiDBContext(Secrets.DB_Path))
                {
                    Saloons newSaloon = new Saloons()
                    {
                        SALONADI = r_saloonName.Text,
                        KOLTUKSAYISI = Convert.ToInt32(r_cnum.Text)
                    };

                    ac.GetTable<Saloons>().InsertOnSubmit(newSaloon);
                    ac.SubmitChanges();
                }

                MessageBox.Show("Salon Başarıyla Eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                r_saloonName.Text = "";
                r_cnum.Text = "";
                r_saloonName.Focus();

                using (AchiDBContext ac = new AchiDBContext(Secrets.DB_Path))
                {
                    SaloonListPanel.Controls.Clear();
                    foreach (var saloon in ac.Saloons.ToList())
                    {
                        SaloonListControl tool = new SaloonListControl();

                        tool.ID.Text = saloon.ID.ToString();
                        tool.r_sname.Text = saloon.SALONADI.ToString();
                        tool.r_scap.Text = saloon.KOLTUKSAYISI.ToString();


                        SaloonListPanel.Controls.Add(tool);
                    }

                }
            }
        }

        private void SaloonReg_Load(object sender, EventArgs e)
        {




            using (AchiDBContext ac = new AchiDBContext(Secrets.DB_Path))
            {
                foreach (var saloon in ac.Saloons.ToList())
                {
                    SaloonListControl tool = new SaloonListControl();

                    tool.ID.Text = saloon.ID.ToString();
                    tool.r_sname.Text = saloon.SALONADI.ToString();
                    tool.r_scap.Text = saloon.KOLTUKSAYISI.ToString();


                    SaloonListPanel.Controls.Add(tool);
                }

            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            Search_and_Order();

        }

        public void Search_and_Order()
        {
            SaloonListPanel.Controls.Clear();
            using (AchiDBContext ac = new AchiDBContext(Secrets.DB_Path))
            {
                
                var Saloon_Query = ac.Saloons
                    .Where(s => s.SALONADI.Contains(search.Text))
                    .ToList();
                int index = comboBox1.SelectedIndex;

                switch (index)
                {
                    case 0:
                        Saloon_Query = Saloon_Query.OrderBy(d => d.SALONADI).ToList();
                        break;
                    case 1:
                        Saloon_Query = Saloon_Query.OrderByDescending(d => d.KOLTUKSAYISI).ToList();
                        break;
                    case 2:
                        Saloon_Query = Saloon_Query.OrderBy(d => d.KOLTUKSAYISI).ToList();
                        break;
                    default:
                        Saloon_Query = Saloon_Query.OrderBy(d => d.ID).ToList();
                        break;
                }

                foreach (var saloon in Saloon_Query)
                {
                    SaloonListControl tool = new SaloonListControl();

                    tool.ID.Text = saloon.ID.ToString();
                    tool.r_sname.Text = saloon.SALONADI.ToString();
                    tool.r_scap.Text = saloon.KOLTUKSAYISI.ToString();

                    SaloonListPanel.Controls.Add(tool);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search_and_Order();
        }
    }
}
