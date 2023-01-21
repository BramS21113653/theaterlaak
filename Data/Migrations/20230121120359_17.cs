using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace theaterlaak.Data.Migrations
{
    public partial class _17 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Boekingen_Zalen_ZaalId",
                table: "Boekingen");

            migrationBuilder.DropForeignKey(
                name: "FK_Gelegenheden_Voorstellingen_VoorstellingId",
                table: "Gelegenheden");

            migrationBuilder.DropForeignKey(
                name: "FK_Gelegenheden_Zalen_ZaalId",
                table: "Gelegenheden");

            migrationBuilder.DropForeignKey(
                name: "FK_Groepen_Voorstellingen_VoorstellingId",
                table: "Groepen");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Boekingen_BoekingId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Voorstellingen_VoorstellingId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Zalen_ZaalId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Zitplaatsen_ZitplaatsId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Zitplaatsen_Zalen_ZaalId",
                table: "Zitplaatsen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Interesses",
                table: "Interesses");

            migrationBuilder.DropColumn(
                name: "InteresseId",
                table: "Interesses");

            migrationBuilder.RenameColumn(
                name: "ZaalId",
                table: "Zitplaatsen",
                newName: "zaalId");

            migrationBuilder.RenameColumn(
                name: "ZitplaatsId",
                table: "Zitplaatsen",
                newName: "zitplaatsId");

            migrationBuilder.RenameIndex(
                name: "IX_Zitplaatsen_ZaalId",
                table: "Zitplaatsen",
                newName: "IX_Zitplaatsen_zaalId");

            migrationBuilder.RenameColumn(
                name: "ZaalId",
                table: "Zalen",
                newName: "zaalId");

            migrationBuilder.RenameColumn(
                name: "VoorstellingId",
                table: "Voorstellingen",
                newName: "voorstellingId");

            migrationBuilder.RenameColumn(
                name: "type",
                table: "Voorstellingen",
                newName: "voorstellingType");

            migrationBuilder.RenameColumn(
                name: "ZitplaatsId",
                table: "Tickets",
                newName: "zitplaatsId");

            migrationBuilder.RenameColumn(
                name: "ZaalId",
                table: "Tickets",
                newName: "zaalId");

            migrationBuilder.RenameColumn(
                name: "VoorstellingId",
                table: "Tickets",
                newName: "voorstellingId");

            migrationBuilder.RenameColumn(
                name: "BoekingId",
                table: "Tickets",
                newName: "boekingId");

            migrationBuilder.RenameColumn(
                name: "TicketId",
                table: "Tickets",
                newName: "ticketId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_ZitplaatsId",
                table: "Tickets",
                newName: "IX_Tickets_zitplaatsId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_ZaalId",
                table: "Tickets",
                newName: "IX_Tickets_zaalId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_VoorstellingId",
                table: "Tickets",
                newName: "IX_Tickets_voorstellingId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_BoekingId",
                table: "Tickets",
                newName: "IX_Tickets_boekingId");

            migrationBuilder.RenameColumn(
                name: "VoorstellingId",
                table: "Groepen",
                newName: "voorstellingId");

            migrationBuilder.RenameColumn(
                name: "GroepId",
                table: "Groepen",
                newName: "groepId");

            migrationBuilder.RenameIndex(
                name: "IX_Groepen_VoorstellingId",
                table: "Groepen",
                newName: "IX_Groepen_voorstellingId");

            migrationBuilder.RenameColumn(
                name: "ZaalId",
                table: "Gelegenheden",
                newName: "zaalId");

            migrationBuilder.RenameColumn(
                name: "VoorstellingId",
                table: "Gelegenheden",
                newName: "voorstellingId");

            migrationBuilder.RenameColumn(
                name: "GelegenheidId",
                table: "Gelegenheden",
                newName: "gelegenheidId");

            migrationBuilder.RenameIndex(
                name: "IX_Gelegenheden_ZaalId",
                table: "Gelegenheden",
                newName: "IX_Gelegenheden_zaalId");

            migrationBuilder.RenameIndex(
                name: "IX_Gelegenheden_VoorstellingId",
                table: "Gelegenheden",
                newName: "IX_Gelegenheden_voorstellingId");

            migrationBuilder.RenameColumn(
                name: "DonatieId",
                table: "Donaties",
                newName: "donatieId");

            migrationBuilder.RenameColumn(
                name: "ZaalId",
                table: "Boekingen",
                newName: "zaalId");

            migrationBuilder.RenameColumn(
                name: "BoekingId",
                table: "Boekingen",
                newName: "boekingId");

            migrationBuilder.RenameIndex(
                name: "IX_Boekingen_ZaalId",
                table: "Boekingen",
                newName: "IX_Boekingen_zaalId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Interesses",
                table: "Interesses",
                column: "interesse");

            migrationBuilder.AddForeignKey(
                name: "FK_Boekingen_Zalen_zaalId",
                table: "Boekingen",
                column: "zaalId",
                principalTable: "Zalen",
                principalColumn: "zaalId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Gelegenheden_Voorstellingen_voorstellingId",
                table: "Gelegenheden",
                column: "voorstellingId",
                principalTable: "Voorstellingen",
                principalColumn: "voorstellingId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Gelegenheden_Zalen_zaalId",
                table: "Gelegenheden",
                column: "zaalId",
                principalTable: "Zalen",
                principalColumn: "zaalId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Groepen_Voorstellingen_voorstellingId",
                table: "Groepen",
                column: "voorstellingId",
                principalTable: "Voorstellingen",
                principalColumn: "voorstellingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Boekingen_boekingId",
                table: "Tickets",
                column: "boekingId",
                principalTable: "Boekingen",
                principalColumn: "boekingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Voorstellingen_voorstellingId",
                table: "Tickets",
                column: "voorstellingId",
                principalTable: "Voorstellingen",
                principalColumn: "voorstellingId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Zalen_zaalId",
                table: "Tickets",
                column: "zaalId",
                principalTable: "Zalen",
                principalColumn: "zaalId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Zitplaatsen_zitplaatsId",
                table: "Tickets",
                column: "zitplaatsId",
                principalTable: "Zitplaatsen",
                principalColumn: "zitplaatsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Zitplaatsen_Zalen_zaalId",
                table: "Zitplaatsen",
                column: "zaalId",
                principalTable: "Zalen",
                principalColumn: "zaalId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Boekingen_Zalen_zaalId",
                table: "Boekingen");

            migrationBuilder.DropForeignKey(
                name: "FK_Gelegenheden_Voorstellingen_voorstellingId",
                table: "Gelegenheden");

            migrationBuilder.DropForeignKey(
                name: "FK_Gelegenheden_Zalen_zaalId",
                table: "Gelegenheden");

            migrationBuilder.DropForeignKey(
                name: "FK_Groepen_Voorstellingen_voorstellingId",
                table: "Groepen");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Boekingen_boekingId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Voorstellingen_voorstellingId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Zalen_zaalId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Zitplaatsen_zitplaatsId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Zitplaatsen_Zalen_zaalId",
                table: "Zitplaatsen");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Interesses",
                table: "Interesses");

            migrationBuilder.RenameColumn(
                name: "zaalId",
                table: "Zitplaatsen",
                newName: "ZaalId");

            migrationBuilder.RenameColumn(
                name: "zitplaatsId",
                table: "Zitplaatsen",
                newName: "ZitplaatsId");

            migrationBuilder.RenameIndex(
                name: "IX_Zitplaatsen_zaalId",
                table: "Zitplaatsen",
                newName: "IX_Zitplaatsen_ZaalId");

            migrationBuilder.RenameColumn(
                name: "zaalId",
                table: "Zalen",
                newName: "ZaalId");

            migrationBuilder.RenameColumn(
                name: "voorstellingId",
                table: "Voorstellingen",
                newName: "VoorstellingId");

            migrationBuilder.RenameColumn(
                name: "voorstellingType",
                table: "Voorstellingen",
                newName: "type");

            migrationBuilder.RenameColumn(
                name: "zitplaatsId",
                table: "Tickets",
                newName: "ZitplaatsId");

            migrationBuilder.RenameColumn(
                name: "zaalId",
                table: "Tickets",
                newName: "ZaalId");

            migrationBuilder.RenameColumn(
                name: "voorstellingId",
                table: "Tickets",
                newName: "VoorstellingId");

            migrationBuilder.RenameColumn(
                name: "boekingId",
                table: "Tickets",
                newName: "BoekingId");

            migrationBuilder.RenameColumn(
                name: "ticketId",
                table: "Tickets",
                newName: "TicketId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_zitplaatsId",
                table: "Tickets",
                newName: "IX_Tickets_ZitplaatsId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_zaalId",
                table: "Tickets",
                newName: "IX_Tickets_ZaalId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_voorstellingId",
                table: "Tickets",
                newName: "IX_Tickets_VoorstellingId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_boekingId",
                table: "Tickets",
                newName: "IX_Tickets_BoekingId");

            migrationBuilder.RenameColumn(
                name: "voorstellingId",
                table: "Groepen",
                newName: "VoorstellingId");

            migrationBuilder.RenameColumn(
                name: "groepId",
                table: "Groepen",
                newName: "GroepId");

            migrationBuilder.RenameIndex(
                name: "IX_Groepen_voorstellingId",
                table: "Groepen",
                newName: "IX_Groepen_VoorstellingId");

            migrationBuilder.RenameColumn(
                name: "zaalId",
                table: "Gelegenheden",
                newName: "ZaalId");

            migrationBuilder.RenameColumn(
                name: "voorstellingId",
                table: "Gelegenheden",
                newName: "VoorstellingId");

            migrationBuilder.RenameColumn(
                name: "gelegenheidId",
                table: "Gelegenheden",
                newName: "GelegenheidId");

            migrationBuilder.RenameIndex(
                name: "IX_Gelegenheden_zaalId",
                table: "Gelegenheden",
                newName: "IX_Gelegenheden_ZaalId");

            migrationBuilder.RenameIndex(
                name: "IX_Gelegenheden_voorstellingId",
                table: "Gelegenheden",
                newName: "IX_Gelegenheden_VoorstellingId");

            migrationBuilder.RenameColumn(
                name: "donatieId",
                table: "Donaties",
                newName: "DonatieId");

            migrationBuilder.RenameColumn(
                name: "zaalId",
                table: "Boekingen",
                newName: "ZaalId");

            migrationBuilder.RenameColumn(
                name: "boekingId",
                table: "Boekingen",
                newName: "BoekingId");

            migrationBuilder.RenameIndex(
                name: "IX_Boekingen_zaalId",
                table: "Boekingen",
                newName: "IX_Boekingen_ZaalId");

            migrationBuilder.AddColumn<int>(
                name: "InteresseId",
                table: "Interesses",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Interesses",
                table: "Interesses",
                column: "InteresseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Boekingen_Zalen_ZaalId",
                table: "Boekingen",
                column: "ZaalId",
                principalTable: "Zalen",
                principalColumn: "ZaalId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Gelegenheden_Voorstellingen_VoorstellingId",
                table: "Gelegenheden",
                column: "VoorstellingId",
                principalTable: "Voorstellingen",
                principalColumn: "VoorstellingId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Gelegenheden_Zalen_ZaalId",
                table: "Gelegenheden",
                column: "ZaalId",
                principalTable: "Zalen",
                principalColumn: "ZaalId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Groepen_Voorstellingen_VoorstellingId",
                table: "Groepen",
                column: "VoorstellingId",
                principalTable: "Voorstellingen",
                principalColumn: "VoorstellingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Boekingen_BoekingId",
                table: "Tickets",
                column: "BoekingId",
                principalTable: "Boekingen",
                principalColumn: "BoekingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Voorstellingen_VoorstellingId",
                table: "Tickets",
                column: "VoorstellingId",
                principalTable: "Voorstellingen",
                principalColumn: "VoorstellingId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Zalen_ZaalId",
                table: "Tickets",
                column: "ZaalId",
                principalTable: "Zalen",
                principalColumn: "ZaalId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Zitplaatsen_ZitplaatsId",
                table: "Tickets",
                column: "ZitplaatsId",
                principalTable: "Zitplaatsen",
                principalColumn: "ZitplaatsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Zitplaatsen_Zalen_ZaalId",
                table: "Zitplaatsen",
                column: "ZaalId",
                principalTable: "Zalen",
                principalColumn: "ZaalId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
