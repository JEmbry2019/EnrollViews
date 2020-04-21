using Microsoft.EntityFrameworkCore.Migrations;

namespace EnrollView.Migrations
{
    public partial class Names2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "First Name",
                table: "Students",
                newName: "Last Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Last Name",
                table: "Students",
                newName: "First Name");
        }
    }
}
