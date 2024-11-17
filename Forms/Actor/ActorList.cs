using Achi_Sinema.Classes;
using Achi_Sinema.Tables;
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


            using (var ac = new AchiDbContext(AchiDbContext.Options))

            {
                var Actor_Query = ac.Actors
                    .Where(s => s.ActorName.Contains(search.Text) || s.ActorSurname.Contains(search.Text))
                    .ToList();

                int index = comboBox1.SelectedIndex;
                switch (index)
                {
                    case 0:

                        Actor_Query = Actor_Query.OrderBy(d => d.ActorID + d.ActorSurname).ToList();

                        // MessageBox.Show("0");
                        break;

                    case 1:
                        Actor_Query = Actor_Query.OrderByDescending(d => d.ActorGender).ToList();

                        //MessageBox.Show("1");
                        break;

                    case 2:
                     Actor_Query = Actor_Query.OrderBy(d => d.ActorGender).ToList();
                        // MessageBox.Show("2");
                        break;

                    case 3:
                        Actor_Query = Actor_Query.OrderBy(d => d.ActorBirthDate).ToList();

                        //MessageBox.Show("3");
                        break;

                    case 4:
                        Actor_Query = Actor_Query.OrderByDescending(d => d.ActorBirthDate).ToList();

                        //MessageBox.Show("4");
                        break;

                    default:
                        Actor_Query = Actor_Query.OrderBy(d => d.ActorID).ToList();

                        //MessageBox.Show("5");
                        break;

                }
                
                foreach (var actor in Actor_Query)
                {
                    ActorListControl tool = new ActorListControl();

                    tool.ID.Text = actor.ActorID.ToString();
                    tool.img.ImageLocation = actor.ActorImage.ToString();
                    tool.name.Text = actor.ActorName + actor.ActorSurname.ToString();

                    DateTime birthDate = Convert.ToDateTime(actor.ActorBirthDate);
                    DateTime Today = DateTime.Now;
                    int age = Today.Year - birthDate.Year;

                    if (Today < birthDate.AddYears(age))
                    {
                        age--;
                    }

                    string formattedDate = birthDate.ToString("MM-dd-yyyy");
                    tool.year.Text = formattedDate + "(" + age.ToString() + ")";
                    tool.bio.Text = actor.ActorBiography.ToString();

                    ListPanel.Controls.Add(tool);
                }


            }


        }

        private void ActorList_Load(object sender, EventArgs e)
        {
            using (var ac = new AchiDbContext(AchiDbContext.Options))
            {
                foreach (var actor in ac.Actors.ToList())
                {
                    ActorListControl tool = new ActorListControl();

                    tool.ID.Text = actor.ActorID.ToString();
                    tool.img.ImageLocation = actor.ActorImage.ToString();
                    tool.name.Text = actor.ActorName + " " + actor.ActorSurname.ToString();

                    DateTime birthDate = Convert.ToDateTime(actor.ActorBirthDate);
                    DateTime Today = DateTime.Now;
                    int age = Today.Year - birthDate.Year;

                    if (Today < birthDate.AddYears(age))
                    {
                        age--;
                    }

                    string formattedDate = birthDate.ToString("MM-dd-yyyy");
                    tool.year.Text = formattedDate + "(" + age.ToString() + ")";
                    tool.bio.Text = actor.ActorBiography.ToString();

                    ListPanel.Controls.Add(tool);
                }
            }
        }
    }
}
