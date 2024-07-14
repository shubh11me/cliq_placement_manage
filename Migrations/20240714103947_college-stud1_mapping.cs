using Microsoft.EntityFrameworkCore.Migrations;

namespace Cliqlearn.Migrations
{
    public partial class collegestud1_mapping : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CollegeStudent",
                columns: table => new
                {
                    CollegeStudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    studentid = table.Column<int>(type: "int", nullable: true),
                    collegeid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollegeStudent", x => x.CollegeStudentId);
                    table.ForeignKey(
                        name: "FK_CollegeStudent_colleges_collegeid",
                        column: x => x.collegeid,
                        principalTable: "colleges",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CollegeStudent_students_studentid",
                        column: x => x.studentid,
                        principalTable: "students",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CollegeStudent_collegeid",
                table: "CollegeStudent",
                column: "collegeid");

            migrationBuilder.CreateIndex(
                name: "IX_CollegeStudent_studentid",
                table: "CollegeStudent",
                column: "studentid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CollegeStudent");
        }
    }
}
