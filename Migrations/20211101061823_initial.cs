using Microsoft.EntityFrameworkCore.Migrations;

namespace CourseRegistration.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseID);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    InstructorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.InstructorID);
                    table.ForeignKey(
                        name: "FK_Instructors_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoursesCourseID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentID);
                    table.ForeignKey(
                        name: "FK_Students_Courses_CoursesCourseID",
                        column: x => x.CoursesCourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentCourse",
                columns: table => new
                {
                    StudentCourseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    CourseID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourse", x => x.StudentCourseID);
                    table.ForeignKey(
                        name: "FK_StudentCourse_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentCourse_Students_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Students",
                        principalColumn: "StudentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseID", "Description", "Name" },
                values: new object[,]
                {
                    { 1001, "Science Course Description", "SCIENCE" },
                    { 1002, "Military Tactics Course Description", "MILITARY TACTICS" },
                    { 1003, "Espionage Course Description", "ESPIONAGE" },
                    { 1004, "Physics Course Description", "PHYSICS" },
                    { 1005, "Archery Course Description", "ARCHERY" },
                    { 1006, "History Course Description", "HISTORY" },
                    { 1007, "History Course Description", "ATHLETICS" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentID", "CoursesCourseID", "Email", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 201, null, "Bruce.Wayne@DCUniverse.com", "Bruce", "Wayne", "204-001-1234" },
                    { 202, null, "Clark.Kent@DCUniverse.com", "Clark", "Kent", "204-002-1234" },
                    { 203, null, "Diana.Prince@DCUniverse.com", "Diana", "Prince", "204-003-1234" },
                    { 204, null, "Barry.Allen@DCUniverse.com", "Barry", "Allen", "204-004-1234" },
                    { 205, null, "Arthur.Curry@DCUniverse.com", "Arthur", "Curry", "204-005-1234" },
                    { 206, null, "Oliver.Queen@DCUniverse.com", "Oliver", "Queen", "204-006-1234" },
                    { 207, null, "John.Stewart@DCUniverse.com", "John", "Stewart", "204-007-1234" },
                    { 208, null, "Victor.Stone@DCUniverse.com", "Victor", "Stone", "204-008-1234" },
                    { 209, null, "John.Jones@DCUniverse.com", "J'onn", "J'onzz", "204-009-1234" }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "InstructorID", "CourseID", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 901, 1001, "Tony.Stark@Marvel.com", "Tony", "Stark" },
                    { 903, 1002, "Nick.Fury@Marvel.com", "Nick", "Fury" },
                    { 904, 1003, "Natasha.Romanoff@Marvel.com", "Natasha", "Romanoff" },
                    { 905, 1004, "Bruce.Banner@Marvel.com", "Bruce", "Banner" },
                    { 906, 1005, "Clint.Barton@Marvel.com", "Clint", "Barton" },
                    { 902, 1006, "Steve.Rogers@Marvel.com", "Steve", "Rogers" }
                });

            migrationBuilder.InsertData(
                table: "StudentCourse",
                columns: new[] { "StudentCourseID", "CourseID", "StudentID" },
                values: new object[,]
                {
                    { 929, 1001, 207 },
                    { 928, 1007, 207 },
                    { 927, 1006, 206 },
                    { 926, 1005, 206 },
                    { 925, 1004, 205 },
                    { 924, 1003, 205 },
                    { 921, 1003, 204 },
                    { 920, 1007, 204 },
                    { 919, 1003, 204 },
                    { 916, 1006, 203 },
                    { 917, 1005, 203 },
                    { 930, 1002, 208 },
                    { 915, 1007, 203 },
                    { 923, 1002, 202 },
                    { 922, 1004, 202 },
                    { 914, 1004, 201 },
                    { 913, 1003, 201 },
                    { 912, 1002, 201 },
                    { 911, 1001, 201 },
                    { 918, 1006, 204 },
                    { 931, 1005, 208 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_CourseID",
                table: "Instructors",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourse_CourseID",
                table: "StudentCourse",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourse_StudentID",
                table: "StudentCourse",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_CoursesCourseID",
                table: "Students",
                column: "CoursesCourseID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropTable(
                name: "StudentCourse");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
