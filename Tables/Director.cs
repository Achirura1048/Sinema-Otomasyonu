using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace Achi_Sinema.Tables
{
    public class Director
    {
        [Key] public int DirectorID { get; set; }

        public string DirectorName { get; set; }

        public string DirectorSurname { get; set; }

        public DateTime DirectorBirthDate { get; set; }

        public string DirectorGender { get; set; }

        public string DirectorBiography { get; set; }

        public string DirectorImage { get; set; }

        public ICollection<Movie> Movies { get; set; }

    }
}
