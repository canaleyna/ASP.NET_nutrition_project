using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class UserDay
    {
        [Key]
        public int UserDayID { get; set; }


        public int UserID { get; set; }
        public virtual User User { get; set; }


        public int DayID { get; set; }
        public virtual Day Day { get; set; }


        public int WaterAmountID { get; set; }
        public virtual WaterAmount WaterAmount { get; set; }


        public int StressID { get; set; }
        public virtual Stress Stress { get; set; }


        public int SleepID { get; set; }
        public virtual Sleep Sleep { get; set; }


        public int StepCount { get; set; }
    }
}
