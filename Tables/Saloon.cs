using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achi_Sinema.Tables
{
    public class Saloon
    {
        [Key] public int SaloonID { get; set; }

        public string SaloonName { get; set; }

        public int SaloonCap { get; set; }
    }
}
