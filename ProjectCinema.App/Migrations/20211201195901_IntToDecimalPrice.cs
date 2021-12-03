using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectCinema.App.Migrations
{
    public partial class IntToDecimalPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Ticket",
                type: "money",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Ticket",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");
        }
    }
}
