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
using Sinema_Otomasyonu.Classes;
using System.Collections;
namespace Sinema_Otomasyonu
{
    public partial class DirectorList : Form
    {
        
        public DirectorList()
        {
            InitializeComponent();
        }
        
        private void ex_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search_and_Order();

        }
       
        


        private void search_TextChanged(object sender, EventArgs e)
        {
            Search_and_Order();           
        }
        public void Search_and_Order()
        {
            ListPanel.Controls.Clear();
            

            using (AchiDBContext ac = new AchiDBContext(Secrets.DB_Path))

            {
                var Director_Query = ac.Directors
                    .Where(s => s.AD.Contains(search.Text) || s.SOYAD.Contains(search.Text))
                    .ToList();

                int index = comboBox1.SelectedIndex;
                switch (index)
                {
                    case 0:

                        Director_Query = Director_Query.OrderBy(d => d.AD + d.SOYAD).ToList();

                        // MessageBox.Show("0");
                        break;

                    case 1:
                        Director_Query = Director_Query.OrderByDescending(d => d.CINSIYET).ToList();

                        //MessageBox.Show("1");
                        break;

                    case 2:
                        Director_Query = Director_Query.OrderBy(d => d.CINSIYET).ToList();
                        // MessageBox.Show("2");
                        break;

                    case 3:
                        Director_Query = Director_Query.OrderBy(d => d.DOGUM).ToList();

                        //MessageBox.Show("3");
                        break;

                    case 4:
                        Director_Query = Director_Query.OrderByDescending(d => d.DOGUM).ToList();

                        //MessageBox.Show("4");
                        break;

                    default:
                        Director_Query = Director_Query.OrderBy(d => d.ID).ToList();

                        //MessageBox.Show("5");
                        break;

                }

                foreach (var director in Director_Query)
                {
                    DirectorListControl tool = new DirectorListControl();

                    tool.ID.Text = director.ID.ToString();
                    tool.img.ImageLocation = director.RESIM.ToString();
                    tool.name.Text = director.AD + director.SOYAD.ToString();

                    DateTime birthDate = Convert.ToDateTime(director.DOGUM);
                    DateTime Today = DateTime.Now;
                    int age = Today.Year - birthDate.Year;

                    if (Today < birthDate.AddYears(age))
                    {
                        age--;
                    }

                    string formattedDate = birthDate.ToString("MM-dd-yyyy");
                    tool.year.Text = formattedDate + "(" + age.ToString() + ")";
                    tool.bio.Text = director.BIO.ToString();

                    ListPanel.Controls.Add(tool);
                }


            }

            
        }
        private void DirectorList_Load(object sender, EventArgs e)
        {
           
            
            
            using (AchiDBContext ac = new AchiDBContext(Secrets.DB_Path))
            {
                foreach (var director in ac.Directors.ToList())
                {
                    DirectorListControl tool = new DirectorListControl();

                    tool.ID.Text = director.ID.ToString();
                    tool.img.ImageLocation = director.RESIM.ToString();
                    tool.name.Text = director.AD + " " + director.SOYAD.ToString();

                    DateTime birthDate = Convert.ToDateTime(director.DOGUM);
                    DateTime Today = DateTime.Now;
                    int age = Today.Year - birthDate.Year;

                    if (Today < birthDate.AddYears(age))
                    {
                        age--;
                    }

                    string formattedDate = birthDate.ToString("MM-dd-yyyy");
                    tool.year.Text = formattedDate + "(" + age.ToString() + ")";
                    tool.bio.Text = director.BIO.ToString();

                    ListPanel.Controls.Add(tool);
                }
            }
        }

        private void ListPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}