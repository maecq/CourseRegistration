using CourseRegistration.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Data.SQLRepos
{
    public class SQLInstructorRepo : IInstructorRepo
    {
        private readonly AppDbContext _context;

        public SQLInstructorRepo(AppDbContext context)
        {
            _context = context;
        }
        public void Create(Instructors instructor)
        {
            //throw new NotImplementedException();
            if (instructor == null) { throw new ArgumentException(nameof(instructor)); }
            _context.Instructors.Add(instructor);
            SaveChanges();
        }

        public IEnumerable<Instructors> GetAll()
        {
            //throw new NotImplementedException();
            return _context.Instructors.ToList();
        }

        public Instructors GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
