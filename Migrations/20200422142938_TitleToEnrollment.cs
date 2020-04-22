using Microsoft.EntityFrameworkCore.Migrations;

namespace EnrollView.Migrations
{
    public partial class TitleToEnrollment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Enrollments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Enrollments");
        }
    }
}
