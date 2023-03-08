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
    }
}
