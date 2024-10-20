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
using System.Media;
using Sinema_Otomasyonu.Classes;

namespace Sinema_Otomasyonu.UserControls
{
    public partial class DirectorListControl : UserControl
    {
        public DirectorListControl()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(Secrets.DB_Path);
        private void edit_Click(object sender, EventArgs e)
        {
            DirectorUpdate DU = new DirectorUpdate();
            using (AchiDBContext ac = new AchiDBContext(Secrets.DB_Path))
            {


                int Director_ID = int.Parse(ID.Text);

                var Director_Edit = ac.Directors
                    .FirstOrDefault(d => d.ID == Director_ID);

                DU.r_id.Text = Director_Edit.ID.ToString();
                DU.r_name.Text = Director_Edit.AD.ToString();
                DU.r_surname.Text = Director_Edit.SOYAD.ToString();
                DU.r_gender = Director_Edit.CINSIYET;
                DU.r_date.Value = Director_Edit.DOGUM;
                DU.r_bio.Text = Director_Edit.BIO.ToString();
                DU.r_img.ImageLocation = Director_Edit.RESIM.ToString();



            }


            MainPage mp = new MainPage();
            Functions.ShowFormCentered(DU, mp.panel1, mp.panel2, mp.panel3);

        }

        private void DirectorList_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

            MessageBox.Show("YÖNETMEN SİLMEK ÜZERESİNİZ BU İŞLEMİN GERİ DÖNÜŞÜ YOKTUR !" , "YÖNETMEN SİLME İŞLEMİ" , MessageBoxButtons.OK , MessageBoxIcon.Warning);

            DialogResult result = MessageBox.Show("Silmek İstedğinizden Emin Misiniz ?", "YÖNETMEN SİLME İŞLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            
            if (result == DialogResult.Yes)
            {

                using(AchiDBContext ac = new AchiDBContext(Secrets.DB_Path))
                {
                    int Director_ID = int.Parse(ID.Text);

                    var Director_Delete = ac.Directors.FirstOrDefault(d => d.ID == Director_ID);

                    ac.Directors.DeleteOnSubmit(Director_Delete);

                    ac.SubmitChanges();
                }
                /*
                connection.Open();

                SqlCommand delete = new SqlCommand("delete from Director_Info WHERE ID=@p1", connection);

                delete.Parameters.AddWithValue("@p1", ID.Text);
                delete.ExecuteNonQuery();
                
                connection.Close();*/
                MessageBox.Show("YÖNETMEN BAŞARIYLA SİLİNDİ" , "YÖNETMEN SİLME İŞLEMİ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Hide();
                
            }

            else if (result == DialogResult.No)
            {
                MessageBox.Show("YÖNETMEN SİLME İŞLEMİ İPTAL EDİLDİ", "YÖNETMEN SİLME İŞLEMİ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }
    }
}
