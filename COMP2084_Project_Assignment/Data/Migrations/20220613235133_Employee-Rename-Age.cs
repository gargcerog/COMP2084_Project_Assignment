using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace COMP2084_Project_Assignment.Data.Migrations
{
    public partial class EmployeeRenameAge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "age",
                table: "Employee",
                newName: "Age");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Age",
                table: "Employee",
                newName: "age");
        }
    }
}
