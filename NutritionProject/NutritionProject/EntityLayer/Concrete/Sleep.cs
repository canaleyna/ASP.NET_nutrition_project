using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Sleep
    {
        [Key]
        public int SleepID { get; set; }
        public int SleepHour { get; set; }


        public ICollection<UserDay> UserDays { get; set; }
    }
}
