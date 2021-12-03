using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectCinema.App.Migrations
{
    public partial class CurrentlyIn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CurrentlyInCinema",
                columns: table => new
                {
                    CurrentlyInCinemaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    ScreeningTimeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentlyInCinema", x => x.CurrentlyInCinemaId);
                    table.ForeignKey(
                        name: "FK_CurrentlyInCinema_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurrentlyInCinema_ScreeningTime_ScreeningTimeId",
                        column: x => x.ScreeningTimeId,
                        principalTable: "ScreeningTime",
                        principalColumn: "ScreeningTimeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CurrentlyInCinema_MovieId",
                table: "CurrentlyInCinema",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentlyInCinema_ScreeningTimeId",
                table: "CurrentlyInCinema",
                column: "ScreeningTimeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CurrentlyInCinema");
        }
    }
}
