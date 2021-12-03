using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectCinema.App.Migrations
{
    public partial class ScreeningTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ScreeningTime",
                columns: table => new
                {
                    ScreeningTimeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScreeningTime", x => x.ScreeningTimeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScreeningTime");
        }
    }
}
