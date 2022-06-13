using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace COMP2084_Project_Assignment.Data.Migrations
{
    public partial class EmployeeAddAge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "age",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "age",
                table: "Employee");
        }
    }
}
