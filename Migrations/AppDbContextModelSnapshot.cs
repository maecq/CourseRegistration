﻿// <auto-generated />
using System;
using CourseRegistration.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CourseRegistration.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CourseRegistration.DTO.Courses", b =>
                {
                    b.Property<int>("CourseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseID");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            CourseID = 1001,
                            Description = "Science Course Description",
                            Name = "SCIENCE"
                        },
                        new
                        {
                            CourseID = 1002,
                            Description = "Military Tactics Course Description",
                            Name = "MILITARY TACTICS"
                        },
                        new
                        {
                            CourseID = 1003,
                            Description = "Espionage Course Description",
                            Name = "ESPIONAGE"
                        },
                        new
                        {
                            CourseID = 1004,
                            Description = "Physics Course Description",
                            Name = "PHYSICS"
                        },
                        new
                        {
                            CourseID = 1005,
                            Description = "Archery Course Description",
                            Name = "ARCHERY"
                        },
                        new
                        {
                            CourseID = 1006,
                            Description = "History Course Description",
                            Name = "HISTORY"
                        },
                        new
                        {
                            CourseID = 1007,
                            Description = "History Course Description",
                            Name = "ATHLETICS"
                        });
                });

            modelBuilder.Entity("CourseRegistration.DTO.Instructors", b =>
                {
                    b.Property<int>("InstructorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CourseID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InstructorID");

                    b.HasIndex("CourseID");

                    b.ToTable("Instructors");

                    b.HasData(
                        new
                        {
                            InstructorID = 901,
                            CourseID = 1001,
                            Email = "Tony.Stark@Marvel.com",
                            FirstName = "Tony",
                            LastName = "Stark"
                        },
                        new
                        {
                            InstructorID = 902,
                            CourseID = 1006,
                            Email = "Steve.Rogers@Marvel.com",
                            FirstName = "Steve",
                            LastName = "Rogers"
                        },
                        new
                        {
                            InstructorID = 903,
                            CourseID = 1002,
                            Email = "Nick.Fury@Marvel.com",
                            FirstName = "Nick",
                            LastName = "Fury"
                        },
                        new
                        {
                            InstructorID = 904,
                            CourseID = 1003,
                            Email = "Natasha.Romanoff@Marvel.com",
                            FirstName = "Natasha",
                            LastName = "Romanoff"
                        },
                        new
                        {
                            InstructorID = 905,
                            CourseID = 1004,
                            Email = "Bruce.Banner@Marvel.com",
                            FirstName = "Bruce",
                            LastName = "Banner"
                        },
                        new
                        {
                            InstructorID = 906,
                            CourseID = 1005,
                            Email = "Clint.Barton@Marvel.com",
                            FirstName = "Clint",
                            LastName = "Barton"
                        });
                });

            modelBuilder.Entity("CourseRegistration.DTO.StudentCourse", b =>
                {
                    b.Property<int>("StudentCourseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("StudentCourseID");

                    b.HasIndex("CourseID");

                    b.HasIndex("StudentID");

                    b.ToTable("StudentCourse");

                    b.HasData(
                        new
                        {
                            StudentCourseID = 911,
                            CourseID = 1001,
                            StudentID = 201
                        },
                        new
                        {
                            StudentCourseID = 912,
                            CourseID = 1002,
                            StudentID = 201
                        },
                        new
                        {
                            StudentCourseID = 913,
                            CourseID = 1003,
                            StudentID = 201
                        },
                        new
                        {
                            StudentCourseID = 914,
                            CourseID = 1004,
                            StudentID = 201
                        },
                        new
                        {
                            StudentCourseID = 915,
                            CourseID = 1007,
                            StudentID = 203
                        },
                        new
                        {
                            StudentCourseID = 916,
                            CourseID = 1006,
                            StudentID = 203
                        },
                        new
                        {
                            StudentCourseID = 917,
                            CourseID = 1005,
                            StudentID = 203
                        },
                        new
                        {
                            StudentCourseID = 918,
                            CourseID = 1006,
                            StudentID = 204
                        },
                        new
                        {
                            StudentCourseID = 919,
                            CourseID = 1003,
                            StudentID = 204
                        },
                        new
                        {
                            StudentCourseID = 920,
                            CourseID = 1007,
                            StudentID = 204
                        },
                        new
                        {
                            StudentCourseID = 921,
                            CourseID = 1003,
                            StudentID = 204
                        },
                        new
                        {
                            StudentCourseID = 922,
                            CourseID = 1004,
                            StudentID = 202
                        },
                        new
                        {
                            StudentCourseID = 923,
                            CourseID = 1002,
                            StudentID = 202
                        },
                        new
                        {
                            StudentCourseID = 924,
                            CourseID = 1003,
                            StudentID = 205
                        },
                        new
                        {
                            StudentCourseID = 925,
                            CourseID = 1004,
                            StudentID = 205
                        },
                        new
                        {
                            StudentCourseID = 926,
                            CourseID = 1005,
                            StudentID = 206
                        },
                        new
                        {
                            StudentCourseID = 927,
                            CourseID = 1006,
                            StudentID = 206
                        },
                        new
                        {
                            StudentCourseID = 928,
                            CourseID = 1007,
                            StudentID = 207
                        },
                        new
                        {
                            StudentCourseID = 929,
                            CourseID = 1001,
                            StudentID = 207
                        },
                        new
                        {
                            StudentCourseID = 930,
                            CourseID = 1002,
                            StudentID = 208
                        },
                        new
                        {
                            StudentCourseID = 931,
                            CourseID = 1005,
                            StudentID = 208
                        });
                });

            modelBuilder.Entity("CourseRegistration.DTO.Students", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CoursesCourseID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentID");

                    b.HasIndex("CoursesCourseID");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentID = 201,
                            Email = "Bruce.Wayne@DCUniverse.com",
                            FirstName = "Bruce",
                            LastName = "Wayne",
                            Phone = "204-001-1234"
                        },
                        new
                        {
                            StudentID = 202,
                            Email = "Clark.Kent@DCUniverse.com",
                            FirstName = "Clark",
                            LastName = "Kent",
                            Phone = "204-002-1234"
                        },
                        new
                        {
                            StudentID = 203,
                            Email = "Diana.Prince@DCUniverse.com",
                            FirstName = "Diana",
                            LastName = "Prince",
                            Phone = "204-003-1234"
                        },
                        new
                        {
                            StudentID = 204,
                            Email = "Barry.Allen@DCUniverse.com",
                            FirstName = "Barry",
                            LastName = "Allen",
                            Phone = "204-004-1234"
                        },
                        new
                        {
                            StudentID = 205,
                            Email = "Arthur.Curry@DCUniverse.com",
                            FirstName = "Arthur",
                            LastName = "Curry",
                            Phone = "204-005-1234"
                        },
                        new
                        {
                            StudentID = 206,
                            Email = "Oliver.Queen@DCUniverse.com",
                            FirstName = "Oliver",
                            LastName = "Queen",
                            Phone = "204-006-1234"
                        },
                        new
                        {
                            StudentID = 207,
                            Email = "John.Stewart@DCUniverse.com",
                            FirstName = "John",
                            LastName = "Stewart",
                            Phone = "204-007-1234"
                        },
                        new
                        {
                            StudentID = 208,
                            Email = "Victor.Stone@DCUniverse.com",
                            FirstName = "Victor",
                            LastName = "Stone",
                            Phone = "204-008-1234"
                        },
                        new
                        {
                            StudentID = 209,
                            Email = "John.Jones@DCUniverse.com",
                            FirstName = "J'onn",
                            LastName = "J'onzz",
                            Phone = "204-009-1234"
                        });
                });

            modelBuilder.Entity("CourseRegistration.DTO.Instructors", b =>
                {
                    b.HasOne("CourseRegistration.DTO.Courses", "Courses")
                        .WithMany()
                        .HasForeignKey("CourseID");

                    b.Navigation("Courses");
                });

            modelBuilder.Entity("CourseRegistration.DTO.StudentCourse", b =>
                {
                    b.HasOne("CourseRegistration.DTO.Courses", "Courses")
                        .WithMany()
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CourseRegistration.DTO.Students", "Students")
                        .WithMany()
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Courses");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("CourseRegistration.DTO.Students", b =>
                {
                    b.HasOne("CourseRegistration.DTO.Courses", "Courses")
                        .WithMany()
                        .HasForeignKey("CoursesCourseID");

                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
