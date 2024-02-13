using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityTest.Migrations
{
    /// <inheritdoc />
    public partial class testNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Describtion",
                table: "departments",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Describtion",
                table: "departments");
        }
    }
}
