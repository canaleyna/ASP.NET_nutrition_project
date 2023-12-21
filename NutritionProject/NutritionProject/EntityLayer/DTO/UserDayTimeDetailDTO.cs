using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.DTO
{
    public class UserDayTimeDetailDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DayName { get; set; }
        public string DayTimeName { get; set; }
        public string FoodName { get; set; }
        public int Calori { get; set; }
        public string Digestion { get; set; }
    }
}
