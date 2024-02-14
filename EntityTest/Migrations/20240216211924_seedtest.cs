using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EntityTest.Migrations
{
    /// <inheritdoc />
    public partial class seedtest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_grades_students_studentId",
                table: "grades");

            migrationBuilder.EnsureSchema(
                name: "tablescheme");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "students",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "departmentId",
                table: "students",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Describtion",
                table: "departments",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "genders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenderName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tablename",
                schema: "tablescheme",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    studentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tablename", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tablename_students_studentId",
                        column: x => x.studentId,
                        principalTable: "students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "studentBooks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    studentId = table.Column<int>(type: "int", nullable: false),
                    bookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_studentBooks_books_bookId",
                        column: x => x.bookId,
                        principalTable: "books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_studentBooks_students_studentId",
                        column: x => x.studentId,
                        principalTable: "students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "genders",
                columns: new[] { "Id", "GenderName" },
                values: new object[,]
                {
                    { 1, "Male" },
                    { 2, "Female" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_students_departmentId",
                table: "students",
                column: "departmentId");

            migrationBuilder.CreateIndex(
                name: "IX_students_Name",
                table: "students",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_studentBooks_bookId",
                table: "studentBooks",
                column: "bookId");

            migrationBuilder.CreateIndex(
                name: "IX_studentBooks_studentId",
                table: "studentBooks",
                column: "studentId");

            migrationBuilder.CreateIndex(
                name: "IX_tablename_studentId",
                schema: "tablescheme",
                table: "tablename",
                column: "studentId");

            migrationBuilder.AddForeignKey(
                name: "FK_grades_students_studentId",
                table: "grades",
                column: "studentId",
                principalTable: "students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_students_departments_departmentId",
                table: "students",
                column: "departmentId",
                principalTable: "departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_grades_students_studentId",
                table: "grades");

            migrationBuilder.DropForeignKey(
                name: "FK_students_departments_departmentId",
                table: "students");

            migrationBuilder.DropTable(
                name: "genders");

            migrationBuilder.DropTable(
                name: "studentBooks");

            migrationBuilder.DropTable(
                name: "tablename",
                schema: "tablescheme");

            migrationBuilder.DropTable(
                name: "books");

            migrationBuilder.DropIndex(
                name: "IX_students_departmentId",
                table: "students");

            migrationBuilder.DropIndex(
                name: "IX_students_Name",
                table: "students");

            migrationBuilder.DropColumn(
                name: "departmentId",
                table: "students");

            migrationBuilder.DropColumn(
                name: "Describtion",
                table: "departments");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "students",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_grades_students_studentId",
                table: "grades",
                column: "studentId",
                principalTable: "students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
