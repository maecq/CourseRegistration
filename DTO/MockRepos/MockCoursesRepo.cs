using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.DTO.MockRepos
{
    public class MockCoursesRepo : ICourseRepo
    {
        private static List<Courses> _courses = new List<Courses>
        {
                new Courses{ CourseID = 1001, Name = "SCIENCE", Description = "Science Course Description" },
                new Courses{ CourseID = 1002, Name = "MILITARY TACTICS", Description = "Military Tactics Course Description"},
                new Courses{ CourseID = 1003, Name = "ESPIONAGE", Description = "Espionage Course Description"},
                new Courses{ CourseID = 1004, Name = "PHYSICS", Description = "Physics Course Description"},
                new Courses{ CourseID = 1005, Name = "ARCHERY", Description = "Archery Course Description"},
                new Courses{ CourseID = 1006, Name = "HISTORY", Description = "History Course Description"}

        };

        public void Create(Courses course)
        {
            //throw new NotImplementedException();
            int newID = _courses.Max(c => c.CourseID + 1);
            course.CourseID = newID;
            _courses.Add(course);
        }

        public IEnumerable<Courses> GetAll()
        {
            //throw new NotImplementedException();
            return _courses;
        }

        public Courses GetById(int Id)
        {
            //throw new NotImplementedException();
            var course = _courses.Where(c => c.CourseID == Id).FirstOrDefault();
            return course;
        }
    }
}
