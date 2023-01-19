using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace theaterlaak.Data.Migrations
{
    public partial class _4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "test",
                table: "Boekingen",
                newName: "ZaalId");

            migrationBuilder.CreateTable(
                name: "Zalen",
                columns: table => new
                {
                    ZaalId = table.Column<string>(type: "TEXT", nullable: false),
                    zaalnummer = table.Column<int>(type: "INTEGER", nullable: false),
                    aantalZitplaatsen = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zalen", x => x.ZaalId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Boekingen_ZaalId",
                table: "Boekingen",
                column: "ZaalId");

            migrationBuilder.AddForeignKey(
                name: "FK_Boekingen_Zalen_ZaalId",
                table: "Boekingen",
                column: "ZaalId",
                principalTable: "Zalen",
                principalColumn: "ZaalId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Boekingen_Zalen_ZaalId",
                table: "Boekingen");

            migrationBuilder.DropTable(
                name: "Zalen");

            migrationBuilder.DropIndex(
                name: "IX_Boekingen_ZaalId",
                table: "Boekingen");

            migrationBuilder.RenameColumn(
                name: "ZaalId",
                table: "Boekingen",
                newName: "test");
        }
    }
}
