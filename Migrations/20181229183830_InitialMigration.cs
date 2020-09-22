using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TheShop.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Motocykle",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Marka = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    RokProdukcji = table.Column<int>(nullable: false),
                    Przebieg = table.Column<string>(nullable: true),
                    Pojemnosc = table.Column<string>(nullable: true),
                    RodzajSilnika = table.Column<string>(nullable: true),
                    Moc = table.Column<string>(nullable: true),
                    Opis = table.Column<string>(nullable: true),
                    Cena = table.Column<decimal>(nullable: false),
                    ZdjecieUrl = table.Column<string>(nullable: true),
                    LogoUrl = table.Column<string>(nullable: true),
                    JestMotocyklemTygodnia = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motocykle", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Motocykle");
        }
    }
}
