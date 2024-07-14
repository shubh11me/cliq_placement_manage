using Microsoft.EntityFrameworkCore.Migrations;

namespace Cliqlearn.Migrations
{
    public partial class collegestud1_mappingaaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_CollegeStudent_studentid",
                table: "CollegeStudent");

            migrationBuilder.CreateIndex(
                name: "IX_CollegeStudent_studentid",
                table: "CollegeStudent",
                column: "studentid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_CollegeStudent_studentid",
                table: "CollegeStudent");

            migrationBuilder.CreateIndex(
                name: "IX_CollegeStudent_studentid",
                table: "CollegeStudent",
                column: "studentid",
                unique: true);
        }
    }
}
