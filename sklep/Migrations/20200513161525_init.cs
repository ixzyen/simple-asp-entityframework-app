using Microsoft.EntityFrameworkCore.Migrations;

namespace sklep.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "klienci",
                columns: table => new
                {
                    KlientId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imie = table.Column<string>(nullable: true),
                    Nazwisko = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_klienci", x => x.KlientId);
                });

            migrationBuilder.CreateTable(
                name: "produkty",
                columns: table => new
                {
                    ProduktId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(nullable: true),
                    Kategoria = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produkty", x => x.ProduktId);
                });

            migrationBuilder.CreateTable(
                name: "zamowienia",
                columns: table => new
                {
                    ZamowienieId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProduktFK = table.Column<int>(nullable: false),
                    KlientFK = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_zamowienia", x => x.ZamowienieId);
                    table.ForeignKey(
                        name: "FK_zamowienia_klienci_KlientFK",
                        column: x => x.KlientFK,
                        principalTable: "klienci",
                        principalColumn: "KlientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_zamowienia_produkty_ProduktFK",
                        column: x => x.ProduktFK,
                        principalTable: "produkty",
                        principalColumn: "ProduktId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_zamowienia_KlientFK",
                table: "zamowienia",
                column: "KlientFK");

            migrationBuilder.CreateIndex(
                name: "IX_zamowienia_ProduktFK",
                table: "zamowienia",
                column: "ProduktFK",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "zamowienia");

            migrationBuilder.DropTable(
                name: "klienci");

            migrationBuilder.DropTable(
                name: "produkty");
        }
    }
}
