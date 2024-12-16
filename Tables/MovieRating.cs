namespace Achi_Sinema.Tables
{
    public class MovieRating
    {
        public int MovieRatingsRatingId { get; set; }

        public int RatingMoviesMovieID { get; set; }

        public Rating Rating { get; set; }

        public Movie Movie { get; set; }

    }
}