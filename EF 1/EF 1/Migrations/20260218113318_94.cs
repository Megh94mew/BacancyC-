using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EF_1.Migrations
{
    /// <inheritdoc />
    public partial class _94 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "students",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "students",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "students",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AddColumn<int>(
                name: "studentId",
                table: "students",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Fees",
                table: "courses",
                type: "decimal(18,0)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "courses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "trainer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExperienceYears = table.Column<int>(type: "int", nullable: false),
                    trainerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trainer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_trainer_trainer_trainerId",
                        column: x => x.trainerId,
                        principalTable: "trainer",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "courses",
                columns: new[] { "Id", "CourseId", "DurationinMonths", "Fees", "Title" },
                values: new object[,]
                {
                    { 1, null, 6, 25600m, ".NET Core" },
                    { 2, null, 3, 15500m, "LINQ" }
                });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "Id", "CreatedDate", "Email", "Name", "studentId" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "het@gmail.com", "Het", null },
                    { 2, new DateTime(2026, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "jeet@gmail.com", "Jeet", null }
                });

            migrationBuilder.InsertData(
                table: "trainer",
                columns: new[] { "Id", "ExperienceYears", "Name", "trainerId" },
                values: new object[,]
                {
                    { 1, 6, "Mewada", null },
                    { 2, 4, "Raj", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_students_studentId",
                table: "students",
                column: "studentId");

            migrationBuilder.CreateIndex(
                name: "IX_courses_CourseId",
                table: "courses",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_trainer_trainerId",
                table: "trainer",
                column: "trainerId");

            migrationBuilder.AddForeignKey(
                name: "FK_courses_courses_CourseId",
                table: "courses",
                column: "CourseId",
                principalTable: "courses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_students_students_studentId",
                table: "students",
                column: "studentId",
                principalTable: "students",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_courses_courses_CourseId",
                table: "courses");

            migrationBuilder.DropForeignKey(
                name: "FK_students_students_studentId",
                table: "students");

            migrationBuilder.DropTable(
                name: "trainer");

            migrationBuilder.DropIndex(
                name: "IX_students_studentId",
                table: "students");

            migrationBuilder.DropIndex(
                name: "IX_courses_CourseId",
                table: "courses");

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "studentId",
                table: "students");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "courses");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "students",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "Email",
                table: "students",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "CreatedDate",
                table: "students",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "Fees",
                table: "courses",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,0)");
        }
    }
}
