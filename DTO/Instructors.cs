using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.DTO
{
    public class Instructors
    {
        [DisplayName("Instructor ID")]
        public int InstructorID { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("Email Address")]
        public string Email { get; set; }
        [DisplayName("Course Mastery")]
        public int? CourseID { get; set; }

        public Courses Courses { get; set; }

    }
}
