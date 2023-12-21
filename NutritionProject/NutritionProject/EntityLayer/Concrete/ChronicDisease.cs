using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ChronicDisease
    {
        [Key]
        public int ChronicDiseaseID { get; set; }

        [StringLength(50)]
        public string ChronicDiseaseName { get; set; }

        public bool ChronicDiseaseStatus { get; set; }

        public ICollection<UserDetail> UserDetails { get; set; }
    }
}
