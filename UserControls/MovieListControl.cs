using Achi_Sinema.Classes;
using Achi_Sinema.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Achi_Sinema.UserControls
{
    public partial class MovieListControl : UserControl
    {
        public MovieListControl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ListMovieActors_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MovieListControl_Load(object sender, EventArgs e)
        {
           

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FİLM SİLMEK ÜZERESİNİZ BU İŞLEMİN GERİ DÖNÜŞÜ YOKTUR !", "FİLM SİLME İŞLEMİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            DialogResult result = MessageBox.Show("Silmek İstedğinizden Emin Misiniz ?", "FİLM SİLME İŞLEMİ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


            if (result == DialogResult.Yes)
            {

                using (var ac = new AchiDbContext(AchiDbContext.Options))
                {

                    int Movie_ID = int.Parse(ListMovieID.Text);

                    var Movie_Delete = ac.Movies.FirstOrDefault(m => m.MovieID == Movie_ID);

                    

                    var actors = ac.ActorMovie
                        .Where(acm => acm.ActorMoviesMovieID == Movie_Delete.MovieID)
                        .ToList();

                    foreach (var actor in actors)
                    {
                        ac.Remove(actor);
                    }

                    var ratings = ac.MovieRating
                        .Where(r => r.RatingMoviesMovieID == Movie_Delete.MovieID)
                        .ToList();

                    foreach (var rating in ratings)
                    {
                        ac.Remove(rating);
                    }

                    var genres = ac.GenreMovie
                        .Where(g => g.GenreMoviesMovieID == Movie_Delete.MovieID)
                        .ToList();

                    foreach (var genre in genres)
                    {
                        ac.Remove(genre);
                    }



                    //File.Delete(Movie_Delete.MoviePoster);
                    ac.Remove(Movie_Delete);
                    ac.SaveChanges();


                }



                MessageBox.Show("FİLM BAŞARIYLA SİLİNDİ", "FİLM SİLME İŞLEMİ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Hide();



            }

            else if (result == DialogResult.No)
            {
                MessageBox.Show("FİLM SİLME İŞLEMİ İPTAL EDİLDİ", "FİLM SİLME İŞLEMİ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}
