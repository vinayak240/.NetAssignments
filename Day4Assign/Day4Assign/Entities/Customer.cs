using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Day4Assign.Entities
{
    public class Customer
    {
        [Key]
        public int Cid { get; set; }
        [Required]
        [StringLength(40)]
        public string Cname { get; set; }
        [Required]
        public string EmailId { get; set; }
        [Required]
        [StringLength(10)]
        public string MobileNo { get; set; }
        public string? City { get; set; }

    }
}
