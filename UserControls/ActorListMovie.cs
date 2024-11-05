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
    public partial class ActorListMovie : UserControl
    {
        public List<string> Actors = new List<string>();
        public ActorListMovie()
        {
            InitializeComponent();
        }

        private void ActorListMovie_Load(object sender, EventArgs e)
        {

        }

        private void actor_name_Click(object sender, EventArgs e)
        {
            

            if (actor_name.ForeColor == Color.FromArgb(0, 0, 0))
            {
                actor_name.ForeColor = Color.FromArgb(255, 128, 13);



                Actors.Add(actor_name.Text);
            }

            else
            {
                actor_name.ForeColor = Color.FromArgb(0, 0, 0);

                Actors.Remove(actor_name.Text);
            }
        }

        private void actor_name_MouseMove(object sender, MouseEventArgs e)
        {
            actor_name.Font = new Font("Arial Narrow", 12, FontStyle.Bold | FontStyle.Underline);
        }

        private void actor_name_MouseLeave(object sender, EventArgs e)
        {
            actor_name.Font = new Font("Arial Narrow", 12, FontStyle.Bold);
        }
    }
}
