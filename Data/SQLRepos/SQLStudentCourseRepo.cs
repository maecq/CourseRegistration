using CourseRegistration.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Data.SQLRepos
{
    public class SQLStudentCourseRepo : IStudentCourseRepo
    {
        private readonly AppDbContext _context;

        public SQLStudentCourseRepo(AppDbContext context)
        {
            _context = context;
        }
        public void Create(StudentCourse studentCourse)
        {
            if (studentCourse == null) { throw new ArgumentException(nameof(studentCourse)); }
            _context.StudentCourse.Add(studentCourse);
            _context.SaveChanges();
            //throw new NotImplementedException();
        }

        public IEnumerable<StudentCourse> GetAll()
        {
            return _context.StudentCourse.ToList();
            //throw new NotImplementedException();
        }

        public Courses GetCourseById(int Id)
        {
            throw new NotImplementedException();
        }

        public Students GetStudentById(int Id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {

        }
    }
}
