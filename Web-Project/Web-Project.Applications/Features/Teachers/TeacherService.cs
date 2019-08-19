using System.Linq;
using Web_Project.Domain.Features.Teachers;

namespace Web_Project.Applications.Features.Teachers
{
    public class TeacherService : ITeacherService
    {
        private ITeacherRepository _repository;

        public TeacherService(ITeacherRepository repository)
        {
            _repository = repository;
        }
        public TeacherService()
        {

        }
        public Teacher Add(Teacher teacher)
        {
            return _repository.Add(teacher);
        }

        public bool Delete(long teacher)
        {
            return _repository.Delete(teacher);
        }

        public IQueryable<Teacher> GetAll()
        {
            return _repository.GetAll();
        }

        public Teacher GetById(long id)
        {
            Teacher teachers = _repository.GetById(id);
            return teachers;
        }

        public bool Update(Teacher teacher)
        {
            return _repository.Update(teacher);
        }
    }
}
