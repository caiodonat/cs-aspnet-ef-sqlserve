using Ddd.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ddd.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // => optionsBuilder.UseSqlite("DataSource=../Ddd.Infrastructure/app.db;Cache=Shared");
        => optionsBuilder.UseSqlServer("Server=db;Database=msdb;User=SA;Password=p4ss!#W0rd;TrustServerCertificate=true");
    }
}