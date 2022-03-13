using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AS_lab1_gr1.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MatchId",
                table: "Articles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Match",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Stadium = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Match", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_MatchId",
                table: "Articles",
                column: "MatchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Match_MatchId",
                table: "Articles",
                column: "MatchId",
                principalTable: "Match",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Match_MatchId",
                table: "Articles");

            migrationBuilder.DropTable(
                name: "Match");

            migrationBuilder.DropIndex(
                name: "IX_Articles_MatchId",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "MatchId",
                table: "Articles");
        }
    }
}
