using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace theaterlaak.Data.Migrations
{
    public partial class _12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BoekingId",
                table: "Tickets",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Zitplaatsen_ZaalId",
                table: "Zitplaatsen",
                column: "ZaalId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_BoekingId",
                table: "Tickets",
                column: "BoekingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Boekingen_BoekingId",
                table: "Tickets",
                column: "BoekingId",
                principalTable: "Boekingen",
                principalColumn: "BoekingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Zitplaatsen_Zalen_ZaalId",
                table: "Zitplaatsen",
                column: "ZaalId",
                principalTable: "Zalen",
                principalColumn: "ZaalId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Boekingen_BoekingId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Zitplaatsen_Zalen_ZaalId",
                table: "Zitplaatsen");

            migrationBuilder.DropIndex(
                name: "IX_Zitplaatsen_ZaalId",
                table: "Zitplaatsen");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_BoekingId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "BoekingId",
                table: "Tickets");
        }
    }
}
