using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class UserDayTime
    {

        [Key]
        public int UserDayTimeID { get; set; }


        public int UserID { get; set; }
        public virtual User User { get; set; }


        public int DayID { get; set; }
        public  virtual Day Day { get; set; }


        public int DayTimeID { get; set; }
        public virtual DayTime DayTime { get; set; }


        public int FoodID { get; set; }
        public virtual Food Food { get; set; }



        public ICollection<UserDayTimeDigestion> UserDayTimeDigestions { get; set; }
    }
}
