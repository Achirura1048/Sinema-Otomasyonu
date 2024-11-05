using Sinema_Otomasyonu.Classes;
using Sinema_Otomasyonu.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Otomasyonu.Forms.Actor
{
    public partial class ActorList : Form
    {
        public ActorList()
        {
            InitializeComponent();
        }

        private void ex_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            Search_and_Order();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search_and_Order();
        }

        public void Search_and_Order()
        {
            ListPanel.Controls.Clear();


            using (AchiDBContext ac = new AchiDBContext(Secrets.DB_Path))

            {
                var Actor_Query = ac.Actors
                    .Where(s => s.AD.Contains(search.Text) || s.SOYAD.Contains(search.Text))
                    .ToList();

                int index = comboBox1.SelectedIndex;
                switch (index)
                {
                    case 0:

                        Actor_Query = Actor_Query.OrderBy(d => d.AD + d.SOYAD).ToList();

                        // MessageBox.Show("0");
                        break;

                    case 1:
                        Actor_Query = Actor_Query.OrderByDescending(d => d.CINSIYET).ToList();

                        //MessageBox.Show("1");
                        break;

                    case 2:
                     Actor_Query = Actor_Query.OrderBy(d => d.CINSIYET).ToList();
                        // MessageBox.Show("2");
                        break;

                    case 3:
                        Actor_Query = Actor_Query.OrderBy(d => d.DOGUM).ToList();

                        //MessageBox.Show("3");
                        break;

                    case 4:
                        Actor_Query = Actor_Query.OrderByDescending(d => d.DOGUM).ToList();

                        //MessageBox.Show("4");
                        break;

                    default:
                        Actor_Query = Actor_Query.OrderBy(d => d.ID).ToList();

                        //MessageBox.Show("5");
                        break;

                }
                
                foreach (var actor in Actor_Query)
                {
                    ActorListControl tool = new ActorListControl();

                    tool.ID.Text = actor.ID.ToString();
                    tool.img.ImageLocation = actor.RESIM.ToString();
                    tool.name.Text = actor.AD + actor.SOYAD.ToString();

                    DateTime birthDate = Convert.ToDateTime(actor.DOGUM);
                    DateTime Today = DateTime.Now;
                    int age = Today.Year - birthDate.Year;

                    if (Today < birthDate.AddYears(age))
                    {
                        age--;
                    }

                    string formattedDate = birthDate.ToString("MM-dd-yyyy");
                    tool.year.Text = formattedDate + "(" + age.ToString() + ")";
                    tool.bio.Text = actor.BIO.ToString();

                    ListPanel.Controls.Add(tool);
                }


            }


        }

        private void ActorList_Load(object sender, EventArgs e)
        {
            using (AchiDBContext ac = new AchiDBContext(Secrets.DB_Path))
            {
                foreach (var actor in ac.Actors.ToList())
                {
                    ActorListControl tool = new ActorListControl();

                    tool.ID.Text = actor.ID.ToString();
                    tool.img.ImageLocation = actor.RESIM.ToString();
                    tool.name.Text = actor.AD + " " + actor.SOYAD.ToString();

                    DateTime birthDate = Convert.ToDateTime(actor.DOGUM);
                    DateTime Today = DateTime.Now;
                    int age = Today.Year - birthDate.Year;

                    if (Today < birthDate.AddYears(age))
                    {
                        age--;
                    }

                    string formattedDate = birthDate.ToString("MM-dd-yyyy");
                    tool.year.Text = formattedDate + "(" + age.ToString() + ")";
                    tool.bio.Text = actor.BIO.ToString();

                    ListPanel.Controls.Add(tool);
                }
            }
        }
    }
}
