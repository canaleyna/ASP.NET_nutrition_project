using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Stress
    {
        [Key]
        public int StressID { get; set; }

        [StringLength(50)]
        public string StressName { get; set; }


        public ICollection<UserDay> UserDays { get; set; }
    }
}
