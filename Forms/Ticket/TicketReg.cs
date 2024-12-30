using Achi_Sinema.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Achi_Sinema.Forms.Ticket
{
    public partial class TicketReg : Form
    {
        public TicketReg()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TicketReg_Load(object sender, EventArgs e)
        {

            using (var ac = new AchiDbContext(AchiDbContext.Options))
            {
                var movies = ac.Movies.ToList();
                foreach (var movie in movies)
                {
                    movie_list_tk.Items.Add(movie.MovieName);
                }

                var saloons = ac.Saloons.ToList();
                foreach (var saloon in saloons)
                {
                    SaloonList.Items.Add(saloon.SaloonName);
                   
                }

               
 

                if (movie_list_tk.Items.Count == 0 || movie_list_tk.SelectedIndex == null)
                {
                    vizyon_tk.Value = new DateTime(1753, 1, 1, 0, 0, 0);
                    vizyon_tk.Enabled = false;
                    MessageBox.Show("Bu Film Vizyonda Değildir");
                }
                
                else if (movie_list_tk.Items.Count != 0)
                {
                    vizyon_tk.Value = DateTime.Today;
                    vizyon_tk.Enabled = true;
                }

                
            }
        }

        private void movie_list_tk_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var ac = new AchiDbContext(AchiDbContext.Options))
            {

                var SelectedMovie = movie_list_tk.SelectedItem.ToString();

                var movie = ac.Movies
                    .Where(m => m.MovieName == SelectedMovie)
                    .Select (m=> new {m.MovieRelase, m.MovieEnd ,m.MovieLenght})
                    .FirstOrDefault();

                DateTime Relase = movie.MovieRelase;
                DateTime End = movie.MovieEnd;
                TimeSpan Lenght = TimeSpan.FromHours(movie.MovieLenght);
                vizyon_tk.MinDate = Relase;
                vizyon_tk.MaxDate = End;

                
                DateTime Current = Relase;
                HourList.Items.Clear();


                while (Current + Lenght <= End)
                {
                    HourList.Items.Add(Current.ToString("HH:mm"));
                    Current += Lenght;
                }


            }
        }

        private void SaloonList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //i want to add item as SaloonCap number in SeatList
            using (var ac = new AchiDbContext(AchiDbContext.Options))
            {
                var SelectedSaloon = SaloonList.SelectedItem.ToString();
                var saloon = ac.Saloons
                    .Where(s => s.SaloonName == SelectedSaloon)
                    .Select(s => new { s.SaloonCap })
                    .FirstOrDefault();
                int Cap = saloon.SaloonCap;
                for (int i = 1; i <= Cap; i++)
                {
                    SeatList.Items.Add(i);
                }
            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
