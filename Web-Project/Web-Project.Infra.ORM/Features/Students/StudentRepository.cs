using System.Data.Entity;
using System.Linq;
using Web_Project.Domain.Base.Exceptions;
using Web_Project.Domain.Features.Students;
using Web_Project.Infra.ORM.Context;

namespace Web_Project.Infra.ORM.Features.Students
{
    public class StudentRepository : IStudentRepository
    {
        private WebProjectContext _context;
        public StudentRepository(WebProjectContext context)
        {
            _context = context;
        }

        public Student Add(Student student)
        {
            _context.Student.Add(student);
            _context.SaveChanges();
            return student;
        }

        public bool Delete(long student)
        {
            var students = _context.Student.Where(c => c.Id == student).FirstOrDefault();
            if (students == null)
                throw new NotFoundException();
            _context.Entry(students).State = EntityState.Deleted;
            return _context.SaveChanges() > 0;
        }

        public IQueryable<Student> GetAll()
        {
            return _context.Student;
        }

        public Student GetById(long id)
        {
            return _context.Student.FirstOrDefault(d => d.Id == id);
        }

        public bool Update(Student student)
        {
            _context.Entry(student).State = EntityState.Modified;
            return _context.SaveChanges() > 0;
        }
    }
}
