using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinema_Otomasyonu.Classes.Tables
{
    [Table(Name = "Saloon_Info")]
    public class Saloons
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int ID { get; set; }

        [Column]
        public string SALONADI { get; set; }

        [Column]
        public int KOLTUKSAYISI { get; set; }
    }
}
