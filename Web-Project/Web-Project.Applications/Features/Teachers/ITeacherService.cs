using System.Linq;
using Web_Project.Domain.Features.Teachers;

namespace Web_Project.Applications.Features.Teachers
{
    public interface ITeacherService
    {
        Teacher Add(Teacher teacher);

        bool Update(Teacher teacher);

        Teacher GetById(long id);

        IQueryable<Teacher> GetAll();

        bool Delete(long teacher);
    }
}
