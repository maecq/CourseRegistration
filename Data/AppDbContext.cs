using CourseRegistration.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Students> Students { get; set; }
        public DbSet<Instructors> Instructors { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourse { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Students>().HasData(
                new Students { StudentID = 0201, FirstName = "Bruce", LastName = "Wayne", Email = "Bruce.Wayne@DCUniverse.com", Phone = "204-001-1234" },
                new Students { StudentID = 0202, FirstName = "Clark", LastName = "Kent", Email = "Clark.Kent@DCUniverse.com", Phone = "204-002-1234" },
                new Students { StudentID = 0203, FirstName = "Diana", LastName = "Prince", Email = "Diana.Prince@DCUniverse.com", Phone = "204-003-1234" },
                new Students { StudentID = 0204, FirstName = "Barry", LastName = "Allen", Email = "Barry.Allen@DCUniverse.com", Phone = "204-004-1234" },
                new Students { StudentID = 0205, FirstName = "Arthur", LastName = "Curry", Email = "Arthur.Curry@DCUniverse.com", Phone = "204-005-1234" },
                new Students { StudentID = 0206, FirstName = "Oliver", LastName = "Queen", Email = "Oliver.Queen@DCUniverse.com", Phone = "204-006-1234" },
                new Students { StudentID = 0207, FirstName = "John", LastName = "Stewart", Email = "John.Stewart@DCUniverse.com", Phone = "204-007-1234" },
                new Students { StudentID = 0208, FirstName = "Victor", LastName = "Stone", Email = "Victor.Stone@DCUniverse.com", Phone = "204-008-1234" },
                new Students { StudentID = 0209, FirstName = "J'onn", LastName = "J'onzz", Email = "John.Jones@DCUniverse.com", Phone = "204-009-1234" }
                );

            modelBuilder.Entity<Instructors>().HasData(
                new Instructors { InstructorID = 0901, FirstName = "Tony", LastName = "Stark", Email = "Tony.Stark@Marvel.com", CourseID = 1001 },
                new Instructors { InstructorID = 0902, FirstName = "Steve", LastName = "Rogers", Email = "Steve.Rogers@Marvel.com", CourseID = 1006 },
                new Instructors { InstructorID = 0903, FirstName = "Nick", LastName = "Fury", Email = "Nick.Fury@Marvel.com", CourseID = 1002 },
                new Instructors { InstructorID = 0904, FirstName = "Natasha", LastName = "Romanoff", Email = "Natasha.Romanoff@Marvel.com", CourseID = 1003 },
                new Instructors { InstructorID = 0905, FirstName = "Bruce", LastName = "Banner", Email = "Bruce.Banner@Marvel.com", CourseID = 1004 },
                new Instructors { InstructorID = 0906, FirstName = "Clint", LastName = "Barton", Email = "Clint.Barton@Marvel.com", CourseID = 1005 }
                );

            modelBuilder.Entity<Courses>().HasData(
                new Courses { CourseID = 1001, Name = "SCIENCE", Description = "Science Course Description" },
                new Courses { CourseID = 1002, Name = "MILITARY TACTICS", Description = "Military Tactics Course Description" },
                new Courses { CourseID = 1003, Name = "ESPIONAGE", Description = "Espionage Course Description" },
                new Courses { CourseID = 1004, Name = "PHYSICS", Description = "Physics Course Description" },
                new Courses { CourseID = 1005, Name = "ARCHERY", Description = "Archery Course Description" },
                new Courses { CourseID = 1006, Name = "HISTORY", Description = "History Course Description" },
                new Courses { CourseID = 1007, Name = "ATHLETICS", Description = "History Course Description" }
                );

            modelBuilder.Entity<StudentCourse>().HasData(
                new StudentCourse { StudentCourseID = 911, CourseID = 1001, StudentID = 0201 },
                new StudentCourse { StudentCourseID = 912, CourseID = 1002, StudentID = 0201 },
                new StudentCourse { StudentCourseID = 913, CourseID = 1003, StudentID = 0201 },
                new StudentCourse { StudentCourseID = 914, CourseID = 1004, StudentID = 0201 },
                new StudentCourse { StudentCourseID = 915, CourseID = 1007, StudentID = 0203 },
                new StudentCourse { StudentCourseID = 916, CourseID = 1006, StudentID = 0203 },
                new StudentCourse { StudentCourseID = 917, CourseID = 1005, StudentID = 0203 },
                new StudentCourse { StudentCourseID = 918, CourseID = 1006, StudentID = 0204 },
                new StudentCourse { StudentCourseID = 919, CourseID = 1003, StudentID = 0204 },
                new StudentCourse { StudentCourseID = 920, CourseID = 1007, StudentID = 0204 },
                new StudentCourse { StudentCourseID = 921, CourseID = 1003, StudentID = 0204 },
                new StudentCourse { StudentCourseID = 922, CourseID = 1004, StudentID = 0202 },
                new StudentCourse { StudentCourseID = 923, CourseID = 1002, StudentID = 0202 },
                new StudentCourse { StudentCourseID = 924, CourseID = 1003, StudentID = 0205 },
                new StudentCourse { StudentCourseID = 925, CourseID = 1004, StudentID = 0205 },
                new StudentCourse { StudentCourseID = 926, CourseID = 1005, StudentID = 0206 },
                new StudentCourse { StudentCourseID = 927, CourseID = 1006, StudentID = 0206 },
                new StudentCourse { StudentCourseID = 928, CourseID = 1007, StudentID = 0207 },
                new StudentCourse { StudentCourseID = 929, CourseID = 1001, StudentID = 0207 },
                new StudentCourse { StudentCourseID = 930, CourseID = 1002, StudentID = 0208 },
                new StudentCourse { StudentCourseID = 931, CourseID = 1005, StudentID = 0208 }
            );


        }

    }
}
