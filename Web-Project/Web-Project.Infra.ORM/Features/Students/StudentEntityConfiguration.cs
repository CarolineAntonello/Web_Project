using System.Data.Entity.ModelConfiguration;
using Web_Project.Domain.Features.Students;

namespace Web_Project.Infra.ORM.Features.Students
{
    public class StudentEntityConfiguration : EntityTypeConfiguration<Student>
    {
        public StudentEntityConfiguration()
        {
            this.ToTable("TBStudent");
            this.HasKey(o => o.Id);
            Property(o => o.Name);
            Property(a => a.Teacher.Id).HasColumnName("Teacher_Id").IsOptional();
            HasOptional(e => e.Teacher).WithMany().HasForeignKey(a => a.Teacher.Id);
        }
    }
}
