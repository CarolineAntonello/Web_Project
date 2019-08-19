using System.Linq;

namespace Web_Project.Domain.Features.Teachers
{
    public interface ITeacherRepository
    {
        Teacher Add(Teacher teacher);

        bool Update(Teacher teacher);

        Teacher GetById(long id);

        IQueryable<Teacher> GetAll();

        bool Delete(long teacher);
    }
}
