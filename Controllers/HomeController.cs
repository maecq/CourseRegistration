using CourseRegistration.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        /*
        public IActionResult Instructors()
        {
            InstructorsViewModel ivm = new InstructorsViewModel();
            List<DTO.Instructors> instructors = new List<DTO.Instructors>()
            {
                new DTO.Instructors{ InstructorID = 0901, FirstName = "Tony", LastName = "Stark", Email="Tony.Stark@Marvel.com", Course = "Science" },
                new DTO.Instructors{ InstructorID = 0902, FirstName = "Steve", LastName = "Rogers", Email="Steve.Rogers@Marvel.com" ,Course = "History"},
                new DTO.Instructors{ InstructorID = 0903, FirstName = "Nick", LastName = "Fury", Email="Nick.Fury@Marvel.com" ,Course = "Military Tactics"},
                new DTO.Instructors{ InstructorID = 0904, FirstName = "Natasha", LastName = "Romanoff", Email="Natasha.Romanoff@Marvel.com" ,Course = "Espionage"},
                new DTO.Instructors{ InstructorID = 0905, FirstName = "Bruce", LastName = "Banner", Email="Bruce.Banner@Marvel.com" ,Course = "Physics"},
                new DTO.Instructors{ InstructorID = 0906, FirstName = "Clint", LastName = "Barton", Email="Clint.Barton@Marvel.com" ,Course = "Archery"}
            };
            ivm.Instructors = instructors;
            return View(ivm);
        }

        public IActionResult Students()
        {
            StudentsViewModel svm = new StudentsViewModel();
            List<DTO.Students> students = new List<DTO.Students>()
            {
                new DTO.Students { StudentID = 0201, FirstName = "Bruce", LastName = "Wayne", Email = "Bruce.Wayne@DCUniverse.com", Phone = "204-001-1234" },                
                new DTO.Students { StudentID = 0202, FirstName = "Clark", LastName = "Kent", Email = "Clark.Kent@DCUniverse.com", Phone = "204-002-1234" },
                new DTO.Students { StudentID = 0203, FirstName = "Diana", LastName = "Prince", Email = "Diana.Prince@DCUniverse.com", Phone = "204-003-1234" },
                new DTO.Students { StudentID = 0204, FirstName = "Barry", LastName = "Allen", Email = "Barry.Allen@DCUniverse.com", Phone = "204-004-1234" },
                new DTO.Students { StudentID = 0205, FirstName = "Arthur", LastName = "Curry", Email = "Arthur.Curry@DCUniverse.com", Phone = "204-005-1234" },
                new DTO.Students { StudentID = 0206, FirstName = "Oliver", LastName = "Queen", Email = "Oliver.Queen@DCUniverse.com", Phone = "204-006-1234" },
                new DTO.Students { StudentID = 0207, FirstName = "John", LastName = "Stewart", Email = "John.Stewart@DCUniverse.com", Phone = "204-007-1234" },
                new DTO.Students { StudentID = 0208, FirstName = "Victor", LastName = "Stone", Email = "Victor.Stone@DCUniverse.com", Phone = "204-008-1234" },
                new DTO.Students { StudentID = 0209, FirstName = "J'onn", LastName = "J'onzz", Email = "John.Jones@DCUniverse.com", Phone = "204-009-1234" }

            };
            svm.Students = students;
            return View(svm);
        }

        public IActionResult Courses()
        {
            CoursesViewModel cvm = new CoursesViewModel();
            List<DTO.Courses> kurso = new List<DTO.Courses>()
            {
                new DTO.Courses { CourseID = 1001, Name = "SCIENCE", Description = "Science Course Description" },
                new DTO.Courses{ CourseID = 1002, Name = "MILITARY TACTICS", Description = "Military Tactics Course Description"},
                new DTO.Courses{ CourseID = 1003, Name = "ESPIONAGE", Description = "Espionage Course Description"},
                new DTO.Courses{ CourseID = 1004, Name = "PHYSICS", Description = "Physics Course Description"},
                new DTO.Courses{ CourseID = 1005, Name = "ARCHERY", Description = "Archery Course Description"}
            };
            cvm.Courses = kurso;
            return View(cvm);
        }        
        public IActionResult ViewEnrolled()
        {
            ViewEnrolledViewModel ve = new ViewEnrolledViewModel();
            List<DTO.ViewEnrolled> enrolees = new List<DTO.ViewEnrolled>()
            {
                new DTO.ViewEnrolled{ CourseName="", FirstName="Oliver", LastName="Queen", Email="Oliver.Queen@DCUniverse.com"},
                new DTO.ViewEnrolled{ CourseName="", FirstName="Bruce", LastName="Wayne", Email="Bruce.Wayne@DCuniverse.com"}
            };
            ve.enrolledStudents = enrolees;
            return View(ve);
        }
        */


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
