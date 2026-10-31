using AgriAI.Domain.Entities;
using AgriAI.Infrastructure.Persistence.Seed;
using Microsoft.EntityFrameworkCore;

namespace AgriAI.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Crop> Crops { get; set; } = null!;

    public DbSet<Disease> Diseases { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(
            typeof(AppDbContext).Assembly
        );

        modelBuilder.Entity<Crop>().HasData(CropSeed.Data);

        modelBuilder.Entity<Disease>().HasData(DiseaseSeed.Data);
    }
}