using Achi_Sinema.Tables;

namespace Achi_Sinema.Classes
{
    public class MovieRating
    {
        public int MovieRatingsRatingId { get; set; }

        public int RatingMoviesMovieID { get; set; }

        public Rating Rating { get; set; }

        public Movie Movie { get; set; }

    }
}