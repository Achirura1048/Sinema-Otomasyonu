﻿using Achi_Sinema.Classes;
using Achi_Sinema.Tables;
using Sinema_Otomasyonu.Forms.Actor;
using Sinema_Otomasyonu.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Otomasyonu.Forms.Movie
{
    public partial class MovieReg : Form
    {
        

        public MovieReg()
        {
            InitializeComponent();
        }

        private void ex_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private string imgpath = null;
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MovieReg_Load(object sender, EventArgs e)
        {
            using (var ac = new AchiDbContext(AchiDbContext.Options))
            {
                List<string> ActorNames = new List<string>();
                List<int> ActorIDs = new List<int>();

                foreach (var item in ac.Actors)
                {
                    string DisplayName = item.ActorName + " " + item.ActorSurname;
                    actor_check.Items.Add(DisplayName);

                    ActorNames.Add(DisplayName);
                    ActorIDs.Add(item.ActorID);


                }

                List<string> DirectorNames = new List<string>();
                List<int> DirectorIDs = new List<int>();
                foreach (var item in ac.Directors)
                {
                    string DisplayName = item.DirectorName + " " + item.DirectorSurname;
                    director_check.Items.Add(DisplayName);

                    DirectorNames.Add(DisplayName);
                    DirectorIDs.Add(item.DirectorID);
                }

                List<string> GenreNames = new List<string>();
                List<int> GenreIDs = new List<int>();
                foreach (var item in ac.Genres)
                {
                    string DisplayName = item.GenreName;
                    genre_check.Items.Add(DisplayName);

                    GenreNames.Add(DisplayName);
                    GenreIDs.Add(item.GenreID);
                }

                List<string> RatingNames = new List<string>();
                List<int> RatingIDs = new List<int>();
                foreach (var item in ac.Ratings)
                {
                    string DisplayName = item.RatingName;
                    rating_check.Items.Add(DisplayName);

                    RatingNames.Add(DisplayName);
                    RatingIDs.Add(item.RatingId);
                }
            }

            /* List<string> Genres = new List<string>();
             Genres.Add("Aksiyon");
             Genres.Add("Dram");
             Genres.Add("Komedi");
             Genres.Add("Korku");
             Genres.Add("Bilim Kurgu");
             Genres.Add("Fantastik");
             Genres.Add("Macera");
             Genres.Add("Romantik");
             Genres.Add("Belgesel");
             Genres.Add("Gerilim");
             Genres.Add("Gizem");
             Genres.Add("Suç");
             Genres.Add("Savaş");
             Genres.Add("Western");
             Genres.Add("Animasyon");
             Genres.Add("Çocuk");
             Genres.Add("Aile");
             Genres.Add("Müzikal");
             Genres.Add("Tarih");
             Genres.Add("Yerli");

             foreach (var genre in Genres)
             {
                 GenreList tool = new GenreList();

                 tool.genre_name.Text = genre;
                 Genre_List.Controls.Add(tool);
             }*/

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

                string TargetDir = Path.Combine(LocalDir, Path.GetFileName(imgpath));
                File.Copy(imgpath, TargetDir, true);
                r_img.Image = Image.FromFile(TargetDir);

                using (var ac = new AchiDbContext(AchiDbContext.Options))
                {
                    var selectedGenresID = ac.Genres
                        .Where(g => genre_check.CheckedItems.Cast<string>().Contains(g.GenreName))
                        .Select(g => g.GenreID)
                        .ToList();

                    var selectedActorsID = ac.Actors
                        .Where(a => actor_check.CheckedItems.Cast<string>().Contains(a.ActorName + " " + a.ActorSurname))
                        .Select(a => a.ActorID)
                        .ToList();

                    var selectedRatingsID = ac.Ratings
                        .Where(r => rating_check.CheckedItems.Cast<string>().Contains(r.RatingName))
                        .Select(r => r.RatingId)
                        .ToList();

                    var selectedDirectorID = ac.Directors
                        .Where(d => director_check.CheckedItems.Cast<string>().Contains(d.DirectorName+ " " + d.DirectorSurname))
                        .Select(d => d.DirectorID)
                        .First();

                    var selectedGenres = ac.Genres.Where(g => selectedGenresID.Contains(g.GenreID)).ToList();
                    var selectedActors = ac.Actors.Where(a => selectedActorsID.Contains(a.ActorID)).ToList();
                    var selectedRatings = ac.Ratings.Where(r => selectedRatingsID.Contains(r.RatingId)).ToList();
                    var selectedDirector = ac.Directors.FirstOrDefault(d => d.DirectorID == selectedDirectorID);


                    Achi_Sinema.Tables.Movie newMovie = new Achi_Sinema.Tables.Movie
                    {
                        MovieName = m_name_reg.Text,
                        MovieGenres = selectedGenres,
                        MovieActors = selectedActors,
                        MovieDirector = selectedDirector,
                        MovieRelase = r_date.Value,
                        MovieIMBDRating = IMBD.Value.ToString(),
                        MovieRatings = selectedRatings,
                        MoviePoster = TargetDir,
                        MovieSummary = m_detail_reg.Text
                    };

                    ac.Movies.Add(newMovie);
                    ac.SaveChanges();

                }
                MessageBox.Show("Film Kaydedildi");
            }
        }

        private void director_search_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void actor_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void r_img_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
