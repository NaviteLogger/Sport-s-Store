using Microsoft.EntityFrameworkCore;

namespace SportsStore.Models
{
    public class StoreDbContext : DbContext //DBContext is a class in the Entity Framework Core namespace, provides the basic functionality for connecting to a database and mapping objects to database tables
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options) { } //provides the connection string to the database
        public DbSet<Products> Products { get; set; } //provides the access to the Products table in the database
    }
}
