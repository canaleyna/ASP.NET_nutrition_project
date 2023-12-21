using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class BadHabbit
    {
        [Key]
        public int BadHabbitID { get; set; }

        [StringLength(50)]
        public string BadHabbitName { get; set; }


        public bool BadHabbitStatus { get; set; }

        public ICollection<UserDetail> UserDetails { get; set; }
    }
}
