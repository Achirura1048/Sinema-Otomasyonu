using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinema_Otomasyonu.Classes.Tables
{
    [Table(Name = "Director_Info")]
    public class Directors
    {
        [Column(IsPrimaryKey =true , IsDbGenerated = true)]
        public int ID { get; set; }

        [Column]
        public string AD { get; set; }

        [Column]
        public string SOYAD { get; set; }

        [Column]
        public char CINSIYET { get; set; }

        [Column]
        public DateTime DOGUM { get; set; }

        [Column]
        public string RESIM { get; set; }

        [Column]
        public string BIO { get; set; }

    }
}
