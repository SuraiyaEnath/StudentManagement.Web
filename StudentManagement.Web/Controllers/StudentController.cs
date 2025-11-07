using Microsoft.AspNetCore.Mvc;
using StudentManagement.BLL.Services;
using StudentManagement.Model;

namespace StudentManagement.Web.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentServices _service;

        public StudentController(StudentServices services)
        {
            _service = services;
        }
        public IActionResult Index()
        {
            var students = _service.GetAllStudents();
            return View(students);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _service.AddStudent(student);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}

