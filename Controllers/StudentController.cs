using CourseRegistration.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepo _repo;
        private readonly ICourseRepo _courseRepo;

        public StudentController(IStudentRepo repo, ICourseRepo courseRepo)
        {
            _repo = repo;
            _courseRepo = courseRepo;
        }
        public IActionResult Index()
        {
            return View(_repo.GetAll());
        }

        public IEnumerable<string> GetStudentById(int? id)
        {
            var res = _repo.GetAll().Where(s => s.StudentID == id)
                .Select(n => n.LastName + ",\t " + n.FirstName + "<br />");

            if (res == null || res.Count() == 0) 
            {
                return new List<string> { "No student found." };
            }
            return res;
        }

        public IEnumerable<string> GetStudentByCourseID(int? id)
        {
            var res = _repo.GetAll().Where(s => s.CourseID == id)
                .Select(n => n.LastName + ",\t " + n.FirstName + "<br />");
            if (res == null || res.Count() == 0)
            {
                return new List<string> { "No Students found under this Course Subject" };
            }
            return res;
        }



        public IActionResult Create()
        {
            var course = _courseRepo.GetAll().ToList();
            ViewBag.Course = new SelectList(course, "CourseID", "Name");
            return View();
        }

        [HttpPost]
        public ActionResult Create(Students students)
        {
            _repo.Create(students);
            return RedirectToAction("Index");
        }
    }
}
