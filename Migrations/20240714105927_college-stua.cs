using Microsoft.EntityFrameworkCore.Migrations;

namespace Cliqlearn.Migrations
{
    public partial class collegestua : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CollegeStudent_colleges_collegeid",
                table: "CollegeStudent");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CollegeStudent_colleges_collegeid",
                table: "CollegeStudent");

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
        }
    }
}
