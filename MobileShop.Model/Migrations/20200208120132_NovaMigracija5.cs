using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileShop.Model.Migrations
{
    public partial class NovaMigracija5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Prioritet",
                table: "Zahtjevi");

            migrationBuilder.RenameColumn(
                name: "Odgovoren",
                table: "Zahtjevi",
                newName: "Naslov");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Naslov",
                table: "Zahtjevi",
                newName: "Odgovoren");

            migrationBuilder.AddColumn<int>(
                name: "Prioritet",
                table: "Zahtjevi",
                nullable: false,
                defaultValue: 0);
        }
    }
}
