using System.Data.Entity;
using System.Linq;
using Web_Project.Domain.Base.Exceptions;
using Web_Project.Domain.Features.Teachers;
using Web_Project.Infra.ORM.Context;

namespace Web_Project.Infra.ORM.Features.Teachers
{
    public class TeacherRepository : ITeacherRepository
    {
        private WebProjectContext _context;
        public TeacherRepository(WebProjectContext context)
        {
            _context = context;
        }

        public Teacher Add(Teacher teacher)
        {
            _context.Teacher.Add(teacher);
            _context.SaveChanges();
            return teacher;
        }

        public bool Delete(long teacher)
        {
            var teachers = _context.Student.Where(c => c.Id == teacher).FirstOrDefault();
            if (teachers == null)
                throw new NotFoundException();
            _context.Entry(teachers).State = EntityState.Deleted;
            return _context.SaveChanges() > 0;
        }

        public IQueryable<Teacher> GetAll()
        {
            return _context.Teacher;
        }

        public Teacher GetById(long id)
        {
            return _context.Teacher.FirstOrDefault(d => d.Id == id);
        }

        public bool Update(Teacher teacher)
        {
            _context.Entry(teacher).State = EntityState.Modified;
            return _context.SaveChanges() > 0;
        }
    }
}
