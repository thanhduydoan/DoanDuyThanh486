using System.Collections;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    [Table("UniversityDDT486")]
    public class UniversityDDT486
    {
        [Key]
        [StringLength(20)]
        public string UniversityId { get; set; }
        [StringLength(50)]
        public string UniversityName { get; set; }
    }
}