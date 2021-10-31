using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.DTO
{
    public class Courses
    {
        public int CourseID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Students Students { get; set; }

    }
}
