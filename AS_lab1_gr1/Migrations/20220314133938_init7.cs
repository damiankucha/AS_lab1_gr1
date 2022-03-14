using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AS_lab1_gr1.Migrations
{
    public partial class init7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Team_League_LeagueId",
                table: "Team");

            migrationBuilder.DropPrimaryKey(
                name: "PK_League",
                table: "League");

            migrationBuilder.RenameTable(
                name: "League",
                newName: "Leagues");

            migrationBuilder.AddColumn<int>(
                name: "MatchId",
                table: "MatchPlayer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Leagues",
                table: "Leagues",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_MatchPlayer_MatchId",
                table: "MatchPlayer",
                column: "MatchId");

            migrationBuilder.AddForeignKey(
                name: "FK_MatchPlayer_Match_MatchId",
                table: "MatchPlayer",
                column: "MatchId",
                principalTable: "Match",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Team_Leagues_LeagueId",
                table: "Team",
                column: "LeagueId",
                principalTable: "Leagues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MatchPlayer_Match_MatchId",
                table: "MatchPlayer");

            migrationBuilder.DropForeignKey(
                name: "FK_Team_Leagues_LeagueId",
                table: "Team");

            migrationBuilder.DropIndex(
                name: "IX_MatchPlayer_MatchId",
                table: "MatchPlayer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Leagues",
                table: "Leagues");

            migrationBuilder.DropColumn(
                name: "MatchId",
                table: "MatchPlayer");

            migrationBuilder.RenameTable(
                name: "Leagues",
                newName: "League");

            migrationBuilder.AddPrimaryKey(
                name: "PK_League",
                table: "League",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Team_League_LeagueId",
                table: "Team",
                column: "LeagueId",
                principalTable: "League",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
