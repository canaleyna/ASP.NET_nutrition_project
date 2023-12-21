using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Day
    {
        [Key]
        public int DayID { get; set; }

        [StringLength(50)]
        public string DayName { get; set; }

        public ICollection<UserDay> UserDays { get; set; }
        public ICollection<UserDayTime> UserDayTimes { get; set; }
    }
}
