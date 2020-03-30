using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileShop.Model.Migrations
{
    public partial class rikoNestoDiro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Narudzba_Korisnici_KorisnikId",
                table: "Narudzba");

            migrationBuilder.DropForeignKey(
                name: "FK_NarudzbaStavke_Artikli_ArtikalId",
                table: "NarudzbaStavke");

            migrationBuilder.AlterColumn<int>(
                name: "ArtikalId",
                table: "NarudzbaStavke",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "KorisnikId",
                table: "Narudzba",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Narudzba_Korisnici_KorisnikId",
                table: "Narudzba",
                column: "KorisnikId",
                principalTable: "Korisnici",
                principalColumn: "KorisnikId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NarudzbaStavke_Artikli_ArtikalId",
                table: "NarudzbaStavke",
                column: "ArtikalId",
                principalTable: "Artikli",
                principalColumn: "ArtikalId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Narudzba_Korisnici_KorisnikId",
                table: "Narudzba");

            migrationBuilder.DropForeignKey(
                name: "FK_NarudzbaStavke_Artikli_ArtikalId",
                table: "NarudzbaStavke");

            migrationBuilder.AlterColumn<int>(
                name: "ArtikalId",
                table: "NarudzbaStavke",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "KorisnikId",
                table: "Narudzba",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Narudzba_Korisnici_KorisnikId",
                table: "Narudzba",
                column: "KorisnikId",
                principalTable: "Korisnici",
                principalColumn: "KorisnikId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NarudzbaStavke_Artikli_ArtikalId",
                table: "NarudzbaStavke",
                column: "ArtikalId",
                principalTable: "Artikli",
                principalColumn: "ArtikalId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
