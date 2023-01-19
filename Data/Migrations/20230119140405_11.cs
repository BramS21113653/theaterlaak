using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace theaterlaak.Data.Migrations
{
    public partial class _11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Zitplaats_ZitplaatsId",
                table: "Tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Zitplaats",
                table: "Zitplaats");

            migrationBuilder.RenameTable(
                name: "Zitplaats",
                newName: "Zitplaatsen");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Zitplaatsen",
                table: "Zitplaatsen",
                column: "ZitplaatsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Zitplaatsen_ZitplaatsId",
                table: "Tickets",
                column: "ZitplaatsId",
                principalTable: "Zitplaatsen",
                principalColumn: "ZitplaatsId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Zitplaatsen_ZitplaatsId",
                table: "Tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Zitplaatsen",
                table: "Zitplaatsen");

            migrationBuilder.RenameTable(
                name: "Zitplaatsen",
                newName: "Zitplaats");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Zitplaats",
                table: "Zitplaats",
                column: "ZitplaatsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Zitplaats_ZitplaatsId",
                table: "Tickets",
                column: "ZitplaatsId",
                principalTable: "Zitplaats",
                principalColumn: "ZitplaatsId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
