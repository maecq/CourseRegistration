using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.DTO.MockRepos
{
    public class MockStudentsRepo : IStudentRepo
    {
        private static List<Students> _students = new List<Students>
        {
                new Students { StudentID = 0201, FirstName = "Bruce", LastName = "Wayne", Email = "Bruce.Wayne@DCUniverse.com", Phone = "204-001-1234"},
                new Students { StudentID = 0202, FirstName = "Clark", LastName = "Kent", Email = "Clark.Kent@DCUniverse.com", Phone = "204-002-1234"},
                new Students { StudentID = 0203, FirstName = "Diana", LastName = "Prince", Email = "Diana.Prince@DCUniverse.com", Phone = "204-003-1234"},
                new Students { StudentID = 0204, FirstName = "Barry", LastName = "Allen", Email = "Barry.Allen@DCUniverse.com", Phone = "204-004-1234"},
                new Students { StudentID = 0205, FirstName = "Arthur", LastName = "Curry", Email = "Arthur.Curry@DCUniverse.com", Phone = "204-005-1234"},
                new Students { StudentID = 0206, FirstName = "Oliver", LastName = "Queen", Email = "Oliver.Queen@DCUniverse.com", Phone = "204-006-1234"},
                new Students { StudentID = 0207, FirstName = "John", LastName = "Stewart", Email = "John.Stewart@DCUniverse.com", Phone = "204-007-1234"},
                new Students { StudentID = 0208, FirstName = "Victor", LastName = "Stone", Email = "Victor.Stone@DCUniverse.com", Phone = "204-008-1234"},
                new Students { StudentID = 0209, FirstName = "J'onn", LastName = "J'onzz", Email = "John.Jones@DCUniverse.com", Phone = "204-009-1234"}
        };

        public void Create(Students student)
        {
            //throw new NotImplementedException();
            int newID = _students.Max(s => s.StudentID + 1);
            student.StudentID = newID;
            _students.Add(student);
        }

        public IEnumerable<Students> GetAll()
        {
            //throw new NotImplementedException();
            return _students;
        }

        public Students GetById(int Id)
        {
            //throw new NotImplementedException();
            var student = _students.Where(s => s.StudentID == Id).FirstOrDefault();
            return student;
        }
    }
}
