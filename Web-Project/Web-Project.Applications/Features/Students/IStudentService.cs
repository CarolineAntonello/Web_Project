using System.Linq;
using Web_Project.Domain.Features.Students;

namespace Web_Project.Applications.Features.Students
{
    public interface IStudentService
    {
        Student Add(Student student);

        bool Update(Student student);

        Student GetById(long id);

        IQueryable<Student> GetAll();

        bool Delete(long student);
    }
}
