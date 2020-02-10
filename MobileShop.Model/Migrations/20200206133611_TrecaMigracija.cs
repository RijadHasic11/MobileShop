using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileShop.Model.Migrations
{
    public partial class TrecaMigracija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Narudzba_Klijenti_KlijentId",
                table: "Narudzba");

            migrationBuilder.DropColumn(
                name: "KupacId",
                table: "Narudzba");

            migrationBuilder.AlterColumn<int>(
                name: "KlijentId",
                table: "Narudzba",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Narudzba_Klijenti_KlijentId",
                table: "Narudzba",
                column: "KlijentId",
                principalTable: "Klijenti",
                principalColumn: "KlijentId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Narudzba_Klijenti_KlijentId",
                table: "Narudzba");

            migrationBuilder.AlterColumn<int>(
                name: "KlijentId",
                table: "Narudzba",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "KupacId",
                table: "Narudzba",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Narudzba_Klijenti_KlijentId",
                table: "Narudzba",
                column: "KlijentId",
                principalTable: "Klijenti",
                principalColumn: "KlijentId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
