using Achi_Sinema.Classes;
using Achi_Sinema.UserControls;
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

namespace Achi_Sinema.Forms.Movie
{
    public partial class MovieList : Form
    {
        public MovieList()
        {
            InitializeComponent();
        }

        private void ex_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MovieList_Load(object sender, EventArgs e)
        {
            using (var ac = new AchiDbContext(AchiDbContext.Options))
            {

                foreach (var movie in ac.Movies.ToList())
                {
                    MovieListControl MLC = new MovieListControl();
                    MLC.ListMovieID.Text = movie.MovieID.ToString();
                    MLC.ListMovieImg.Image = Image.FromFile(movie.MoviePoster);
                    MLC.ListMovieName.Text = movie.MovieName;



                    var actors = ac.ActorMovie
                        .Where(acm => acm.ActorMoviesMovieID == movie.MovieID)
                        .Select(acm => acm.Actor)
                        .ToList();

                    foreach (var actor in actors)
                    {
                        MovieListActor MVA = new MovieListActor();


                        MVA.MLActor.Image = Image.FromFile(actor.ActorImage);
                        MVA.MLActorName.Text = actor.ActorName + " " + actor.ActorSurname;
                        MLC.ListMovieActors.Controls.Add(MVA);
                    }

                    var director = ac.Directors
                        .Where(d => d.DirectorID == movie.MovieDirectorDirectorID)
                        .FirstOrDefault();
                    MLC.ListDirectorImg.Image = Image.FromFile(director.DirectorImage);
                    MLC.ListDirectorName.Text = director.DirectorName + " " + director.DirectorSurname;
                    MLC.ListMovieRate.Text = movie.MovieIMBDRating.ToString();
                    MLC.ListMovieDate.Value = movie.MovieRelase;
                    MLC.ListMovieSum.Text = movie.MovieSummary;

                    var ratings = ac.MovieRating
                        .Where(r => r.RatingMoviesMovieID == movie.MovieID)
                        .Select(r => r.Rating)
                        .ToList();


                    foreach (var rating in ratings)
                    {

                        MLC.ListRatingCheck.Items.Add(rating.RatingName);
                    }

                    var genres = ac.GenreMovie
                        .Where(mg => mg.GenreMoviesMovieID == movie.MovieID)
                        .Select(mg => mg.Genre)
                        .ToList();
                    foreach (var genre in genres)
                    {
                        MLC.ListMovieGenre.Items.Add(genre.GenreName);
                    }
                    ListPanelMovie.Controls.Add(MLC);
                }
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            Search_and_Order();
        }

        public void Search_and_Order()
        {
            ListPanelMovie.Controls.Clear();


            using (var ac = new AchiDbContext(AchiDbContext.Options))

            {
                var Moive_Query = ac.Movies
                    .Where(s => s.MovieName.Contains(search.Text))
                    .ToList();

                int index = comboBox1.SelectedIndex;
                switch (index)
                {
                    case 0:

                        Moive_Query = Moive_Query.OrderBy(m => m.MovieName).ToList();

                        // MessageBox.Show("0");
                        break;

                    case 1:
                        Moive_Query = Moive_Query.OrderBy(m => m.MovieGenres).ToList();

                        //MessageBox.Show("1");
                        break;

                    default:
                        Moive_Query = Moive_Query.OrderBy(d => d.MovieID).ToList();

                        //MessageBox.Show("5");
                        break;

                }

                

                foreach (var movie in Moive_Query)
                {
                    MovieListControl MLC = new MovieListControl();
                    MLC.ListMovieID.Text = movie.MovieID.ToString();
                    MLC.ListMovieImg.Image = Image.FromFile(movie.MoviePoster);
                    MLC.ListMovieName.Text = movie.MovieName;



                    var actors = ac.ActorMovie
                        .Where(acm => acm.ActorMoviesMovieID == movie.MovieID)
                        .Select(acm => acm.Actor)
                        .ToList();

                    foreach (var actor in actors)
                    {
                        MovieListActor MVA = new MovieListActor();


                        MVA.MLActor.Image = Image.FromFile(actor.ActorImage);
                        MVA.MLActorName.Text = actor.ActorName + " " + actor.ActorSurname;
                        MLC.ListMovieActors.Controls.Add(MVA);
                    }

                    var director = ac.Directors
                        .Where(d => d.DirectorID == movie.MovieDirectorDirectorID)
                        .FirstOrDefault();
                    MLC.ListDirectorImg.Image = Image.FromFile(director.DirectorImage);
                    MLC.ListDirectorName.Text = director.DirectorName + " " + director.DirectorSurname;
                    MLC.ListMovieRate.Text = movie.MovieIMBDRating.ToString();
                    MLC.ListMovieDate.Value = movie.MovieRelase;
                    MLC.ListMovieSum.Text = movie.MovieSummary;

                    var ratings = ac.MovieRating
                        .Where(r => r.RatingMoviesMovieID == movie.MovieID)
                        .Select(r => r.Rating)
                        .ToList();


                    foreach (var rating in ratings)
                    {

                        MLC.ListRatingCheck.Items.Add(rating.RatingName);
                    }

                    var genres = ac.GenreMovie
                        .Where(mg => mg.GenreMoviesMovieID == movie.MovieID)
                        .Select(mg => mg.Genre)
                        .ToList();
                    foreach (var genre in genres)
                    {
                        MLC.ListMovieGenre.Items.Add(genre.GenreName);
                    }
                    ListPanelMovie.Controls.Add(MLC);
                }


            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search_and_Order();
        }

        private void ListPanelMovie_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
