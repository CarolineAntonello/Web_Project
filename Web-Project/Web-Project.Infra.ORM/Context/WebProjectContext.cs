using System.Data.Common;
using System.Data.Entity;
using System.Diagnostics.CodeAnalysis;
using Web_Project.Domain.Features.Students;
using Web_Project.Domain.Features.Teachers;

namespace Web_Project.Infra.ORM.Context
{
    [ExcludeFromCodeCoverage]
    public class WebProjectContext : DbContext
    {
        public DbSet<Student> Student { get; set; }

        public DbSet<Teacher> Teacher { get; set; }

        public WebProjectContext() : base("WebProjectDb")
        {
            Configuration.LazyLoadingEnabled = true;
        }

        public WebProjectContext(DbConnection connection) : base(connection, true) { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(System.Reflection.Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
