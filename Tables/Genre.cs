using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achi_Sinema.Tables
{
    public class Genre
    {
        [Key] public int GenreID { get; set; }

        public string GenreName { get; set; }

        public ICollection<Movie> GenreMovies { get; set; }
    }
}
