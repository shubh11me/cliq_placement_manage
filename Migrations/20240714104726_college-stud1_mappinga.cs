using Microsoft.EntityFrameworkCore.Migrations;

namespace Cliqlearn.Migrations
{
    public partial class collegestud1_mappinga : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CollegeStudent_students_studentid",
                table: "CollegeStudent");

            migrationBuilder.DropIndex(
                name: "IX_CollegeStudent_studentid",
                table: "CollegeStudent");

            migrationBuilder.AlterColumn<int>(
                name: "studentid",
                table: "CollegeStudent",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CollegeStudent_studentid",
                table: "CollegeStudent",
                column: "studentid",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CollegeStudent_students_studentid",
                table: "CollegeStudent",
                column: "studentid",
                principalTable: "students",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CollegeStudent_students_studentid",
                table: "CollegeStudent");

            migrationBuilder.DropIndex(
                name: "IX_CollegeStudent_studentid",
                table: "CollegeStudent");

            migrationBuilder.AlterColumn<int>(
                name: "studentid",
                table: "CollegeStudent",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_CollegeStudent_studentid",
                table: "CollegeStudent",
                column: "studentid");

            migrationBuilder.AddForeignKey(
                name: "FK_CollegeStudent_students_studentid",
                table: "CollegeStudent",
                column: "studentid",
                principalTable: "students",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
