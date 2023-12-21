using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Digestion
    {
        [Key]
        public int DigestionID { get; set; }

        [StringLength(50)]
        public string DigestionName { get; set; }


        public ICollection<UserDayTimeDigestion> UserDayTimeDigestions { get; set; }
    }
}
