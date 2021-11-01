using CourseRegistration.DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseRepo _repo;
        private readonly IStudentCourseRepo _studentCourseRepo;

        public CourseController(ICourseRepo repo, IStudentCourseRepo studentCourseRepo)
        {
            _repo = repo;
            _studentCourseRepo = studentCourseRepo;
        }
        public ActionResult<IEnumerable<Courses>> Index()
        {
            var courses = _repo.GetAll();
            return View(courses);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Courses course)
        {
            //add new course to collection
            _repo.Create(course);
            return RedirectToAction("Index");
        }


    }
}
