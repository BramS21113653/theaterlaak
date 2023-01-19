using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace theaterlaak.Data.Migrations
{
    public partial class _9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VoorstellingId",
                table: "Groepen",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Voorstellingen",
                columns: table => new
                {
                    VoorstellingId = table.Column<string>(type: "TEXT", nullable: false),
                    type = table.Column<string>(type: "TEXT", nullable: false),
                    titel = table.Column<string>(type: "TEXT", nullable: false),
                    omschrijving = table.Column<string>(type: "TEXT", nullable: false),
                    prijs = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voorstellingen", x => x.VoorstellingId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Groepen_VoorstellingId",
                table: "Groepen",
                column: "VoorstellingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Groepen_Voorstellingen_VoorstellingId",
                table: "Groepen",
                column: "VoorstellingId",
                principalTable: "Voorstellingen",
                principalColumn: "VoorstellingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groepen_Voorstellingen_VoorstellingId",
                table: "Groepen");

            migrationBuilder.DropTable(
                name: "Voorstellingen");

            migrationBuilder.DropIndex(
                name: "IX_Groepen_VoorstellingId",
                table: "Groepen");

            migrationBuilder.DropColumn(
                name: "VoorstellingId",
                table: "Groepen");
        }
    }
}
