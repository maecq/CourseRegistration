using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.DTO
{
    public interface IStudentRepo
    {
        IEnumerable<Students> GetAll();

        Students GetById(int Id);
    }
}
