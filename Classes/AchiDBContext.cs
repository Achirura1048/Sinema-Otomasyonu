using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq.Mapping;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using Sinema_Otomasyonu.Classes.Tables;

namespace Sinema_Otomasyonu.Classes
{
    public class AchiDBContext : DataContext
    {
        public AchiDBContext(string connenction) : base(connenction) { }

        public Table<Users> Users => GetTable<Users>();
        public Table<Directors> Directors => GetTable<Directors>();
        public Table<Actors> Actors => GetTable<Actors>();
        public Table<Saloons> Saloons => GetTable<Saloons>();
        public Table<Movies> Movies => GetTable<Movies>();
    }
}
