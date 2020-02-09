using Microsoft.EntityFrameworkCore.Migrations;

namespace CA_hikingProject.Migrations
{
    public partial class delteDescripForSingleTour : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Decription",
                table: "SingleTours");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Decription",
                table: "SingleTours",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
