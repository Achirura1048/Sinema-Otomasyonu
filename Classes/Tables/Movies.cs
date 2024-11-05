using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinema_Otomasyonu.Classes.Tables
{
    [Table(Name = "Movie_Info")]
    public class Movies
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int ID { get; set; }

        [Column]
        public string ADI { get; set; }

        [Column]
        public string TUR { get; set; }

        [Column]
        public string SINIFLANDIRMA { get; set; }

        [Column]
        public string BICIM { get; set; }

        [Column]
        public string YONETMEN { get; set; }

        [Column]
        public string OYUNCU { get; set; }

        [Column]
        public string DETAY { get; set; }

        [Column]
        public int PUAN { get; set; }

        [Column]
        public string AFIS { get; set; }

        [Column]
        public DateTime VIZYON { get; set; }
    }
}
