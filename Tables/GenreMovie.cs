namespace Achi_Sinema.Tables
{
    public class GenreMovie
    {
        public int GenreMoviesMovieID { get; set; }

        public int MovieGenresGenreID { get; set; }

        public Movie Movie { get; set; }

        public Genre Genre { get; set; }
    }
}