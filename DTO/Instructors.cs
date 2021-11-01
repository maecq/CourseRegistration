using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.DTO
{
    public class Instructors
    {
        [DisplayName("Instructor ID")]
        [Key]
        public int InstructorID { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("Email Address")]
        public string Email { get; set; }

        [DisplayName("Course Mastery")]
        [ForeignKey("Courses")]
        public int? CourseID { get; set; }

        [DisplayName("Course Mastery")]
        public Courses Courses { get; set; }

    }
}
