using AgriAI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgriAI.Infrastructure.Persistence.Configurations;

public class DiseaseComparisonConfiguration : IEntityTypeConfiguration<DiseaseComparison>
{
    public void Configure(EntityTypeBuilder<DiseaseComparison> builder)
    {
        builder.ToTable("DiseaseComparisons");
        builder.HasKey(c => c.Id);

        builder.HasIndex(c => new { c.DiseaseId, c.SimilarDiseaseId }).IsUnique();

        builder.HasOne(c => c.Disease)
            .WithMany()
            .HasForeignKey(c => c.DiseaseId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(c => c.SimilarDisease)
            .WithMany()
            .HasForeignKey(c => c.SimilarDiseaseId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}