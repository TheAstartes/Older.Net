using Microsoft.EntityFrameworkCore.Migrations;

namespace TheShop.Migrations
{
    public partial class Wallpapers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Pic1",
                table: "Motocykle",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pic2",
                table: "Motocykle",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pic3",
                table: "Motocykle",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Wallpaper",
                table: "Motocykle",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pic1",
                table: "Motocykle");

            migrationBuilder.DropColumn(
                name: "Pic2",
                table: "Motocykle");

            migrationBuilder.DropColumn(
                name: "Pic3",
                table: "Motocykle");

            migrationBuilder.DropColumn(
                name: "Wallpaper",
                table: "Motocykle");
        }
    }
}
