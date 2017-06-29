namespace HebbraCo_Lib
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class task4Model : DbContext
    {
        public task4Model()
            : base("name=task4Model")
        {
        }

        public virtual DbSet<skillStaff> skillStaffs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<skillStaff>()
                .Property(e => e.skillCode)
                .IsFixedLength();

            modelBuilder.Entity<skillStaff>()
                .Property(e => e.staffName)
                .IsFixedLength();
        }
    }
}
