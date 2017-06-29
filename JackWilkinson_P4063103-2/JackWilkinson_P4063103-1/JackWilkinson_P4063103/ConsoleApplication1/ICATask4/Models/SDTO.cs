using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ICATask4.Models
{
    public class SDTO
    {

        [Required]
        [StringLength(50)]
        public string staffCode { get; set; }

        [Required]
        public string firstName { get; set; }

        [Required]
        public string middleName { get; set; }

        [Required]
        public string lastName { get; set; }

    }
}