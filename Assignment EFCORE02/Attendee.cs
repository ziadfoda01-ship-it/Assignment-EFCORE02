using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_EFCORE02
{
    public class Attendee
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [MaxLength(200)]
        [Required]
        public string Email { get; set; }
        [Required]

        [MaxLength(150)]
        
        public string Street { get; set; }
        [MaxLength(100)]
        [Required]
        public string City { get; set; }
        [MaxLength(100)]
        [Required]
        public string Country { get; set; }
        [MaxLength(20)]
        [Required]
        [Column("ZipCode")]
        public string PostCode  { get; set; }
        [MaxLength(150)]
        public string FullName  { get; set; }

        public string fullAddress => $"{Street} ,{City} , {Country} ,{PostCode}";
        public Badge badge { get; set; }




    }
}
