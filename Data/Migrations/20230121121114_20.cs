using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace theaterlaak.Data.Migrations
{
    public partial class _20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Voorstellingen_Groepen_groepId1",
                table: "Voorstellingen");

            migrationBuilder.DropIndex(
                name: "IX_Voorstellingen_groepId1",
                table: "Voorstellingen");

            migrationBuilder.DropColumn(
                name: "groepId1",
                table: "Voorstellingen");

            migrationBuilder.AlterColumn<string>(
                name: "groepId",
                table: "Voorstellingen",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.CreateIndex(
                name: "IX_Voorstellingen_groepId",
                table: "Voorstellingen",
                column: "groepId");

            migrationBuilder.AddForeignKey(
                name: "FK_Voorstellingen_Groepen_groepId",
                table: "Voorstellingen",
                column: "groepId",
                principalTable: "Groepen",
                principalColumn: "groepId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Voorstellingen_Groepen_groepId",
                table: "Voorstellingen");

            migrationBuilder.DropIndex(
                name: "IX_Voorstellingen_groepId",
                table: "Voorstellingen");

            migrationBuilder.AlterColumn<int>(
                name: "groepId",
                table: "Voorstellingen",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "groepId1",
                table: "Voorstellingen",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Voorstellingen_groepId1",
                table: "Voorstellingen",
                column: "groepId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Voorstellingen_Groepen_groepId1",
                table: "Voorstellingen",
                column: "groepId1",
                principalTable: "Groepen",
                principalColumn: "groepId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
