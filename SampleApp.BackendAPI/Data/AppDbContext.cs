using Microsoft.EntityFrameworkCore;
using SampleApp.BackendAPI.Models;

namespace SampleApp.BackendAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {
        }

        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Battle> Battles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Samurai>().HasData(
                new Samurai { Id = 1, Name = "Kamado Tanjiro" });
            var samuraiList = new Samurai[]
            {
                new Samurai {Id=2,Name="Muzan Kibutsuji"},
                new Samurai {Id=3,Name="Zenitsu"},
                new Samurai {Id=4,Name="Inosuke"}
            };
            modelBuilder.Entity<Samurai>().HasData(samuraiList);

            modelBuilder.Entity<Quote>().HasData(new Quote
            {
                Id = 1,
                Text = "Quote from Tanjiro Kamado",
                SamuraiId=1
            });
        }

    }
}
