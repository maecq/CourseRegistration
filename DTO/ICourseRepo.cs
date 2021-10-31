using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.DTO
{
    public interface ICourseRepo
    {
        IEnumerable<Courses> GetAll();
        Courses GetById(int Id);
        void Create(Courses course);

    }
}
