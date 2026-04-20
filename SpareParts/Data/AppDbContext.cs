using Microsoft.EntityFrameworkCore;
using SpareParts.Models;

namespace SpareParts.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<备件动态> 备件动态 { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<备件动态>().ToTable("备件动态");
        base.OnModelCreating(modelBuilder);
    }
}
