using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class DayTime
    {
        [Key]
        public int DayTimeID { get; set; }

        [StringLength(50)]
        public string DayTimeName { get; set; }

        public ICollection<UserDayTime> UserDayTimes { get; set; }
    }
}
