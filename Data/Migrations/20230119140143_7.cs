using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace theaterlaak.Data.Migrations
{
    public partial class _7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Donaties",
                columns: table => new
                {
                    DonatieId = table.Column<string>(type: "TEXT", nullable: false),
                    datum = table.Column<DateTime>(type: "TEXT", nullable: false),
                    bedrag = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donaties", x => x.DonatieId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Donaties");
        }
    }
}
