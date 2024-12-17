using Achi_Sinema.Classes;
using Achi_Sinema.Tables;
using Microsoft.EntityFrameworkCore;
using Sinema_Otomasyonu;
using Sinema_Otomasyonu.Forms.Actor;
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
    public partial class MoiveUpdate : Form
    {
        public MoiveUpdate()
        {
            InitializeComponent();
        }

        private void ex_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string imgpath;
        public string TargetDir;

        private void img_up_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "RESİM SEÇME EKRANI";
            ofd.Filter = "Resim Dosyaları | *.jpg; *.jpeg; *.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imgpath = ofd.FileName;
                r_img.Image = Image.FromFile(imgpath);
            }
        }

        private void r_save_Click(object sender, EventArgs e)
        {
            if (m_name_reg.Text == "" || movie_genre == null || movie_rating == null || r_img.ImageLocation == null)
            {
                MessageBox.Show("BOŞ ALANLARI DOLDURUN");
            }

            else
            {



                string Account_Name = Environment.UserName;
                string LocalDir = $@"C:\Users\{Account_Name}\AppData\Local\Achi Cinema\Movie_Posters";

                if (!Directory.Exists(LocalDir))
                {
                    Directory.CreateDirectory(LocalDir);
                }

                /*TargetDir = Path.Combine(LocalDir, Path.GetFileName(imgpath));
                File.Copy(imgpath, TargetDir, true);
                r_img.Image = Image.FromFile(TargetDir);*/

                using (var ac = new AchiDbContext(AchiDbContext.Options))
                {
                    var Movie_ID = int.Parse(r_id.Text);

                    var Movie_Update = ac.Movies
                        .Include(m => m.MovieGenres)
                        .Include(m => m.MovieActors)
                        .Include(m => m.MovieRatings)
                        .FirstOrDefault(m=> m.MovieID == Movie_ID);

                    if (imgpath == null)
                    {
                        TargetDir = Movie_Update.MoviePoster;
                    }

                    else
                    {
                        TargetDir = Path.Combine(LocalDir, Path.GetFileName(imgpath));
                        File.Copy(imgpath, TargetDir, true);
                        r_img.Image = Image.FromFile(TargetDir);
                    }

                    Movie_Update.MovieName = m_name_reg.Text;
                    Movie_Update.MovieRelase = r_date.Value;
                    Movie_Update.MovieIMBDRating = IMBD.Value.ToString();
                    Movie_Update.MoviePoster = TargetDir;
                    Movie_Update.MovieSummary = m_detail_reg.Text;

                    var selectedDirectorID = ac.Directors
                        .Where(d => director_check.CheckedItems.Cast<string>().Contains(d.DirectorName + " " + d.DirectorSurname))
                        .Select(d => d.DirectorID)
                        .First();

                   
                    Movie_Update.MovieDirector = ac.Directors.FirstOrDefault(d => d.DirectorID == selectedDirectorID);

                    Movie_Update.MovieGenres.Clear();
                    Movie_Update.MovieActors.Clear();
                    Movie_Update.MovieRatings.Clear();

                    var selectedGenresID = ac.Genres
                        .Where(g => genre_check.CheckedItems.Cast<string>().Contains(g.GenreName))
                        .Select(g => g.GenreID)
                        .ToList();

                    foreach (var genreID in selectedGenresID)
                    {
                        Movie_Update.MovieGenres.Add(new GenreMovie { MovieGenresGenreID = genreID , GenreMoviesMovieID = Movie_ID});
                    }

                    var selectedActorsID = ac.Actors
                        .Where(a => actor_check.CheckedItems.Cast<string>().Contains(a.ActorName + " " + a.ActorSurname))
                        .Select(a => a.ActorID)
                        .ToList();

                    foreach(var actorID in selectedActorsID)
                    {
                        Movie_Update.MovieActors.Add(new ActorMovie { MovieActorsActorID = actorID, ActorMoviesMovieID = Movie_ID });
                    }

                    var selectedRatingsID = ac.Ratings
                        .Where(r => rating_check.CheckedItems.Cast<string>().Contains(r.RatingName))
                        .Select(r => r.RatingId)
                        .ToList();

                    foreach (var ratingID in selectedRatingsID)
                    {
                        Movie_Update.MovieRatings.Add(new MovieRating { RatingMoviesMovieID = Movie_ID, MovieRatingsRatingId = ratingID });
                    }


                    var selectedGenres = ac.Genres.Where(g => selectedGenresID.Contains(g.GenreID)).ToList();
                    var selectedActors = ac.Actors.Where(a => selectedActorsID.Contains(a.ActorID)).ToList();
                    var selectedRatings = ac.Ratings.Where(r => selectedRatingsID.Contains(r.RatingId)).ToList();
                    var selectedDirector = ac.Directors.FirstOrDefault(d => d.DirectorID == selectedDirectorID);


                    var actorMovies = selectedActors.Select(a => new ActorMovie { Actor = a }).ToList();
                    var genreMovies = selectedGenres.Select(g => new GenreMovie { Genre = g }).ToList();
                    var ratingMovies = selectedRatings.Select(r => new MovieRating { Rating = r }).ToList();

                    

                    
                    Movie_Update.MovieGenres = genreMovies;
                    Movie_Update.MovieActors = actorMovies;
                    
                    
                    
                    Movie_Update.MovieRatings = ratingMovies;

                    

                    ac.Update(Movie_Update);
                    ac.SaveChanges();

                }
                MessageBox.Show("Film Güncellendi");
                this.Close();
                MainPage mp = new MainPage();
                MovieList MovList = new MovieList();
                Functions.ShowFormCentered(MovList, mp.panel1, mp.panel2);
            }
        }
    }
}
