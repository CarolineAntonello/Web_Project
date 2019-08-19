using System.Linq;
using Web_Project.Domain.Features.Students;

namespace Web_Project.Applications.Features.Students
{
    public class StudentService : IStudentService
    {
        private IStudentRepository _repository;

        public StudentService(IStudentRepository repository)
        {
            _repository = repository;
        }

        public Student Add(Student student)
        {
            return _repository.Add(student);
        }

        public bool Delete(long student)
        {
            return _repository.Delete(student);
        }

        public IQueryable<Student> GetAll()
        {
            return _repository.GetAll();
        }

        public Student GetById(long id)
        {
            Student students = _repository.GetById(id);
            return students;
        }

        public bool Update(Student student)
        {
            return _repository.Update(student);
        }
    }
}
