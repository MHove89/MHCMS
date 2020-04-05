using Microsoft.EntityFrameworkCore;
namespace MHCMS.Infrastructure.Persistence.EntityFramework
{
    public abstract class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}