using eCommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Data
{
    /// <summary>
    /// Database context for the eCommerce application
    /// </summary>
    public class AppDbContext : DbContext
    {
        // Constructor that passes options to the base DbContext class (Dependency Injection)
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Represents the Products table in the database
        public DbSet<Product> Products { get; set; }
    }
}
