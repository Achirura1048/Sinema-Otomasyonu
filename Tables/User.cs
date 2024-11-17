using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace Achi_Sinema.Tables
{

    public class User
    {

        [Key] public int StaffID { get; set; }

        public string StaffName { get; set; }

        public string StaffSurname { get; set; }

        public string StaffLogin { get; set; }

        public string StaffPassword { get; set; }
    }
}
