using Microsoft.EntityFrameworkCore.Migrations;

namespace Bioscoop.Migrations
{
    public partial class migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "paymentIsComplete",
                table: "FinanceTransactions",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    paymentMethod = table.Column<int>(type: "INTEGER", nullable: false),
                    Banknr = table.Column<string>(type: "TEXT", nullable: true),
                    Amount = table.Column<int>(type: "INTEGER", nullable: false),
                    CouponCode = table.Column<string>(type: "TEXT", nullable: true),
                    reservationID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Payments_Reservations_reservationID",
                        column: x => x.reservationID,
                        principalTable: "Reservations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Payments_reservationID",
                table: "Payments",
                column: "reservationID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropColumn(
                name: "paymentIsComplete",
                table: "FinanceTransactions");
        }
    }
}
