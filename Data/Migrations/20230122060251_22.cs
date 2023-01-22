using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace theaterlaak.Data.Migrations
{
    public partial class _22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "groepId",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_groepId",
                table: "AspNetUsers",
                column: "groepId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Groepen_groepId",
                table: "AspNetUsers",
                column: "groepId",
                principalTable: "Groepen",
                principalColumn: "groepId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Groepen_groepId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_groepId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "groepId",
                table: "AspNetUsers");
        }
    }
}
