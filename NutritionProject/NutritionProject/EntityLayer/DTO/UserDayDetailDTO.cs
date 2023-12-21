using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.DTO
{
     public class UserDayDetailDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DayName { get; set; }
        public int Water { get; set; }
        public int Sleep { get; set; }
        public int Step { get; set; }
        public string Stress { get; set; }
    }
}
