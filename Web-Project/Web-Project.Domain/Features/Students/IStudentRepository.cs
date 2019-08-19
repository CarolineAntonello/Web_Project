using System.Linq;

namespace Web_Project.Domain.Features.Students
{
    public interface IStudentRepository
    {
        Student Add(Student student);

        bool Update(Student student);

        Student GetById(long id);

        IQueryable<Student> GetAll();

        bool Delete(long student);
    }
}
