using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace theaterlaak.Data.Migrations
{
    public partial class _16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Tickets",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "applicationUserId",
                table: "Tickets",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Boekingen",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "applicationUserId",
                table: "Boekingen",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_applicationUserId",
                table: "Tickets",
                column: "applicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Boekingen_applicationUserId",
                table: "Boekingen",
                column: "applicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Boekingen_AspNetUsers_applicationUserId",
                table: "Boekingen",
                column: "applicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_AspNetUsers_applicationUserId",
                table: "Tickets",
                column: "applicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Boekingen_AspNetUsers_applicationUserId",
                table: "Boekingen");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_AspNetUsers_applicationUserId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_applicationUserId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Boekingen_applicationUserId",
                table: "Boekingen");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "applicationUserId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Boekingen");

            migrationBuilder.DropColumn(
                name: "applicationUserId",
                table: "Boekingen");
        }
    }
}
