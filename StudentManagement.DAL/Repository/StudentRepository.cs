

using Microsoft.EntityFrameworkCore;
using StudentManagement.Model;

namespace StudentManagement.DAL.Repository
{
    public class StudentRepository
    {
        private readonly StudentManagementDbContext _context;
        public StudentRepository(StudentManagementDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Student> GetAll()
        {
            var query = _context.Students;
            var queryString = query.ToQueryString();

            return query.ToList();
        }
        public void Add(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }
    }
}
