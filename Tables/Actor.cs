using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Achi_Sinema.Classes;

namespace Achi_Sinema.Tables
{
    public class Actor
    {
        [Key] public int ActorID { get; set; }

        public string ActorName { get; set; }

        public string ActorSurname { get; set; }

        public DateTime ActorBirthDate { get; set; }

        public string ActorGender { get; set; }

        public string ActorBiography { get; set; }

        public string ActorImage { get; set; }

        public ICollection<ActorMovie> ActorMovies { get; set; }
    }
}
