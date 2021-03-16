using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bioscoop.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Halls",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Rows = table.Column<int>(type: "INTEGER", nullable: false),
                    SeatsPerRow = table.Column<int>(type: "INTEGER", nullable: false),
                    NumSeats = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Halls", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ReleaseDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ImageCover = table.Column<string>(type: "TEXT", nullable: true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Genre = table.Column<string>(type: "TEXT", nullable: true),
                    RatingGuide = table.Column<string>(type: "TEXT", nullable: true),
                    director = table.Column<string>(type: "TEXT", nullable: true),
                    Cast = table.Column<string>(type: "TEXT", nullable: true),
                    DurationMin = table.Column<int>(type: "INTEGER", nullable: false),
                    ThreeD = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TicketDiscounts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    description = table.Column<string>(type: "TEXT", nullable: true),
                    discountAmount = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketDiscounts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IDhall = table.Column<int>(type: "INTEGER", nullable: false),
                    HallID = table.Column<int>(type: "INTEGER", nullable: true),
                    Start = table.Column<DateTime>(type: "TEXT", nullable: false),
                    End = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IDmovie = table.Column<int>(type: "INTEGER", nullable: false),
                    MovieID = table.Column<int>(type: "INTEGER", nullable: true),
                    BasePrijs = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Events_Halls_HallID",
                        column: x => x.HallID,
                        principalTable: "Halls",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Events_Movies_MovieID",
                        column: x => x.MovieID,
                        principalTable: "Movies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FinanceTransactions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    basePrice = table.Column<double>(type: "REAL", nullable: false),
                    ExtraTarif = table.Column<double>(type: "REAL", nullable: false),
                    descriptionExtraTarif = table.Column<string>(type: "TEXT", nullable: true),
                    discount = table.Column<double>(type: "REAL", nullable: false),
                    DiscountID = table.Column<int>(type: "INTEGER", nullable: true),
                    totalPrice = table.Column<double>(type: "REAL", nullable: false),
                    DateTimeTransaction = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IDdiscount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinanceTransactions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FinanceTransactions_TicketDiscounts_DiscountID",
                        column: x => x.DiscountID,
                        principalTable: "TicketDiscounts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Chairs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FKIDHall = table.Column<int>(type: "INTEGER", nullable: true),
                    FKIDEventReserverd = table.Column<int>(type: "INTEGER", nullable: true),
                    FKIDEventAvailable = table.Column<int>(type: "INTEGER", nullable: true),
                    FKIDReservation = table.Column<int>(type: "INTEGER", nullable: true),
                    ChairNr = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chairs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Chairs_Events_FKIDEventAvailable",
                        column: x => x.FKIDEventAvailable,
                        principalTable: "Events",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Chairs_Events_FKIDEventReserverd",
                        column: x => x.FKIDEventReserverd,
                        principalTable: "Events",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Chairs_Halls_FKIDHall",
                        column: x => x.FKIDHall,
                        principalTable: "Halls",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FinanceTransactionID = table.Column<int>(type: "INTEGER", nullable: true),
                    EventID = table.Column<int>(type: "INTEGER", nullable: true),
                    FKIDReservation = table.Column<int>(type: "INTEGER", nullable: true),
                    geanuleerd = table.Column<bool>(type: "INTEGER", nullable: false),
                    ReservationDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IDtransaction = table.Column<int>(type: "INTEGER", nullable: false),
                    IDevent = table.Column<int>(type: "INTEGER", nullable: false),
                    IDdiscount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Reservations_Chairs_FKIDReservation",
                        column: x => x.FKIDReservation,
                        principalTable: "Chairs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservations_Events_EventID",
                        column: x => x.EventID,
                        principalTable: "Events",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reservations_FinanceTransactions_FinanceTransactionID",
                        column: x => x.FinanceTransactionID,
                        principalTable: "FinanceTransactions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chairs_FKIDEventAvailable",
                table: "Chairs",
                column: "FKIDEventAvailable");

            migrationBuilder.CreateIndex(
                name: "IX_Chairs_FKIDEventReserverd",
                table: "Chairs",
                column: "FKIDEventReserverd");

            migrationBuilder.CreateIndex(
                name: "IX_Chairs_FKIDHall",
                table: "Chairs",
                column: "FKIDHall");

            migrationBuilder.CreateIndex(
                name: "IX_Events_HallID",
                table: "Events",
                column: "HallID");

            migrationBuilder.CreateIndex(
                name: "IX_Events_MovieID",
                table: "Events",
                column: "MovieID");

            migrationBuilder.CreateIndex(
                name: "IX_FinanceTransactions_DiscountID",
                table: "FinanceTransactions",
                column: "DiscountID");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_EventID",
                table: "Reservations",
                column: "EventID");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_FinanceTransactionID",
                table: "Reservations",
                column: "FinanceTransactionID");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_FKIDReservation",
                table: "Reservations",
                column: "FKIDReservation");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.DropTable(
                name: "Chairs");

            migrationBuilder.DropTable(
                name: "FinanceTransactions");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "TicketDiscounts");

            migrationBuilder.DropTable(
                name: "Halls");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
