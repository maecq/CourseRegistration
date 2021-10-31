using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.DTO
{
    public interface IInstructorRepo
    {
        IEnumerable<Instructors> GetAll();
        Instructors GetById(int Id);
        void Create(Instructors instructor);

    }


}
