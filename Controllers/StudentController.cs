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
        private readonly IStudentCourseRepo _sc;

        public StudentController(IStudentRepo repo, ICourseRepo courseRepo, IStudentCourseRepo sc)
        {
            _repo = repo;
            _courseRepo = courseRepo;
            _sc = sc; //StudentCourseRepo Interface
        }
        public IActionResult Index()
        {
            return View(_repo.GetAll());
        }

        //javascript function
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

        public IActionResult Create()
        {
            var course = _courseRepo.GetAll().ToList();
            ViewBag.Course = new SelectList(course, "CourseID", "Name");
            return View();
        }

        //[HttpPost]
        //public ActionResult Create(Students students)
        //{
        //    _repo.Create(students);
        //    return RedirectToAction("Index");
        //}
        [HttpPost]
        public ActionResult Create(StudentCourse sc, Students students)
        {
            _repo.Create(students);
            int newID = students.StudentID;
            sc.StudentID = newID;
            _sc.Create(sc);
            return RedirectToAction("Index");
        }

        //public IEnumerable<string> GetStudentByCourseID(int ID)
        //{
        //    return new List<string> { "no students found" };

        //}

        public string GetStudentByCourseID(int ID)
        {
            return "Cant figure out how to show students by courseID using LINQ";
        }


    }
}
