using Microsoft.EntityFrameworkCore.Migrations;

namespace TheShop.Migrations
{
    public partial class DodanieStringaDoModelu1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ZdjeciePrezentacja",
                table: "Motocykle",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ZdjeciePrezentacja",
                table: "Motocykle");
        }
    }
}
