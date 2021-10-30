using CourseRegistration.DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepo _repo;

        public StudentController(IStudentRepo repo)
        {
            _repo = repo;
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
    }
}
