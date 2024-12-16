using Achi_Sinema.Classes;
using Achi_Sinema.Forms.Movie;
using Sinema_Otomasyonu.Forms.Actor;
using Sinema_Otomasyonu.Forms.Movie;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using OfficeOpenXml;
using Achi_Sinema.Tables;
using Microsoft.VisualBasic.Devices;


namespace Sinema_Otomasyonu
{
    public partial class MainPage : Form
    {
        public static string name;
        public static string surname;
        public MainPage()
        {
            InitializeComponent();
        }

        private void ex_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void min_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            label2.Text = "Hoş Geldin " + name + " " + surname.ToUpper();
        }

        public void adminreg_Click(object sender, EventArgs e)
        {
            DirectorReg DrcReg = new DirectorReg();

            Functions.ShowFormCentered(DrcReg, panel1, panel2, panel3);

        }

        private void adminreg_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void DrcList_Click(object sender, EventArgs e)
        {
            DirectorList DrcList = new DirectorList();
            Functions.ShowFormCentered(DrcList, panel1, panel2, panel3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActorReg ActReg = new ActorReg();
            Functions.ShowFormCentered(ActReg, panel1, panel2, panel3);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Act_List_Click(object sender, EventArgs e)
        {
            ActorList ActList = new ActorList();
            Functions.ShowFormCentered(ActList, panel1, panel2, panel3);

        }

        private void Saloon_Reg_Click(object sender, EventArgs e)
        {
            // SaloonReg SalReg = new SaloonReg();
            //Functions.ShowFormCentered(SalReg, panel1, panel2, panel3);
        }

        private void movie_reg_Click(object sender, EventArgs e)
        {
            MovieReg movieReg = new MovieReg();
            Functions.ShowFormCentered(movieReg, panel1, panel2, panel3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MovieList movieList = new MovieList();
            Functions.ShowFormCentered(movieList, panel1, panel2, panel3);
        }

        private void excel_report_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.Commercial;
            using (var ac = new AchiDbContext(AchiDbContext.Options))
            {
                    var Movies = ac.Movies
                    .Select(s => new
                    {
                        s.MovieName,
                        s.MovieDirector,
                        s.MovieActors,
                        s.MovieID,
                    })
                    .ToList();

                var Directors = ac.Directors
                  .Select(s => new
                  {
                     s.DirectorName,
                     s.DirectorSurname,
                     s.DirectorID,
                     Movies = s.Movies.Select(m => new
                     {
                       m.MovieID,
                       m.MovieName

                     }).ToList()

                   }) .ToList();

                var Actors = ac.Actors
                 .Select(a => new
                 {
                    a.ActorName,
                    a.ActorSurname,
                    a.ActorMovieCount, // Already in your database
                    Movies = a.ActorMovies.Select(am => new
                    {
                       am.Movie.MovieID,
                       am.Movie.MovieName
                    }).ToList()
                  }).ToList();

                using (var package = new ExcelPackage())
                {
                    var sheet1 = package.Workbook.Worksheets.Add("Filmler");

                    int column = 1;

                    foreach (var movie in Movies)
                    {
                        sheet1.Cells[1, column].Value = movie.MovieName;
                        sheet1.Cells[2, column].Value = (movie.MovieDirector.DirectorName+ " " + movie.MovieDirector.DirectorSurname).ToUpper();
                        column++;
                    }

                    int row = 3;
                    
                    int all_actors =Movies.Max(a => a.MovieActors.Count);

                    for (int i = 0; i < all_actors; i++)
                    {
                        column = 1;
                        
                        foreach (var movie in Movies)
                        {
                            var actor = ac.ActorMovie
                                .Where(acm => acm.ActorMoviesMovieID == movie.MovieID)
                                .Select(acm => acm.Actor)
                                .ElementAtOrDefault(i);



                            if (actor != null)
                            {
                                sheet1.Cells[row, column].Value = actor.ActorName + " " + actor.ActorSurname;
                            }
                            column++;
                        }
                        row++;
                    }
                    sheet1.Cells.AutoFitColumns();

                    var sheet2 = package.Workbook.Worksheets.Add("Yönetmenler");

                    for (int col_dr = 0; col_dr < Directors.Count; col_dr++)
                    {
                        sheet2.Cells[1, col_dr + 1].Value = Directors[col_dr].DirectorName + " " + Directors[col_dr].DirectorSurname;
                    }

                    int all_movies = Directors.Max(d => d.Movies.Count);

                    for(int row_dr = 0; row_dr < all_movies; row_dr++)
                    {
                        for (int col_dr = 0; col_dr < Directors.Count; col_dr++)
                        {
                            var movies = Directors[col_dr].Movies;
                            if (row_dr < movies.Count)
                            {
                                sheet2.Cells[row_dr + 2, col_dr + 1].Value = movies[row_dr].MovieName;
                            }
                        }
                    }

                    for (int col_dr = 0; col_dr < Directors.Count; col_dr++)
                    {
                        sheet2.Cells[all_movies + 2, col_dr + 1].Value = $"Movie Count: {Directors[col_dr].Movies.Count}";
                    }
                    sheet2.Cells.AutoFitColumns();

                    var sheet3 = package.Workbook.Worksheets.Add("Oyuncular");

                    for(int col_ac = 0; col_ac < Actors.Count; col_ac++)
                    {
                        sheet3.Cells[1, col_ac + 1].Value = Actors[col_ac].ActorName + " " + Actors[col_ac].ActorSurname;
                    }

                    int all_movies_ac = Actors.Max(a => a.Movies.Count);

                    for (int row_ac = 0; row_ac < all_movies_ac; row_ac++)
                    {
                        for (int col_ac = 0; col_ac < Actors.Count; col_ac++)
                        {
                            var movies = Actors[col_ac].Movies;
                            if (row_ac < movies.Count)
                            {
                                sheet3.Cells[row_ac + 2, col_ac + 1].Value = movies[row_ac].MovieName;
                            }
                        }
                    }

                    for (int col_ac = 0; col_ac < Actors.Count; col_ac++)
                    {
                        sheet3.Cells[all_movies_ac + 2, col_ac + 1].Value = $"Oynanılan Filmler Toplamı: {Actors[col_ac].Movies.Count}";
                    }
                        sheet3.Cells.AutoFitColumns();

                    var directoryPath = Path.Combine(Application.StartupPath, "RAPOR");
                    if (!Directory.Exists(directoryPath))
                    {
                        Directory.CreateDirectory(directoryPath);
                    }

                    var timestamp = DateTime.Now.ToString("dd.MM.yy" + " , " + "HH-mm-ss");
                    var fileName = $"Rapor - {timestamp}.xlsx";
                    var fileinfo = new FileInfo(Path.Combine(directoryPath, fileName));
                    package.SaveAs(fileinfo);

                    MessageBox.Show("Rapor başarıyla oluşturuldu.");    


                }
                
            }
        }
    }
}
