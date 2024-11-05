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
    public partial class GenreList : UserControl
    {
        public GenreList()
        {
            InitializeComponent();
        }

        private void genre_name_Click(object sender, EventArgs e)
        {
            List<string> Genre = new List<string>();

            if (genre_name.ForeColor == Color.FromArgb(0, 0, 0))
            {
                genre_name.ForeColor = Color.FromArgb(255, 128, 13);



                Genre.Add(genre_name.Text);
            }

            else
            {
                genre_name.ForeColor = Color.FromArgb(0, 0, 0);

                Genre.Remove(genre_name.Text);
            }
        }

        private void genre_name_MouseLeave(object sender, EventArgs e)
        {
            genre_name.Font = new Font("Arial Narrow", 12, FontStyle.Bold);
        }

        private void genre_name_MouseMove(object sender, MouseEventArgs e)
        {
            genre_name.Font = new Font("Arial Narrow", 12, FontStyle.Bold | FontStyle.Underline);
        }
    }
}
