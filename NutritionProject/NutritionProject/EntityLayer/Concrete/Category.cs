﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }


        [StringLength(50)]
        public string CategoryName { get; set; }

        public bool CategoryStatus { get; set; }


        public ICollection<Food>Foods { get; set; }

    }
}
