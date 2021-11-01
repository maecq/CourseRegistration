using CourseRegistration.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Data.SQLRepos
{
    public class SQLCourseRepo : ICourseRepo
    {
        private readonly AppDbContext _context;

        public SQLCourseRepo(AppDbContext context)
        {
            _context = context;
        }
        public void Create(Courses course)
        {
            //throw new NotImplementedException();
            if (course == null) { throw new ArgumentException(nameof(course)); }
            _context.Courses.Add(course);
            SaveChanges();
        }

        public IEnumerable<Courses> GetAll()
        {
            //throw new NotImplementedException();
            return _context.Courses.ToList();
        }

        public Courses GetById(int Id)
        {
            throw new NotImplementedException();
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
