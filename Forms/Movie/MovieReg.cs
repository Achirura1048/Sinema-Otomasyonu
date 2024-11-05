using Sinema_Otomasyonu.Classes;
using Sinema_Otomasyonu.Classes.Tables;
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
        private DirectorListMovie _DirectorListMovie;
        private ActorListMovie _ActorListMovie;

        public MovieReg()
        {
          
            InitializeComponent();
            _DirectorListMovie = new DirectorListMovie();
            _ActorListMovie = new ActorListMovie();
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
            using (AchiDBContext ac = new AchiDBContext(Secrets.DB_Path))
            {
                var actors = ac.Actors.ToList();
                foreach (var actor in ac.Actors)
                {
                    ActorListMovie tool = new ActorListMovie();

                    tool.ID.Text = actor.ID.ToString();
                    tool.actor_name.Text = actor.AD + " " + actor.SOYAD;

                    Actor_List.Controls.Add(tool);
                }

                var directors = ac.Directors.ToList();
                foreach (var director in ac.Directors)
                {
                    DirectorListMovie tool = new DirectorListMovie();

                    tool.ID.Text = director.ID.ToString();
                    tool.director_name.Text = director.AD + " " + director.SOYAD;

                    Director_List.Controls.Add(tool);
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


            if(m_name_reg.Text == "" || movie_genre == null || movie_type == null || _ActorListMovie == null || _DirectorListMovie == null || movie_rating == null || r_img.ImageLocation == null)
            {
                MessageBox.Show("BOŞ ALANLARI DOLDURUN");            
            }

            else
            {
                List<string> Genres = new List<string>();
                List<string> Type = new List<string>();
                List<string> Rating = new List<string>();
                foreach (var item in genre_check.CheckedItems)
                {
                    Genres.Add(item.ToString());
                }

                foreach (var item in type_check.CheckedItems)
                {
                    Type.Add(item.ToString());
                }

                foreach (var item in rating_check.CheckedItems)
                {
                    Rating.Add(item.ToString());
                }

                string genre_comma = string.Join(",", Genres);
                string type_comma = string.Join(",", Type);
                string rating_comma = string.Join(",", Rating);
                string actor_comma = string.Join(",", _ActorListMovie.Actors);
                string director_comma = string.Join(",", _DirectorListMovie.Directors_List);

                string Account_Name = Environment.UserName;
                string LocalDir = $@"C:\Users\{Account_Name}\AppData\Local\Achi Cinema\Movie_Posters";

                if(!Directory.Exists(LocalDir))
                {
                    Directory.CreateDirectory(LocalDir);
                }

                string TargetDir = Path.Combine(LocalDir, Path.GetFileName(imgpath));
                File.Copy(imgpath, TargetDir, true);
                r_img.Image = Image.FromFile(TargetDir);

                using (AchiDBContext ac = new AchiDBContext(Secrets.DB_Path))
                {
                    Movies newMovie = new Movies
                    {
                        ADI = m_name_reg.Text,
                        TUR = genre_comma,
                        SINIFLANDIRMA = rating_comma,
                        BICIM = type_comma,
                        YONETMEN = director_comma,
                        OYUNCU = actor_comma,
                        DETAY = m_detail_reg.Text,
                        PUAN = (int)IMBD.Value,
                        AFIS = TargetDir,
                        VIZYON = r_date.Value,
                    };

                    ac.GetTable<Movies>().InsertOnSubmit(newMovie);

                    ac.SubmitChanges();
                }
            }
        }

        private void director_search_TextChanged(object sender, EventArgs e)
        {
            Director_List.Controls.Clear();
            using (AchiDBContext ac = new AchiDBContext(Secrets.DB_Path))
            {
                var Director_Query = ac.Directors
                    .Where(s => s.AD.Contains(director_search.Text) || s.SOYAD.Contains(director_search.Text))
                    .ToList();

                foreach (var director in Director_Query)
                {
                    DirectorListMovie tool = new DirectorListMovie();

                    tool.ID.Text = director.ID.ToString();
                    tool.director_name.Text = director.AD + " " + director.SOYAD;

                    Director_List.Controls.Add(tool);
                }
            }
        }

        private void actor_search_TextChanged(object sender, EventArgs e)
        {
            Actor_List.Controls.Clear();
            using (AchiDBContext ac = new AchiDBContext(Secrets.DB_Path))
            {
                var Actor_Query = ac.Actors
                    .Where(s => s.AD.Contains(actor_search.Text) || s.SOYAD.Contains(actor_search.Text))
                    .ToList();

                foreach (var actor in Actor_Query)
                {
                    ActorListMovie tool = new ActorListMovie();

                    tool.ID.Text = actor.ID.ToString();
                    tool.actor_name.Text = actor.AD + " " + actor.SOYAD;

                    Actor_List.Controls.Add(tool);
                }
            }
        }

        private void r_img_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
