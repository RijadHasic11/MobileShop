using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileShop.Model.Migrations
{
    public partial class MigracijaPoslanaNarudzba : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PoslanaNarudzba",
                columns: table => new
                {
                    PoslanaNarudzbaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KlijentId = table.Column<int>(nullable: false),
                    KorisnikId = table.Column<int>(nullable: false),
                    Datum = table.Column<DateTime>(nullable: false),
                    Poslano = table.Column<bool>(nullable: false),
                    NarudzbaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PoslanaNarudzba", x => x.PoslanaNarudzbaId);
                    table.ForeignKey(
                        name: "FK_PoslanaNarudzba_Klijenti_KlijentId",
                        column: x => x.KlijentId,
                        principalTable: "Klijenti",
                        principalColumn: "KlijentId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PoslanaNarudzba_Korisnici_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PoslanaNarudzba_Narudzba_NarudzbaId",
                        column: x => x.NarudzbaId,
                        principalTable: "Narudzba",
                        principalColumn: "NarudzbaId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PoslanaNarudzba_KlijentId",
                table: "PoslanaNarudzba",
                column: "KlijentId");

            migrationBuilder.CreateIndex(
                name: "IX_PoslanaNarudzba_KorisnikId",
                table: "PoslanaNarudzba",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_PoslanaNarudzba_NarudzbaId",
                table: "PoslanaNarudzba",
                column: "NarudzbaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PoslanaNarudzba");
        }
    }
}
