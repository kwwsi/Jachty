using Jachty.Data.Configurations;
using Jachty.Models;
using Microsoft.EntityFrameworkCore;
namespace Jachty.Data
{
    public class JachtyContext : DbContext
    {
        public DbSet<Jacht> Jachts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source=Wypozyczalnia.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration()).Seed();
        }
    }
}
