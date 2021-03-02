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

        public DbSet<Movie> Movies{get; set;}
    }
}