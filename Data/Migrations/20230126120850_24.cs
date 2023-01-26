using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace theaterlaak.Data.Migrations
{
    public partial class _24 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "voorstellingType",
                table: "Voorstellingen",
                newName: "voorstellingGenre");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "voorstellingGenre",
                table: "Voorstellingen",
                newName: "voorstellingType");
        }
    }
}
