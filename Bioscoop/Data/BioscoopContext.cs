using System.Transactions;
using Microsoft.EntityFrameworkCore;
using Bioscoop.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Bioscoop.Data
{
    public class BioscoopContext : IdentityDbContext
    {
        public BioscoopContext (DbContextOptions<BioscoopContext> options)
            : base(options)
        {
            
        }
        public DbSet<Movie> Movies{get;set;}
        public DbSet<Hall> Halls{get;set;}
        public DbSet<Event> Events{get;set;}
        public DbSet<TicketDiscount> TicketDiscounts{get;set;}
        public DbSet<FinanceTransaction> FinanceTransactions{get;set;}
        public DbSet<Reservation> Reservations{get;set;}
        public DbSet<Chair> Chairs{get;set;}
        public DbSet<Payment> Payments{get;set;}
        public DbSet<LostItem> LostItems{get;set;}
        public DbSet<WLConfigSingleton> WLConfigSingleton{get;set;}
        public DbSet<WhiteListingIP> WhiteListingIP{get;set;}

    }
}