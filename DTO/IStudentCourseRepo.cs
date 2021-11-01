using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.DTO
{
    public interface IStudentCourseRepo
    {
        IEnumerable<StudentCourse> GetAll();
        Students GetStudentById(int Id);
        Courses GetCourseById(int Id);

        void Create(StudentCourse studentCourse);
       
    }
}
