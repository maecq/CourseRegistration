using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.DTO
{
    //this class holds records linking students to courses
    public class StudentCourse  
    {   
        [Key]
        public int StudentCourseID { get; set; }

        [ForeignKey("Students")]
        public int StudentID { get; set; }

        [ForeignKey("Courses")]
        public int CourseID { get; set; }

        public Students Students { get; set; }

        public Courses Courses { get; set; }

    }
}
