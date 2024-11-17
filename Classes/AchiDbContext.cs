using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Achi_Sinema.Tables;
using Sinema_Otomasyonu;

namespace Achi_Sinema.Classes
{
    public class AchiDbContext : DbContext
    {
        public AchiDbContext() : base() { }

        public AchiDbContext(DbContextOptions<AchiDbContext> options) : base(options) { }



        public DbSet<User> Users { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Actor> Actors { get; set; }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Rating> Ratings { get; set; }

        public DbSet<ActorMovie> ActorMovie { get; set; }

        public DbSet<GenreMovie> GenreMovie { get; set; }

        public DbSet<MovieRating> MovieRating { get; set; }



        public static readonly DbContextOptions<AchiDbContext> Options = new DbContextOptionsBuilder<AchiDbContext>().UseSqlServer(Secrets.DB_Path).Options;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Secrets.DB_Path);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActorMovie>()
                .HasKey(am => new { am.MovieActorsActorID, am.ActorMoviesMovieID });

            modelBuilder.Entity<ActorMovie>()
                .HasOne(am => am.Actor)
                .WithMany(a => a.ActorMovies)
                .HasForeignKey(am => am.MovieActorsActorID);

            modelBuilder.Entity<ActorMovie>()
                .HasOne(am => am.Movie)
                .WithMany(m => m.MovieActors)
                .HasForeignKey(am => am.ActorMoviesMovieID);

            modelBuilder.Entity<GenreMovie>()
                .HasKey(gm => new { gm.MovieGenresGenreID, gm.GenreMoviesMovieID });

            modelBuilder.Entity<GenreMovie>()
                .HasOne(gm => gm.Genre)
                .WithMany(g => g.GenreMovies)
                .HasForeignKey(gm => gm.MovieGenresGenreID);

            modelBuilder.Entity<GenreMovie>()
                .HasOne(gm => gm.Movie)
                .WithMany(m => m.MovieGenres)
                .HasForeignKey(gm => gm.GenreMoviesMovieID);

            modelBuilder.Entity<MovieRating>()
                .HasKey(mr => new { mr.RatingMoviesMovieID, mr.MovieRatingsRatingId });

            modelBuilder.Entity<MovieRating>()
                .HasOne(mr => mr.Rating)
                .WithMany(r => r.RatingMovies)
                .HasForeignKey(mr => mr.MovieRatingsRatingId);

            modelBuilder.Entity<MovieRating>()
                .HasOne(mr => mr.Movie)
                .WithMany(m => m.MovieRatings)
                .HasForeignKey(mr => mr.RatingMoviesMovieID);

            modelBuilder.Entity<Movie>()
                .HasOne(m => m.MovieDirector)
                .WithMany(d => d.Movies)
                .HasForeignKey(m => m.MovieDirectorDirectorID)
                .OnDelete(DeleteBehavior.SetNull);

            List<Genre> genres = new List<Genre>();
            genres.Add(new Genre {GenreName = "Aksiyon" , GenreID = 1});
            genres.Add(new Genre {GenreName = "Dram" , GenreID = 2 });
            genres.Add(new Genre { GenreName = "Komedi" , GenreID = 3 });
            genres.Add(new Genre { GenreName = "Korku", GenreID = 4 });
            genres.Add(new Genre { GenreName = "Bilim Kurgu", GenreID = 5});
            genres.Add(new Genre { GenreName = "Fantastik", GenreID = 6 });
            genres.Add(new Genre { GenreName = "Macera", GenreID = 7});
            genres.Add(new Genre { GenreName = "Romantik", GenreID = 8});
            genres.Add(new Genre { GenreName = "Belgesel", GenreID = 9});
            genres.Add(new Genre { GenreName = "Romantik", GenreID = 10});
            genres.Add(new Genre { GenreName = "Bilim Kurgu", GenreID = 11});
            genres.Add(new Genre { GenreName = "Gerilim", GenreID = 12});
            genres.Add(new Genre { GenreName = "Gizem", GenreID = 13 });
            genres.Add(new Genre { GenreName = "Polisye", GenreID = 14});
            genres.Add(new Genre { GenreName = "Savaş", GenreID = 15});
            genres.Add(new Genre { GenreName = "Animasyon", GenreID = 16});
            genres.Add(new Genre { GenreName = "Çocuk", GenreID = 17});
            genres.Add(new Genre { GenreName = "Müzikal", GenreID = 18});
            genres.Add(new Genre { GenreName = "Tarih", GenreID = 19});

            List<Rating> ratingList = new List<Rating>();
            ratingList.Add(new Rating { RatingName = "6 Yaş Altı" , RatingId = 1});
            ratingList.Add(new Rating { RatingName = "6 Yaş Üstü", RatingId = 2 });
            ratingList.Add(new Rating { RatingName = "10 Yaş Altı", RatingId = 3 });
            ratingList.Add(new Rating { RatingName = "10 Yaş Üstü", RatingId = 4 });
            ratingList.Add(new Rating { RatingName = "13 Yaş Altı", RatingId = 5});
            ratingList.Add(new Rating { RatingName = "13 Yaş Üstü", RatingId = 6});
            ratingList.Add(new Rating { RatingName = "16 Yaş Üstü", RatingId = 7});
            ratingList.Add(new Rating { RatingName = "18 Yaş Üstü", RatingId = 8});
            ratingList.Add(new Rating { RatingName = "Genel İzleyici Kitlesi", RatingId = 9 });
            ratingList.Add(new Rating { RatingName = "Şiddet/Korku", RatingId = 10});
            ratingList.Add(new Rating { RatingName = "Cinsellik/Çıplaklık", RatingId = 11 });
            ratingList.Add(new Rating { RatingName = "Olumsuz Örnek", RatingId = 12});


            foreach (var rating in ratingList)
            {
                modelBuilder.Entity<Rating>().HasData(rating);
            }

            foreach (var genre in genres)
            {
                modelBuilder.Entity<Genre>().HasData(genre);
            }

            modelBuilder.Entity<User>().HasData(
                new User
                {      
                    StaffID = 1,
                    StaffName = "Atilla Burak",
                    StaffSurname = "Artıran",
                    StaffLogin = "atilla",
                    StaffPassword = "12345"
                }
            );
        }
    }
}
