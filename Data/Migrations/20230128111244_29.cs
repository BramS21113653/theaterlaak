using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace theaterlaak.Data.Migrations
{
    public partial class _29 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Betalingen",
                columns: table => new
                {
                    reference = table.Column<string>(type: "TEXT", nullable: false),
                    succes = table.Column<bool>(type: "INTEGER", nullable: false),
                    account = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Betalingen", x => x.reference);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Betalingen");
        }
    }
}
