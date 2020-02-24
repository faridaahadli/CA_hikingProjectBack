using Microsoft.EntityFrameworkCore.Migrations;

namespace CA_hikingProject.Migrations
{
    public partial class AllImgIdAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OneTourImages_Images_myImageId",
                table: "OneTourImages");

            migrationBuilder.DropIndex(
                name: "IX_OneTourImages_myImageId",
                table: "OneTourImages");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "OneTourImages");

            migrationBuilder.DropColumn(
                name: "myImageId",
                table: "OneTourImages");

            migrationBuilder.AddColumn<int>(
                name: "AllImageId",
                table: "OneTourImages",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OneTourImages_AllImageId",
                table: "OneTourImages",
                column: "AllImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_OneTourImages_Images_AllImageId",
                table: "OneTourImages",
                column: "AllImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OneTourImages_Images_AllImageId",
                table: "OneTourImages");

            migrationBuilder.DropIndex(
                name: "IX_OneTourImages_AllImageId",
                table: "OneTourImages");

            migrationBuilder.DropColumn(
                name: "AllImageId",
                table: "OneTourImages");

            migrationBuilder.AddColumn<int>(
                name: "ImageId",
                table: "OneTourImages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "myImageId",
                table: "OneTourImages",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OneTourImages_myImageId",
                table: "OneTourImages",
                column: "myImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_OneTourImages_Images_myImageId",
                table: "OneTourImages",
                column: "myImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
