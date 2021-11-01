using CourseRegistration.DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Controllers
{
    public class StudentCourseController : Controller
    {
        private readonly IStudentCourseRepo _repo;
        //private readonly IStudentRepo _studentRepo;
        //private readonly ICourseRepo _courseRepo;

        public StudentCourseController(IStudentCourseRepo repo)
        {
            _repo = repo;
            //_studentRepo = studentRepo;
            //_courseRepo = courseRepo;
        }
        public IActionResult Index()
        {
            return View(_repo.GetAll());
        }

        public IActionResult Create()
        {
            return View();
        }


    }
}
