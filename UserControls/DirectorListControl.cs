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
            DirectorUpdate updt = new DirectorUpdate();
            MainPage borders = new MainPage();
            Functions.ShowFormCentered(updt, borders.panel1 , borders.panel2 , borders.panel3);

            
            connection.Open();
            SqlCommand get = new SqlCommand("select * from Director_Info(AD , SOYAD , DOGUM , CINSIYET , RESIM , BIO) where ID=@p1" , connection);
            //SqlCommand update = new SqlCommand("UPDATE from Director_Info WHERE ID=@p1", connection);

            connection.Close();
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
                connection.Open();

                SqlCommand delete = new SqlCommand("delete from Director_Info WHERE ID=@p1", connection);

                delete.Parameters.AddWithValue("@p1", ID.Text);
                delete.ExecuteNonQuery();

                connection.Close();
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
