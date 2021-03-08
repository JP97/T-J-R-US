using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TØJ_R_US.Models
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ID { get; set; }

        public string Name { get; set; }

        // 1 = mand,2 = dame og 3 = børn 
        public int Category { get; set; }

        public string Type { get; set; }

        public string Description { get; set; }

        public int Size { get; set; }

        public string Color { get; set; }

        public double Price { get; set; }

    }
}
