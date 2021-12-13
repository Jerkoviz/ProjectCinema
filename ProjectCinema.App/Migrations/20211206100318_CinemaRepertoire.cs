using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectCinema.App.Migrations
{
    public partial class CinemaRepertoire : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CinemaRepertoire",
                columns: table => new
                {
                    CinemaRepertoireId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    TimeOfProjection = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CinemaRepertoire", x => x.CinemaRepertoireId);
                    table.ForeignKey(
                        name: "FK_CinemaRepertoire_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CinemaRepertoire_MovieId",
                table: "CinemaRepertoire",
                column: "MovieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CinemaRepertoire");
        }
    }
}
