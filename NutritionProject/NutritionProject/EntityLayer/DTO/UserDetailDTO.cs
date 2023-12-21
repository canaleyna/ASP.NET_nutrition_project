using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.DTO
{
    public class UserDetailDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public double BodyMassIndex { get; set; }
        public string BadHabbitName { get; set; }
        public string ChronicDiseaseName { get; set; }
    }
}
