using eCommerce.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Data
{
    /// <summary>
    /// Database context for the eCommerce application
    /// Extends IdentityDbContext to include Identity tables for login/register
    /// </summary>
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        // Constructor that passes options to the base DbContext class (Dependency Injection)
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Represents the Products table in the database
        public DbSet<Product> Products { get; set; }
    }
}