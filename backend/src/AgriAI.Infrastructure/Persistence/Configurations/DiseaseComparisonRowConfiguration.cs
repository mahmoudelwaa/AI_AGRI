using AgriAI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgriAI.Infrastructure.Persistence.Configurations;

public class DiseaseComparisonRowConfiguration : IEntityTypeConfiguration<DiseaseComparisonRow>
{
    public void Configure(EntityTypeBuilder<DiseaseComparisonRow> builder)
    {
        builder.ToTable("DiseaseComparisonRows");
        builder.HasKey(r => r.Id);

        builder.Property(r => r.FeatureAr).IsRequired().HasMaxLength(150);
        builder.Property(r => r.FeatureEn).IsRequired().HasMaxLength(150);

        builder.HasOne(r => r.Comparison)
            .WithMany(c => c.Rows)
            .HasForeignKey(r => r.ComparisonId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}