using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Threading.Tasks;

namespace Sinema_Otomasyonu.Classes
{
    [Table(Name = "User_Info")]
    public class Users
    {
        

            [Column(IsPrimaryKey = true, IsDbGenerated = true)]
            public int ID { get; set; }  

            [Column]
            public string KADI { get; set; }  

            [Column]
            public string KSIFRE { get; set; }  

            [Column]
            public string AD { get; set; }  

            [Column]
            public string SOYAD { get; set; }  
        
    }
}
