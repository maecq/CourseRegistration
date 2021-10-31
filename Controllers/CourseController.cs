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
        public CourseController(ICourseRepo repo)
        {
            _repo = repo;
        }
        public ActionResult<IEnumerable<Courses>> Index()
        {
            var courses = _repo.GetAll();
            return View(courses);
        }
        //public IActionResult Index()
        //{
        //    return View(_repo.GetAll());
        //}
        public IEnumerable<string>GetCourseById(int? Id)
        {
            var res = _repo.GetAll().Where(c => c.CourseID == Id)
                .Select(n => n.Name + "\t " + n.Description + "<br />");
            if (res == null || res.Count() == 0)
            {
                return new List<string> { "No Course Name Found" };
            }
            return res;
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
