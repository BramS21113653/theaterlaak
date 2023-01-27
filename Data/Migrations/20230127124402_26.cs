using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace theaterlaak.Data.Migrations
{
    public partial class _26 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "soortZitplaats",
                table: "Zitplaatsen");

            migrationBuilder.DropColumn(
                name: "zaalnummer",
                table: "Zalen");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "soortZitplaats",
                table: "Zitplaatsen",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "zaalnummer",
                table: "Zalen",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
