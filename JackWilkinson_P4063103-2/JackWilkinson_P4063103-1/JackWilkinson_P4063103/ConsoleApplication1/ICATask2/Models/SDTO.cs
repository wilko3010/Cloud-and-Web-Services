using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ICATask2.Models
{
    public class SDTO
    {
        public int staffId { get; set; }

        public int businessUnitId { get; set; }

        [Required]
        [StringLength(50)]
        public string staffCode { get; set; }

        [Required]
        public string firstName { get; set; }

        [Required]
        public string middleName { get; set; }

        [Required]
        public string lastName { get; set; }

        [Column(TypeName = "date")]
        public DateTime dob { get; set; }

        [Column(TypeName = "date")]
        public DateTime startDate { get; set; }

        public string profile { get; set; }

        [Required]
        public string emailAddress { get; set; }
    }
}