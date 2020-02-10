using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileShop.Model.Migrations
{
    public partial class CetMigracija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Narudzba_Korisnici_KorisniciKorisnikId",
                table: "Narudzba");

            migrationBuilder.RenameColumn(
                name: "KorisniciKorisnikId",
                table: "Narudzba",
                newName: "KorisnikId");

            migrationBuilder.RenameIndex(
                name: "IX_Narudzba_KorisniciKorisnikId",
                table: "Narudzba",
                newName: "IX_Narudzba_KorisnikId");

            migrationBuilder.AddForeignKey(
                name: "FK_Narudzba_Korisnici_KorisnikId",
                table: "Narudzba",
                column: "KorisnikId",
                principalTable: "Korisnici",
                principalColumn: "KorisnikId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Narudzba_Korisnici_KorisnikId",
                table: "Narudzba");

            migrationBuilder.RenameColumn(
                name: "KorisnikId",
                table: "Narudzba",
                newName: "KorisniciKorisnikId");

            migrationBuilder.RenameIndex(
                name: "IX_Narudzba_KorisnikId",
                table: "Narudzba",
                newName: "IX_Narudzba_KorisniciKorisnikId");

            migrationBuilder.AddForeignKey(
                name: "FK_Narudzba_Korisnici_KorisniciKorisnikId",
                table: "Narudzba",
                column: "KorisniciKorisnikId",
                principalTable: "Korisnici",
                principalColumn: "KorisnikId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
