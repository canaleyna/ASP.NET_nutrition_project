using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Surname { get; set; }

        [StringLength(200)]
        public string Email { get; set; }

        [StringLength(200)]
        public string Password { get; set; }

        [StringLength(100)]
        public string Image { get; set; }

        [StringLength(100)]
        public string UserAbout { get; set; }


        [StringLength(50)]
        public string UserTitle { get; set; }


        public bool UserStatus { get; set; }






        public ICollection<UserDay> UserDays { get; set; }
        public ICollection<UserDayTime> UserDayTimes { get; set; }
        public ICollection<UserDetail> UserDetails { get; set; }

    }
}
