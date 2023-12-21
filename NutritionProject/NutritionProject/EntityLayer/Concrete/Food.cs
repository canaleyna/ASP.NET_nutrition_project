using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Food
    {
        [Key]
        public int FoodID { get; set; }

        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }


        [StringLength(50)]
        public string FoodName { get; set; }

        public int FoodCalorie { get; set; }

        public bool FoodStatus { get; set; }


        public ICollection<UserDayTime> UserDayTimes { get; set; }
    }
}
