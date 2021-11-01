using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.DTO.MockRepos
{
    public class MockStudentCourseRepo : IStudentCourseRepo
    {
        private static List<StudentCourse> _sc = new List<StudentCourse>
        {
            new StudentCourse{ StudentCourseID = 911, CourseID = 1001, StudentID = 0201 },
            new StudentCourse{ StudentCourseID = 912, CourseID = 1002, StudentID = 0201 },
            new StudentCourse{ StudentCourseID = 913, CourseID = 1003, StudentID = 0201 },
            new StudentCourse{ StudentCourseID = 914, CourseID = 1004, StudentID = 0201 },
            new StudentCourse{ StudentCourseID = 915, CourseID = 1007, StudentID = 0203 },
            new StudentCourse{ StudentCourseID = 916, CourseID = 1006, StudentID = 0203 },
            new StudentCourse{ StudentCourseID = 917, CourseID = 1005, StudentID = 0203 },
            new StudentCourse{ StudentCourseID = 918, CourseID = 1006, StudentID = 0204 },
            new StudentCourse{ StudentCourseID = 919, CourseID = 1003, StudentID = 0204 },
            new StudentCourse{ StudentCourseID = 920, CourseID = 1007, StudentID = 0204 },
            new StudentCourse{ StudentCourseID = 921, CourseID = 1003, StudentID = 0204 },
            new StudentCourse{ StudentCourseID = 922, CourseID = 1004, StudentID = 0202 },
            new StudentCourse{ StudentCourseID = 923, CourseID = 1002, StudentID = 0202 },
            new StudentCourse{ StudentCourseID = 924, CourseID = 1003, StudentID = 0205 },
            new StudentCourse{ StudentCourseID = 925, CourseID = 1004, StudentID = 0205 },
            new StudentCourse{ StudentCourseID = 926, CourseID = 1005, StudentID = 0206 },
            new StudentCourse{ StudentCourseID = 927, CourseID = 1006, StudentID = 0206 },
            new StudentCourse{ StudentCourseID = 928, CourseID = 1007, StudentID = 0207 },
            new StudentCourse{ StudentCourseID = 929, CourseID = 1001, StudentID = 0207 },
            new StudentCourse{ StudentCourseID = 930, CourseID = 1002, StudentID = 0208 },
            new StudentCourse{ StudentCourseID = 931, CourseID = 1005, StudentID = 0208 }
        };

        public void Create(StudentCourse studentCourse)
        {
            //throw new NotImplementedException();
            int newId = _sc.Max(i => i.StudentCourseID + 1);
            studentCourse.StudentCourseID = newId;
            _sc.Add(studentCourse);
        }

        public IEnumerable<StudentCourse> GetAll()
        {
            //throw new NotImplementedException();
            return _sc;
        }

        public Courses GetCourseById(int Id)
        {
            throw new NotImplementedException();
        }

        public Students GetStudentById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
