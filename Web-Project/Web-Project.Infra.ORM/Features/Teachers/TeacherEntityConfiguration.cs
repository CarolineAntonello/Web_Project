using System.Data.Entity.ModelConfiguration;
using Web_Project.Domain.Features.Teachers;

namespace Web_Project.Infra.ORM.Features.Teachers
{
    public class TeacherEntityConfiguration : EntityTypeConfiguration<Teacher>
    {
        public TeacherEntityConfiguration()
        {
            this.ToTable("TBTeacher");
            this.HasKey(o => o.Id);
            Property(o => o.Name);
        }
    }
}
