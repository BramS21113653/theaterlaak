using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace theaterlaak.Data.Migrations
{
    public partial class _18 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groepen_Voorstellingen_voorstellingId",
                table: "Groepen");

            migrationBuilder.DropIndex(
                name: "IX_Groepen_voorstellingId",
                table: "Groepen");

            migrationBuilder.DropColumn(
                name: "voorstellingId",
                table: "Groepen");

            migrationBuilder.AddColumn<int>(
                name: "groepId",
                table: "Voorstellingen",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "groepId1",
                table: "Voorstellingen",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Voorstellingen_groepId1",
                table: "Voorstellingen",
                column: "groepId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Voorstellingen_Groepen_groepId1",
                table: "Voorstellingen",
                column: "groepId1",
                principalTable: "Groepen",
                principalColumn: "groepId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Voorstellingen_Groepen_groepId1",
                table: "Voorstellingen");

            migrationBuilder.DropIndex(
                name: "IX_Voorstellingen_groepId1",
                table: "Voorstellingen");

            migrationBuilder.DropColumn(
                name: "groepId",
                table: "Voorstellingen");

            migrationBuilder.DropColumn(
                name: "groepId1",
                table: "Voorstellingen");

            migrationBuilder.AddColumn<string>(
                name: "voorstellingId",
                table: "Groepen",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Groepen_voorstellingId",
                table: "Groepen",
                column: "voorstellingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Groepen_Voorstellingen_voorstellingId",
                table: "Groepen",
                column: "voorstellingId",
                principalTable: "Voorstellingen",
                principalColumn: "voorstellingId");
        }
    }
}
