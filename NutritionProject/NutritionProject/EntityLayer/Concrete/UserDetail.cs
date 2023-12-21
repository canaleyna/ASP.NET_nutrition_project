using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class UserDetail
    {
        [Key]
        public int UserDetailID { get; set; }


        public int UserID { get; set; }
        public virtual User User { get; set; }


        public int Age { get; set; }


        [StringLength(50)]
        public string Sex { get; set; }

        public float Height { get; set; }

        public float Weight {get; set; }

        public float BodyMassIndexValue { get; set; }


        public int BadHabbitID { get; set; }
        public virtual BadHabbit BadHabbit { get; set; }


        public int ChronicDiseaseID { get; set; }
        public virtual ChronicDisease ChronicDisease { get; set; }

        

    }
}
