using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class UserDayTimeDigestion
    {
        [Key]
        public int UserDayTimeDigestionID { get; set; }


        public int UserDayTimeID { get; set; }
        public virtual UserDayTime UserDayTime { get; set; }
        

        public int DigestionID { get; set; }
        public virtual Digestion Digestion { get; set; }
    }
}
