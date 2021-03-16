using System.Transactions;
using Microsoft.EntityFrameworkCore;
using Bioscoop.Models;

namespace Bioscoop.Data
{
    public class BioscoopContext : DbContext
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

    }
}