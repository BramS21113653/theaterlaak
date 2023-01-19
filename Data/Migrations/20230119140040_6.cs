using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace theaterlaak.Data.Migrations
{
    public partial class _6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gelegenheden",
                columns: table => new
                {
                    GelegenheidId = table.Column<string>(type: "TEXT", nullable: false),
                    aanvangstijd = table.Column<DateTime>(type: "TEXT", nullable: false),
                    eindtijd = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ZaalId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gelegenheden", x => x.GelegenheidId);
                    table.ForeignKey(
                        name: "FK_Gelegenheden_Zalen_ZaalId",
                        column: x => x.ZaalId,
                        principalTable: "Zalen",
                        principalColumn: "ZaalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Gelegenheden_ZaalId",
                table: "Gelegenheden",
                column: "ZaalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gelegenheden");
        }
    }
}
