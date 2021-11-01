using CourseRegistration.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Data.SQLRepos
{
    public class SQLStudentRepo : IStudentRepo
    {
        private readonly AppDbContext _context;

        public SQLStudentRepo(AppDbContext context)
        {
            _context = context;
        }
        public void Create(Students student)
        {
            if (student == null) { throw new ArgumentException(nameof(student)); }
            _context.Students.Add(student);
            SaveChanges();
            //throw new NotImplementedException();
        }

        public IEnumerable<Students> GetAll()
        {
            //throw new NotImplementedException();
            return _context.Students.ToList();
        }

        public Students GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();

        }
    }
}
