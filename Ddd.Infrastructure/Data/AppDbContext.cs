using Ddd.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ddd.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("DataSource=app.db;Cache=Shared");
        // base.OnConfiguring(optionsBuilder);
    }
}