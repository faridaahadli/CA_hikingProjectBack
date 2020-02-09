using Microsoft.EntityFrameworkCore.Migrations;

namespace CA_hikingProject.Migrations
{
    public partial class TourTypeDeleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "StillActive",
                table: "TourTypes",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StillActive",
                table: "TourTypes");
        }
    }
}
