using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AS_lab1_gr1.Migrations
{
    public partial class MZ1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Match_MatchId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Match_Team_AwayTeamId",
                table: "Match");

            migrationBuilder.DropForeignKey(
                name: "FK_Match_Team_HomeTeamId",
                table: "Match");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchEvent_EventType_EventTypeId",
                table: "MatchEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchEvent_Match_MatchId",
                table: "MatchEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchEvent_MatchPlayer_MatchPlayerId",
                table: "MatchEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchPlayer_Match_MatchId",
                table: "MatchPlayer");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchPlayer_Player_PlayerId",
                table: "MatchPlayer");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchPlayer_Position_PositionId",
                table: "MatchPlayer");

            migrationBuilder.DropForeignKey(
                name: "FK_Player_Team_TeamId",
                table: "Player");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerPosition_Player_PlayersId",
                table: "PlayerPosition");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerPosition_Position_PositionsId",
                table: "PlayerPosition");

            migrationBuilder.DropForeignKey(
                name: "FK_Team_Leagues_LeagueId",
                table: "Team");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Team",
                table: "Team");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Position",
                table: "Position");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Player",
                table: "Player");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MatchPlayer",
                table: "MatchPlayer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MatchEvent",
                table: "MatchEvent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Match",
                table: "Match");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EventType",
                table: "EventType");

            migrationBuilder.RenameTable(
                name: "Team",
                newName: "Teams");

            migrationBuilder.RenameTable(
                name: "Position",
                newName: "Positions");

            migrationBuilder.RenameTable(
                name: "Player",
                newName: "Players");

            migrationBuilder.RenameTable(
                name: "MatchPlayer",
                newName: "MatchPlayers");

            migrationBuilder.RenameTable(
                name: "MatchEvent",
                newName: "MatchEvents");

            migrationBuilder.RenameTable(
                name: "Match",
                newName: "Matchs");

            migrationBuilder.RenameTable(
                name: "EventType",
                newName: "EventTypes");

            migrationBuilder.RenameIndex(
                name: "IX_Team_LeagueId",
                table: "Teams",
                newName: "IX_Teams_LeagueId");

            migrationBuilder.RenameIndex(
                name: "IX_Player_TeamId",
                table: "Players",
                newName: "IX_Players_TeamId");

            migrationBuilder.RenameIndex(
                name: "IX_MatchPlayer_PositionId",
                table: "MatchPlayers",
                newName: "IX_MatchPlayers_PositionId");

            migrationBuilder.RenameIndex(
                name: "IX_MatchPlayer_PlayerId",
                table: "MatchPlayers",
                newName: "IX_MatchPlayers_PlayerId");

            migrationBuilder.RenameIndex(
                name: "IX_MatchPlayer_MatchId",
                table: "MatchPlayers",
                newName: "IX_MatchPlayers_MatchId");

            migrationBuilder.RenameIndex(
                name: "IX_MatchEvent_MatchPlayerId",
                table: "MatchEvents",
                newName: "IX_MatchEvents_MatchPlayerId");

            migrationBuilder.RenameIndex(
                name: "IX_MatchEvent_MatchId",
                table: "MatchEvents",
                newName: "IX_MatchEvents_MatchId");

            migrationBuilder.RenameIndex(
                name: "IX_MatchEvent_EventTypeId",
                table: "MatchEvents",
                newName: "IX_MatchEvents_EventTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Match_HomeTeamId",
                table: "Matchs",
                newName: "IX_Matchs_HomeTeamId");

            migrationBuilder.RenameIndex(
                name: "IX_Match_AwayTeamId",
                table: "Matchs",
                newName: "IX_Matchs_AwayTeamId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teams",
                table: "Teams",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Positions",
                table: "Positions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Players",
                table: "Players",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MatchPlayers",
                table: "MatchPlayers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MatchEvents",
                table: "MatchEvents",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Matchs",
                table: "Matchs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventTypes",
                table: "EventTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Matchs_MatchId",
                table: "Articles",
                column: "MatchId",
                principalTable: "Matchs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MatchEvents_EventTypes_EventTypeId",
                table: "MatchEvents",
                column: "EventTypeId",
                principalTable: "EventTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchEvents_MatchPlayers_MatchPlayerId",
                table: "MatchEvents",
                column: "MatchPlayerId",
                principalTable: "MatchPlayers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MatchEvents_Matchs_MatchId",
                table: "MatchEvents",
                column: "MatchId",
                principalTable: "Matchs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchPlayers_Matchs_MatchId",
                table: "MatchPlayers",
                column: "MatchId",
                principalTable: "Matchs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchPlayers_Players_PlayerId",
                table: "MatchPlayers",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchPlayers_Positions_PositionId",
                table: "MatchPlayers",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Matchs_Teams_AwayTeamId",
                table: "Matchs",
                column: "AwayTeamId",
                principalTable: "Teams",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Matchs_Teams_HomeTeamId",
                table: "Matchs",
                column: "HomeTeamId",
                principalTable: "Teams",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerPosition_Players_PlayersId",
                table: "PlayerPosition",
                column: "PlayersId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerPosition_Positions_PositionsId",
                table: "PlayerPosition",
                column: "PositionsId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Teams_TeamId",
                table: "Players",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Leagues_LeagueId",
                table: "Teams",
                column: "LeagueId",
                principalTable: "Leagues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Matchs_MatchId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchEvents_EventTypes_EventTypeId",
                table: "MatchEvents");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchEvents_MatchPlayers_MatchPlayerId",
                table: "MatchEvents");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchEvents_Matchs_MatchId",
                table: "MatchEvents");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchPlayers_Matchs_MatchId",
                table: "MatchPlayers");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchPlayers_Players_PlayerId",
                table: "MatchPlayers");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchPlayers_Positions_PositionId",
                table: "MatchPlayers");

            migrationBuilder.DropForeignKey(
                name: "FK_Matchs_Teams_AwayTeamId",
                table: "Matchs");

            migrationBuilder.DropForeignKey(
                name: "FK_Matchs_Teams_HomeTeamId",
                table: "Matchs");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerPosition_Players_PlayersId",
                table: "PlayerPosition");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerPosition_Positions_PositionsId",
                table: "PlayerPosition");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Teams_TeamId",
                table: "Players");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Leagues_LeagueId",
                table: "Teams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teams",
                table: "Teams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Positions",
                table: "Positions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Players",
                table: "Players");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Matchs",
                table: "Matchs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MatchPlayers",
                table: "MatchPlayers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MatchEvents",
                table: "MatchEvents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EventTypes",
                table: "EventTypes");

            migrationBuilder.RenameTable(
                name: "Teams",
                newName: "Team");

            migrationBuilder.RenameTable(
                name: "Positions",
                newName: "Position");

            migrationBuilder.RenameTable(
                name: "Players",
                newName: "Player");

            migrationBuilder.RenameTable(
                name: "Matchs",
                newName: "Match");

            migrationBuilder.RenameTable(
                name: "MatchPlayers",
                newName: "MatchPlayer");

            migrationBuilder.RenameTable(
                name: "MatchEvents",
                newName: "MatchEvent");

            migrationBuilder.RenameTable(
                name: "EventTypes",
                newName: "EventType");

            migrationBuilder.RenameIndex(
                name: "IX_Teams_LeagueId",
                table: "Team",
                newName: "IX_Team_LeagueId");

            migrationBuilder.RenameIndex(
                name: "IX_Players_TeamId",
                table: "Player",
                newName: "IX_Player_TeamId");

            migrationBuilder.RenameIndex(
                name: "IX_Matchs_HomeTeamId",
                table: "Match",
                newName: "IX_Match_HomeTeamId");

            migrationBuilder.RenameIndex(
                name: "IX_Matchs_AwayTeamId",
                table: "Match",
                newName: "IX_Match_AwayTeamId");

            migrationBuilder.RenameIndex(
                name: "IX_MatchPlayers_PositionId",
                table: "MatchPlayer",
                newName: "IX_MatchPlayer_PositionId");

            migrationBuilder.RenameIndex(
                name: "IX_MatchPlayers_PlayerId",
                table: "MatchPlayer",
                newName: "IX_MatchPlayer_PlayerId");

            migrationBuilder.RenameIndex(
                name: "IX_MatchPlayers_MatchId",
                table: "MatchPlayer",
                newName: "IX_MatchPlayer_MatchId");

            migrationBuilder.RenameIndex(
                name: "IX_MatchEvents_MatchPlayerId",
                table: "MatchEvent",
                newName: "IX_MatchEvent_MatchPlayerId");

            migrationBuilder.RenameIndex(
                name: "IX_MatchEvents_MatchId",
                table: "MatchEvent",
                newName: "IX_MatchEvent_MatchId");

            migrationBuilder.RenameIndex(
                name: "IX_MatchEvents_EventTypeId",
                table: "MatchEvent",
                newName: "IX_MatchEvent_EventTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Team",
                table: "Team",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Position",
                table: "Position",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Player",
                table: "Player",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Match",
                table: "Match",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MatchPlayer",
                table: "MatchPlayer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MatchEvent",
                table: "MatchEvent",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventType",
                table: "EventType",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Match_MatchId",
                table: "Articles",
                column: "MatchId",
                principalTable: "Match",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Match_Team_AwayTeamId",
                table: "Match",
                column: "AwayTeamId",
                principalTable: "Team",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Match_Team_HomeTeamId",
                table: "Match",
                column: "HomeTeamId",
                principalTable: "Team",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MatchEvent_EventType_EventTypeId",
                table: "MatchEvent",
                column: "EventTypeId",
                principalTable: "EventType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchEvent_Match_MatchId",
                table: "MatchEvent",
                column: "MatchId",
                principalTable: "Match",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchEvent_MatchPlayer_MatchPlayerId",
                table: "MatchEvent",
                column: "MatchPlayerId",
                principalTable: "MatchPlayer",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MatchPlayer_Match_MatchId",
                table: "MatchPlayer",
                column: "MatchId",
                principalTable: "Match",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchPlayer_Player_PlayerId",
                table: "MatchPlayer",
                column: "PlayerId",
                principalTable: "Player",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchPlayer_Position_PositionId",
                table: "MatchPlayer",
                column: "PositionId",
                principalTable: "Position",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Team_TeamId",
                table: "Player",
                column: "TeamId",
                principalTable: "Team",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerPosition_Player_PlayersId",
                table: "PlayerPosition",
                column: "PlayersId",
                principalTable: "Player",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerPosition_Position_PositionsId",
                table: "PlayerPosition",
                column: "PositionsId",
                principalTable: "Position",
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
    }
}
