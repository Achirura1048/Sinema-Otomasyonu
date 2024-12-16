using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Achi_Sinema.Tables
{
    public class Movie
    {
        [Key] public int MovieID { get; set; }

        public string MovieName { get; set; }

        public ICollection<GenreMovie> MovieGenres { get; set; }

        public int MovieDirectorDirectorID { get; set; }
        public Director MovieDirector { get; set; }

        public ICollection<ActorMovie> MovieActors { get; set; }

        public DateTime MovieRelase { get; set; }

        public string MovieIMBDRating { get; set; }
        
        public ICollection<MovieRating> MovieRatings { get; set; }

        public string MoviePoster { get; set; }

        public string MovieSummary { get; set; }

    }
}
