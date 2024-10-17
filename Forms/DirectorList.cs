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
using Sinema_Otomasyonu.UserControls;
namespace Sinema_Otomasyonu
{
    public partial class DirectorList : Form
    {
        public DirectorList()
        {
            InitializeComponent();
        }
        SqlConnection connenction = new SqlConnection(Secrets.DB_Path);
        private void ex_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DirectorList_Load(object sender, EventArgs e)
        {


            DirectorLoad("select * from Director_Info ORDER BY ID ASC");       
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //ListPanel.Controls.Clear();
            int index = comboBox1.SelectedIndex;
            string query;
            switch (index)
            {
                case 0:
                    query = "select * from Director_Info ORDER BY AD ASC";
                   // MessageBox.Show("0");
                    break;

                case 1:
                    query = "select * from Director_Info ORDER BY CINSIYET DESC";
                    //MessageBox.Show("1");
                    break;

                case 2:
                    query = "select * from Director_Info ORDER BY CINSIYET ASC";
                   // MessageBox.Show("2");
                    break;

                case 3:
                    query = "select * from Director_Info ORDER BY DOGUM ASC";
                    //MessageBox.Show("3");
                    break;

                case 4:
                    query = "select * from Director_Info ORDER BY DOGUM DESC";
                    //MessageBox.Show("4");
                    break;

                default:
                    query = "select * from Director_Info ORDER BY ID ASC";
                    //MessageBox.Show("5");
                    break;

            }

            DirectorLoad(query);
            
        }
        private void DirectorLoad(string query)
        {
            ListPanel.Controls.Clear();

            connenction.Open();

            SqlCommand cmd = new SqlCommand(query, connenction);
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {

                Sinema_Otomasyonu.UserControls.DirectorListControl tool = new Sinema_Otomasyonu.UserControls.DirectorListControl();

                tool.ID.Text = rd["ID"].ToString();
                tool.img.ImageLocation = rd["RESIM"].ToString();
                tool.name.Text = rd["AD"] + " " + rd["SOYAD"].ToString();

                DateTime birthDate = Convert.ToDateTime(rd["DOGUM"]);
                DateTime Today = DateTime.Now;
                int age = Today.Year - birthDate.Year;

                if (Today < birthDate.AddYears(age))
                {
                    age--;
                }

                string formattedDate = birthDate.ToString("MM-dd-yyyy");
                tool.year.Text = formattedDate + "(" + age.ToString() + ")";
                tool.bio.Text = rd["BIO"].ToString();

                ListPanel.Controls.Add(tool);
            }
            connenction.Close();

        }
        private void ListPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            ListPanel.Controls.Clear();
            connenction.Open();

            SqlCommand srch = new SqlCommand("SELECT * FROM Director_Info WHERE AD LIKE '%"+search.Text+ "%' or SOYAD LIKE '%"+search.Text+"%' ", connenction);
            SqlDataReader rd  = srch.ExecuteReader();

            while (rd.Read())
            {
                DirectorListControl tool = new DirectorListControl();

                tool.ID.Text = rd["ID"].ToString();
                tool.img.ImageLocation = rd["RESIM"].ToString();
                tool.name.Text = rd["AD"] + " " + rd["SOYAD"].ToString();

                DateTime birthDate = Convert.ToDateTime(rd["DOGUM"]);
                DateTime Today = DateTime.Now;
                int age = Today.Year - birthDate.Year;

                if (Today < birthDate.AddYears(age))
                {
                    age--;
                }

                string formattedDate = birthDate.ToString("MM-dd-yyyy");
                tool.year.Text = formattedDate + "(" + age.ToString() + ")";
                tool.bio.Text = rd["BIO"].ToString();

                ListPanel.Controls.Add(tool);

            }

            connenction.Close();
        }
    }
}