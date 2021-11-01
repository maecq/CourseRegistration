using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.DTO
{
    public class Courses
    {
        [Key]
        public int CourseID { get; set; }

        [DisplayName("Course Mastery")]
        public string Name { get; set; }

        public string Description { get; set; }

        //public Students Students { get; set; }

    }
}
