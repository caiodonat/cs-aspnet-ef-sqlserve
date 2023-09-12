using Ddd.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ddd.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // => optionsBuilder.UseSqlite("DataSource=../Ddd.Infrastructure/app.db;Cache=Shared");
        => optionsBuilder.UseSqlite("DataSource=../Ddd.Infrastructure/app.db;Cache=Shared");
        // server=localhost;port=3306;database=industrialpassport;user=admin;password=123456
        // base.OnConfiguring(optionsBuilder);
    }
}