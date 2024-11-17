using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achi_Sinema.Tables
{
    public class Rating
    {
        [Key] public int RatingId { get; set; }

        public string RatingName { get; set; }

        public ICollection<Movie> RatingMovies { get; set; }
    }
}
