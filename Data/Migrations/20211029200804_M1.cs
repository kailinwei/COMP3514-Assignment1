using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment1.Data.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    City = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Specialization = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    StudentId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Student_Student_StudentId1",
                        column: x => x.StudentId1,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "City", "Email", "FirstName", "LastName", "Mobile", "Specialization", "StudentId1" },
                values: new object[,]
                {
                    { 1, "Chilliwack", "jim@potter.com", "Jim", "Potter", "604-123-4567", "Nursing", null },
                    { 2, "Vancouver", "jane@douglas.com", "Jane", "Douglas", "222-222-2222", "Nursing", null },
                    { 3, "Vancouver", "tom@gardner.com", "Tom", "Gardner", "333-333-33333", "Computer Programming", null },
                    { 4, "Vancouver", "ann@lee.com", "Ann", "Lee", "444-444-4444", "Computer Programming", null },
                    { 5, "Victoria", "james@jones.com", "James", "Jones", "555-555-5555", "Business", null },
                    { 6, "Victoria", "susan@taylor.com", "Susan", "Taylor", "666-666-6666", "Business", null },
                    { 7, "Victoria", "peter@white.com", "Peter", "White", "777-777-7777", "Criminal Justice", null },
                    { 8, "Prince George", "philip@fox.com", "Philip", "Fox", "888-888-8888", "History", null },
                    { 9, "Prince George", "donna@ray.com", "Donna", "Ray", "999-999-9999", "History", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Student_StudentId1",
                table: "Student",
                column: "StudentId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
