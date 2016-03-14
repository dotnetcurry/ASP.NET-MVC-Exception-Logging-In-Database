namespace MVC_LoggingExcepion_with_ExceptionFilter.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ApplicationModel : DbContext
    {
        public ApplicationModel()
            : base("name=ApplicationModel")
        {
            

        }

        public DbSet<EmployeeInfo> Employees { get; set; }
        public DbSet<ExceptionLogger> ExceptionLoggers{ get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
