namespace HebbraCo_Lib
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("skillStaff")]
    public partial class skillStaff
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string skillCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string staffName { get; set; }
    }
}
