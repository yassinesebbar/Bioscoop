using Microsoft.EntityFrameworkCore.Migrations;

namespace Bioscoop.Migrations
{
    public partial class migration8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "haveBeenPrinted",
                table: "Reservations",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "printTicket",
                table: "Reservations",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "haveBeenPrinted",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "printTicket",
                table: "Reservations");
        }
    }
}
