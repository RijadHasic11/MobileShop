using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileShop.Model.Migrations
{
    public partial class PopravkaKarakteristike : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artikli_Karakteristike_KarakteristikeId",
                table: "Artikli");

            migrationBuilder.DropTable(
                name: "Karakteristike");

            migrationBuilder.DropIndex(
                name: "IX_Artikli_KarakteristikeId",
                table: "Artikli");

            migrationBuilder.DropColumn(
                name: "KarakteristikeId",
                table: "Artikli");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KarakteristikeId",
                table: "Artikli",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Karakteristike",
                columns: table => new
                {
                    KarakteristikeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Kamera = table.Column<decimal>(nullable: false),
                    Memorija = table.Column<decimal>(nullable: false),
                    Novo = table.Column<bool>(nullable: false),
                    OperativniSistem = table.Column<string>(nullable: true),
                    Procesor = table.Column<decimal>(nullable: false),
                    Ram = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Karakteristike", x => x.KarakteristikeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artikli_KarakteristikeId",
                table: "Artikli",
                column: "KarakteristikeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Artikli_Karakteristike_KarakteristikeId",
                table: "Artikli",
                column: "KarakteristikeId",
                principalTable: "Karakteristike",
                principalColumn: "KarakteristikeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
