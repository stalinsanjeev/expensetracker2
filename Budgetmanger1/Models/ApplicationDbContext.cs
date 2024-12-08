using Microsoft.EntityFrameworkCore;

namespace Budgetmanger1.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext( DbContextOptions options):base(options)
    {
        
    }
    
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<Category> Categories { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Category>()
            .HasKey(c => c.MyProperty);

        modelBuilder.Entity<Transaction>()
            .HasOne(t => t.Category)
            .WithMany()
            .HasForeignKey(t => t.MyProperty)
            .HasPrincipalKey(c => c.MyProperty);
    }
    
    
}