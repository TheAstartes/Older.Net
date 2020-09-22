using Microsoft.EntityFrameworkCore.Migrations;

namespace TheShop.Migrations
{
    public partial class ZmianaModeluOpinia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Wiadomosc",
                table: "Opinie",
                newName: "Message");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Message",
                table: "Opinie",
                newName: "Wiadomosc");
        }
    }
}
