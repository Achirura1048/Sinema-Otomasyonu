using Achi_Sinema.Classes;
using Achi_Sinema.Forms.Movie;
using Achi_Sinema.Tables;
using Sinema_Otomasyonu;
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

        private void movie_edit_Click(object sender, EventArgs e)
        {
            MoiveUpdate MU = new MoiveUpdate();

            using (var ac = new AchiDbContext(AchiDbContext.Options))
            {

                int Movie_Id = int.Parse(ListMovieID.Text);

                var Movie_Edit = ac.Movies
                    .FirstOrDefault(m => m.MovieID == Movie_Id);

                MU.r_id.Text = Movie_Edit.MovieID.ToString();
                MU.m_name_reg.Text = Movie_Edit.MovieName.ToString();
                MU.TargetDir = Movie_Edit.MoviePoster;
                var director = ac.Directors
                 .Where(d => d.DirectorID == Movie_Edit.MovieDirectorDirectorID)
                 .FirstOrDefault();

                MU.director_check.Items.Add(director.DirectorName + " " + director.DirectorSurname);
                var genres = ac.GenreMovie
                    .Where(gm => gm.GenreMoviesMovieID == Movie_Edit.MovieID)
                    .Select(gm => gm.Genre)
                    .ToList();

                foreach (var genre in ac.Genres)
                {
                    int index = MU.genre_check.Items.Add(genre.GenreName);
                    if (genres.Contains(genre))
                    {
                        MU.genre_check.SetItemChecked(index, true);
                    }
                }

                var actors = ac.ActorMovie
                    .Where(acm => acm.ActorMoviesMovieID == Movie_Edit.MovieID)
                    .Select(acm => acm.Actor)
                    .ToList();
                foreach (var actor in ac.Actors)
                {
                    int index = MU.actor_check.Items.Add(actor.ActorName + " " + actor.ActorSurname);
                    if (actors.Contains(actor))
                    {
                        MU.actor_check.SetItemChecked(index, true);
                    }
                }

                MU.r_date.Value = Movie_Edit.MovieRelase;
                MU.IMBD.Value = int.Parse(Movie_Edit.MovieIMBDRating);

                var ratings = ac.MovieRating
                    .Where(r => r.RatingMoviesMovieID == Movie_Edit.MovieID)
                    .Select(r => r.Rating)
                    .ToList();
                foreach (var rating in ac.Ratings)
                {
                    int index = MU.rating_check.Items.Add(rating.RatingName);
                    if (ratings.Contains(rating))
                    {
                        MU.rating_check.SetItemChecked(index, true);
                    }

                    MU.m_detail_reg.Text = Movie_Edit.MovieSummary.ToString();
                    MU.r_img.ImageLocation = Movie_Edit.MoviePoster.ToString();

                }
            }
            MainPage mp = new MainPage();
            Functions.ShowFormCentered(MU, mp.panel1, mp.panel2);

        }

        private void ListMoviePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
