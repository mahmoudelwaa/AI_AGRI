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

    public DbSet<User> Users { get; set; } = null!;

    public DbSet<Diagnosis> Diagnoses { get; set; } = null!;

    public DbSet<UserCrop> UserCrops { get; set; } = null!;
    
    public DbSet<Farm> Farms { get; set; } = null!;

    public DbSet<Field> Fields { get; set; } = null!;
    
    public DbSet<DiagnosisPrediction> DiagnosisPredictions { get; set; } = null!;
    
    public DbSet<DiseaseComparison> DiseaseComparisons { get; set; } = null!;

    public DbSet<DiseaseComparisonRow> DiseaseComparisonRows { get; set; } = null!;
    
    public DbSet<DiseaseRecommendation> DiseaseRecommendations { get; set; } = null!;
    
    public DbSet<Notification> Notifications { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(
            typeof(AppDbContext).Assembly
        );

        modelBuilder.Entity<Crop>().HasData(CropSeed.Data);
        modelBuilder.Entity<Disease>().HasData(DiseaseSeed.Data);
        modelBuilder.Entity<DiseaseRecommendation>().HasData(DiseaseRecommendationSeed.Data);
        modelBuilder.Entity<DiseaseComparison>().HasData(DiseaseComparisonSeed.Comparisons);
        modelBuilder.Entity<DiseaseComparisonRow>().HasData(DiseaseComparisonSeed.Rows);
        
    }
}