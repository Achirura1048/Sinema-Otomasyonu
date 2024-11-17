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

        public ICollection<Genre> MovieGenres { get; set; }

        public Director MovieDirector { get; set; }

        public ICollection<Actor> MovieActors { get; set; }

        public DateTime MovieRelase { get; set; }

        public string MovieIMBDRating { get; set; }
        
        public ICollection<Rating> MovieRatings { get; set; }

        public string MoviePoster { get; set; }

        public string MovieSummary { get; set; }
    }
}
