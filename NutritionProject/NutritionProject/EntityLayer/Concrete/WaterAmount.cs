using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class WaterAmount
    {
        [Key]
        public int WaterAmountID { get; set; }
        public int Glass { get; set; }


        public ICollection<UserDay> UserDays { get; set; }
    }
}
