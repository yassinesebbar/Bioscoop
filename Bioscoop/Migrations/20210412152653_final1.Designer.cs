﻿// <auto-generated />
using System;
using Bioscoop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bioscoop.Migrations
{
    [DbContext(typeof(BioscoopContext))]
    [Migration("20210412152653_final1")]
    partial class final1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("Bioscoop.Models.Chair", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ChairNr")
                        .HasColumnType("TEXT");

                    b.Property<int?>("FKIDEventAvailable")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FKIDEventReserverd")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FKIDHall")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FKIDReservation")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("FKIDEventAvailable");

                    b.HasIndex("FKIDEventReserverd");

                    b.HasIndex("FKIDHall");

                    b.ToTable("Chairs");
                });

            modelBuilder.Entity("Bioscoop.Models.Event", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("BasePrijs")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("End")
                        .HasColumnType("TEXT");

                    b.Property<int?>("HallID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IDhall")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IDmovie")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MovieID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Start")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("HallID");

                    b.HasIndex("MovieID");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("Bioscoop.Models.FinanceTransaction", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateTimeTransaction")
                        .HasColumnType("TEXT");

                    b.Property<int?>("DiscountID")
                        .HasColumnType("INTEGER");

                    b.Property<double>("ExtraTarif")
                        .HasColumnType("REAL");

                    b.Property<int>("IDdiscount")
                        .HasColumnType("INTEGER");

                    b.Property<double>("basePrice")
                        .HasColumnType("REAL");

                    b.Property<string>("descriptionExtraTarif")
                        .HasColumnType("TEXT");

                    b.Property<double>("discount")
                        .HasColumnType("REAL");

                    b.Property<bool>("paymentIsComplete")
                        .HasColumnType("INTEGER");

                    b.Property<double>("totalPrice")
                        .HasColumnType("REAL");

                    b.HasKey("ID");

                    b.HasIndex("DiscountID");

                    b.ToTable("FinanceTransactions");
                });

            modelBuilder.Entity("Bioscoop.Models.Hall", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("NumSeats")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Rows")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SeatsPerRow")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Halls");
                });

            modelBuilder.Entity("Bioscoop.Models.LostItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateFound")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateLost")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmployeeFound")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmployeeRelease")
                        .HasColumnType("TEXT");

                    b.Property<string>("Image")
                        .HasColumnType("TEXT");

                    b.Property<bool>("ItemFound")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LocationFound")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("LostItems");
                });

            modelBuilder.Entity("Bioscoop.Models.Movie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cast")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int>("DurationMin")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Genre")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageCover")
                        .HasColumnType("TEXT");

                    b.Property<string>("RatingGuide")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("ThreeD")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<string>("director")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("Bioscoop.Models.Payment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Amount")
                        .HasColumnType("REAL");

                    b.Property<string>("Banknr")
                        .HasColumnType("TEXT");

                    b.Property<string>("CouponCode")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Refunded")
                        .HasColumnType("INTEGER");

                    b.Property<int>("paymentMethod")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("reservationID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("reservationID");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Bioscoop.Models.Reservation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<int?>("EventID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FKIDReservation")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FinanceTransactionID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IDdiscount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IDevent")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IDtransaction")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReservationDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("geanuleerd")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("haveBeenPrinted")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("printTicket")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.HasIndex("EventID");

                    b.HasIndex("FKIDReservation");

                    b.HasIndex("FinanceTransactionID");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("Bioscoop.Models.TicketDiscount", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("description")
                        .HasColumnType("TEXT");

                    b.Property<double>("discountAmount")
                        .HasColumnType("REAL");

                    b.HasKey("ID");

                    b.ToTable("TicketDiscounts");
                });

            modelBuilder.Entity("Bioscoop.Models.WLConfigSingleton", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("WhiteListing")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("WLConfigSingleton");
                });

            modelBuilder.Entity("Bioscoop.Models.WhiteListingIP", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("IPaddress")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("WhiteListingIP");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Bioscoop.Models.Chair", b =>
                {
                    b.HasOne("Bioscoop.Models.Event", null)
                        .WithMany("AvailableSeats")
                        .HasForeignKey("FKIDEventAvailable");

                    b.HasOne("Bioscoop.Models.Event", null)
                        .WithMany("ReservedSeats")
                        .HasForeignKey("FKIDEventReserverd");

                    b.HasOne("Bioscoop.Models.Hall", null)
                        .WithMany("Seats")
                        .HasForeignKey("FKIDHall");
                });

            modelBuilder.Entity("Bioscoop.Models.Event", b =>
                {
                    b.HasOne("Bioscoop.Models.Hall", "Hall")
                        .WithMany()
                        .HasForeignKey("HallID");

                    b.HasOne("Bioscoop.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieID");

                    b.Navigation("Hall");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("Bioscoop.Models.FinanceTransaction", b =>
                {
                    b.HasOne("Bioscoop.Models.TicketDiscount", "Discount")
                        .WithMany()
                        .HasForeignKey("DiscountID");

                    b.Navigation("Discount");
                });

            modelBuilder.Entity("Bioscoop.Models.Payment", b =>
                {
                    b.HasOne("Bioscoop.Models.Reservation", "reservation")
                        .WithMany()
                        .HasForeignKey("reservationID");

                    b.Navigation("reservation");
                });

            modelBuilder.Entity("Bioscoop.Models.Reservation", b =>
                {
                    b.HasOne("Bioscoop.Models.Event", "Event")
                        .WithMany()
                        .HasForeignKey("EventID");

                    b.HasOne("Bioscoop.Models.Chair", "StoelNr")
                        .WithMany()
                        .HasForeignKey("FKIDReservation");

                    b.HasOne("Bioscoop.Models.FinanceTransaction", "FinanceTransaction")
                        .WithMany()
                        .HasForeignKey("FinanceTransactionID");

                    b.Navigation("Event");

                    b.Navigation("FinanceTransaction");

                    b.Navigation("StoelNr");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Bioscoop.Models.Event", b =>
                {
                    b.Navigation("AvailableSeats");

                    b.Navigation("ReservedSeats");
                });

            modelBuilder.Entity("Bioscoop.Models.Hall", b =>
                {
                    b.Navigation("Seats");
                });
#pragma warning restore 612, 618
        }
    }
}