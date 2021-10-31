using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.DTO.MockRepos
{
    public class MockInstructorsRepo : IInstructorRepo
    {
        private static List<Instructors> _instructors = new List<Instructors>
        {
                new Instructors{ InstructorID = 0901, FirstName = "Tony", LastName = "Stark", Email="Tony.Stark@Marvel.com", CourseID = 1001 },
                new Instructors{ InstructorID = 0902, FirstName = "Steve", LastName = "Rogers", Email="Steve.Rogers@Marvel.com" , CourseID = 1006},
                new Instructors{ InstructorID = 0903, FirstName = "Nick", LastName = "Fury", Email="Nick.Fury@Marvel.com" , CourseID = 1002},
                new Instructors{ InstructorID = 0904, FirstName = "Natasha", LastName = "Romanoff", Email="Natasha.Romanoff@Marvel.com" , CourseID = 1003},
                new Instructors{ InstructorID = 0905, FirstName = "Bruce", LastName = "Banner", Email="Bruce.Banner@Marvel.com" , CourseID = 1004},
                new Instructors{ InstructorID = 0906, FirstName = "Clint", LastName = "Barton", Email="Clint.Barton@Marvel.com" , CourseID = 1005}

        };

        public void Create(Instructors instructor)
        {
            //throw new NotImplementedException();
            int newID = _instructors.Max(i => i.InstructorID + 1);
            instructor.InstructorID = newID;
            _instructors.Add(instructor);
        }

        public IEnumerable<Instructors> GetAll()
        {
            //throw new NotImplementedException();
            return _instructors;
        }
        public Instructors GetById(int Id)
        {
            //throw new NotImplementedException();
            var instructor = _instructors.Where(i => i.InstructorID == Id).FirstOrDefault();
            return instructor;
        }
    }
}
