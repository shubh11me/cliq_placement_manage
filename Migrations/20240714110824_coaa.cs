using Microsoft.EntityFrameworkCore.Migrations;

namespace Cliqlearn.Migrations
{
    public partial class coaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CollegeStudent_colleges_collegeid",
                table: "CollegeStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_CollegeStudent_students_studentid",
                table: "CollegeStudent");

            migrationBuilder.AlterColumn<int>(
                name: "studentid",
                table: "CollegeStudent",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "collegeid",
                table: "CollegeStudent",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_CollegeStudent_colleges_collegeid",
                table: "CollegeStudent",
                column: "collegeid",
                principalTable: "colleges",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CollegeStudent_students_studentid",
                table: "CollegeStudent",
                column: "studentid",
                principalTable: "students",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CollegeStudent_colleges_collegeid",
                table: "CollegeStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_CollegeStudent_students_studentid",
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

            migrationBuilder.AlterColumn<int>(
                name: "collegeid",
                table: "CollegeStudent",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CollegeStudent_colleges_collegeid",
                table: "CollegeStudent",
                column: "collegeid",
                principalTable: "colleges",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CollegeStudent_students_studentid",
                table: "CollegeStudent",
                column: "studentid",
                principalTable: "students",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
