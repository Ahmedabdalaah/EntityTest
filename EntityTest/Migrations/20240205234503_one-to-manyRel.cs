﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityTest.Migrations
{
    /// <inheritdoc />
    public partial class onetomanyRel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "departmentId",
                table: "students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_students_departmentId",
                table: "students",
                column: "departmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_students_departments_departmentId",
                table: "students",
                column: "departmentId",
                principalTable: "departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_departments_departmentId",
                table: "students");

            migrationBuilder.DropIndex(
                name: "IX_students_departmentId",
                table: "students");

            migrationBuilder.DropColumn(
                name: "departmentId",
                table: "students");
        }
    }
}
