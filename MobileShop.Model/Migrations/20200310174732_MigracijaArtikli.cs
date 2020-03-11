using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileShop.Model.Migrations
{
    public partial class MigracijaArtikli : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ModelId",
                table: "Artikli",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProizvodjacId",
                table: "Artikli",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Modeli",
                columns: table => new
                {
                    ModelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modeli", x => x.ModelId);
                });

            migrationBuilder.CreateTable(
                name: "Proizvodjaci",
                columns: table => new
                {
                    ProizvodjacId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proizvodjaci", x => x.ProizvodjacId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artikli_ModelId",
                table: "Artikli",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Artikli_ProizvodjacId",
                table: "Artikli",
                column: "ProizvodjacId");

            migrationBuilder.AddForeignKey(
                name: "FK_Artikli_Modeli_ModelId",
                table: "Artikli",
                column: "ModelId",
                principalTable: "Modeli",
                principalColumn: "ModelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Artikli_Proizvodjaci_ProizvodjacId",
                table: "Artikli",
                column: "ProizvodjacId",
                principalTable: "Proizvodjaci",
                principalColumn: "ProizvodjacId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artikli_Modeli_ModelId",
                table: "Artikli");

            migrationBuilder.DropForeignKey(
                name: "FK_Artikli_Proizvodjaci_ProizvodjacId",
                table: "Artikli");

            migrationBuilder.DropTable(
                name: "Modeli");

            migrationBuilder.DropTable(
                name: "Proizvodjaci");

            migrationBuilder.DropIndex(
                name: "IX_Artikli_ModelId",
                table: "Artikli");

            migrationBuilder.DropIndex(
                name: "IX_Artikli_ProizvodjacId",
                table: "Artikli");

            migrationBuilder.DropColumn(
                name: "ModelId",
                table: "Artikli");

            migrationBuilder.DropColumn(
                name: "ProizvodjacId",
                table: "Artikli");
        }
    }
}
