namespace WCFRESTReportingservice
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WCFEmployee_CFEXDB : DbContext
    {
        public WCFEmployee_CFEXDB()
            : base("name=WCFEmployee_CFEXDB")
        {
        }

        public virtual DbSet<WCFEmployee> WCFEmployees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
