using Microsoft.EntityFrameworkCore;
using SalesManagement.Data.Entities;

namespace SalesManagement.Data.Contexts;
public class MainContext : DbContext
{
    public DbSet<Sale> Sales { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Purchase> Purchases { get; set; }
    
    public MainContext(DbContextOptions<MainContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Sale>()
               .HasMany(x => x.Products)
               .WithOne(x => x.Sale)
               .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<Purchase>()
               .HasMany(x => x.Products)
               .WithOne(x => x.Purchase)
               .OnDelete(DeleteBehavior.Cascade);
    }
}
