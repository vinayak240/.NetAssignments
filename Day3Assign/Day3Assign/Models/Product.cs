using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Day3Assign.Models
{
    public class Product
    {
        [Required(ErrorMessage = "Product ID Required")]
        public string pid { get; set; }
        [Required(ErrorMessage = "Product Name Required")]
        public string pname { get; set; }
        [Required(ErrorMessage = "Product Price Required")]
        public int price { get; set; }
        [Required(ErrorMessage = "Product Stock Required")]
        public int stock { get; set; }

    }
}
