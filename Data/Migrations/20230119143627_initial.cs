using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace theaterlaak.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VoorstellingId",
                table: "Gelegenheden",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Gelegenheden_VoorstellingId",
                table: "Gelegenheden",
                column: "VoorstellingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Gelegenheden_Voorstellingen_VoorstellingId",
                table: "Gelegenheden",
                column: "VoorstellingId",
                principalTable: "Voorstellingen",
                principalColumn: "VoorstellingId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gelegenheden_Voorstellingen_VoorstellingId",
                table: "Gelegenheden");

            migrationBuilder.DropIndex(
                name: "IX_Gelegenheden_VoorstellingId",
                table: "Gelegenheden");

            migrationBuilder.DropColumn(
                name: "VoorstellingId",
                table: "Gelegenheden");
        }
    }
}
