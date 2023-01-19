using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace theaterlaak.Data.Migrations
{
    public partial class _10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Zitplaats",
                columns: table => new
                {
                    ZitplaatsId = table.Column<string>(type: "TEXT", nullable: false),
                    stoelnummer = table.Column<int>(type: "INTEGER", nullable: false),
                    rangnummer = table.Column<int>(type: "INTEGER", nullable: false),
                    ZaalId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zitplaats", x => x.ZitplaatsId);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    TicketId = table.Column<string>(type: "TEXT", nullable: false),
                    ZitplaatsId = table.Column<string>(type: "TEXT", nullable: false),
                    VoorstellingId = table.Column<string>(type: "TEXT", nullable: false),
                    prijs = table.Column<double>(type: "REAL", nullable: false),
                    ZaalId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.TicketId);
                    table.ForeignKey(
                        name: "FK_Tickets_Voorstellingen_VoorstellingId",
                        column: x => x.VoorstellingId,
                        principalTable: "Voorstellingen",
                        principalColumn: "VoorstellingId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Zalen_ZaalId",
                        column: x => x.ZaalId,
                        principalTable: "Zalen",
                        principalColumn: "ZaalId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Zitplaats_ZitplaatsId",
                        column: x => x.ZitplaatsId,
                        principalTable: "Zitplaats",
                        principalColumn: "ZitplaatsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_VoorstellingId",
                table: "Tickets",
                column: "VoorstellingId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ZaalId",
                table: "Tickets",
                column: "ZaalId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ZitplaatsId",
                table: "Tickets",
                column: "ZitplaatsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Zitplaats");
        }
    }
}
