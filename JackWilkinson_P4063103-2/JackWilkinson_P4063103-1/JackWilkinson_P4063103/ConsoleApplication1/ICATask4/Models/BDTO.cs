using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ICATask4.Models
{
    public class BDTO
    {
        
      
        public string businessUnitCode { get; set; }

        [Required]
        [StringLength(50)]
        public string title { get; set; }

    }
}

