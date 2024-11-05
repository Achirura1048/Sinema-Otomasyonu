using Sinema_Otomasyonu.Classes;
using Sinema_Otomasyonu.Classes.Tables;
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
    public partial class DirectorListMovie : UserControl
    {
        public List<string> Directors_List = new List<string>();
        public DirectorListMovie()
        {
            
            InitializeComponent();
        }

        private void DirectorListMovie_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void DirectorListMovie_MouseEnter(object sender, EventArgs e)
        {
            
            
        }

        private void DirectorListMovie_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }

        private void DirectorListMovie_Click(object sender, EventArgs e)
        {

        }

        private void DirectorListMovie_Load(object sender, EventArgs e)
        {

        }

        public void director_name_Click(object sender, EventArgs e)
        {
           

            if (director_name.ForeColor == Color.FromArgb(0, 0, 0))
            {
                director_name.ForeColor = Color.FromArgb(255, 128, 13);


                
                Directors_List.Add(director_name.Text);            
            }

            else
            {
                director_name.ForeColor = Color.FromArgb(0, 0, 0);

                Directors_List.Remove(director_name.Text);
            }

        }

        private void director_name_MouseMove(object sender, MouseEventArgs e)
        {
            director_name.Font = new Font("Arial Narrow", 12, FontStyle.Bold | FontStyle.Underline);
        }

        private void director_name_MouseLeave(object sender, EventArgs e)
        {
            director_name.Font = new Font("Arial Narrow", 12, FontStyle.Bold);
        }
    }
}
