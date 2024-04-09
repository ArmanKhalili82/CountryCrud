using CountryCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace CountryCrud.Data
{
    public class CountryDbContext : DbContext
    {
        public CountryDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<FullInfo> Infos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FullInfo>().HasData(
                new FullInfo { Id = 1, Country = "Usa", City = "Washington", IsCapital = true, Population = 10000000},
                new FullInfo { Id = 2, Country = "Usa", City = "New York", IsCapital = false, Population = 20000000},
                new FullInfo { Id = 3, Country = "Germany", City = "Berlin", IsCapital = true, Population = 7000000}
                );
        }
    }
}
