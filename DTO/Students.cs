using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.DTO
{
    public class Students
    {
        public int StudentID { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Email Address")]
        public string Email { get; set; }
        [DisplayName("Phone Number")]
        public string Phone { get; set; }

        [DisplayName("Registered Courses")]
        public int? CourseID { get; set; }
        public Courses Courses { get; set; }
    }
}
