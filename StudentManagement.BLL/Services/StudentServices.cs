

using StudentManagement.DAL.Repository;
using StudentManagement.Model;

namespace StudentManagement.BLL.Services
{
    public class StudentServices
    {
        private readonly StudentRepository _studentRepository;
        public StudentServices(StudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _studentRepository.GetAll();
        }
        public void AddStudent(Student student)
        {
            // Business Logic
            _studentRepository.Add(student);
        }
    }
}
