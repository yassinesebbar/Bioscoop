using Microsoft.EntityFrameworkCore;

namespace Bioscoop.Data
{
    public class BioscoopContext : DbContext
    {
        public BioscoopContext (
            DbContextOptions<BioscoopContext> options)
            : base(options)
        {
        }

        public DbSet<Bioscoop.Models.Movie> Movie { get; set; }
    }
}