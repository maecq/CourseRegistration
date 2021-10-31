using CourseRegistration.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Controllers
{
    public class InstructorController : Controller
    {
        private readonly IInstructorRepo _repo;
        private readonly ICourseRepo _courseRepo;

        public InstructorController(IInstructorRepo repo, ICourseRepo courseRepo)
        {
            _repo = repo;
            _courseRepo = courseRepo;
        }
        public IActionResult Index()
        {
            var courses = _courseRepo.GetAll().ToList();

            var instructor = _repo.GetAll()
                .Select(i =>
                {
                    i.Courses = courses
                        .Where(c => c.CourseID == i.CourseID)
                        .FirstOrDefault() ?? new Courses { Name = "No Course Mastery" };
                    return i;
                });

            //return View(_repo.GetAll());
            return View(instructor);
        }

        public IEnumerable<string> GetInstructorById(int? CourseId)
        {
            var res = _repo.GetAll().Where(i => i.InstructorID == CourseId)
                .Select(n => n.LastName + ",\t " + n.FirstName + "<br />");

            if (res == null || res.Count() == 0)
            {
                return new List<string> { "No Instructor found." };
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
        public ActionResult Create(Instructors instructors)
        {
            _repo.Create(instructors);
            return RedirectToAction("Index");
        }
    }
}
