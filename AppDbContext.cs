// Data/AppDbContext.cs
using Microsoft.EntityFrameworkCore;
using OrderAPI.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Order> Orders { get; set; }

    // Add other DbSet properties for your entities

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure your entity relationships and constraints here
    }
}
