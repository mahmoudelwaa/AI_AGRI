using AgriAI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgriAI.Infrastructure.Persistence.Configurations;

public class DiseaseRecommendationConfiguration : IEntityTypeConfiguration<DiseaseRecommendation>
{
    public void Configure(EntityTypeBuilder<DiseaseRecommendation> builder)
    {
        builder.ToTable("DiseaseRecommendations");
        builder.HasKey(r => r.Id);

        builder.Property(r => r.TitleAr).IsRequired().HasMaxLength(150);
        builder.Property(r => r.TitleEn).IsRequired().HasMaxLength(150);
        builder.Property(r => r.BodyAr).IsRequired();
        builder.Property(r => r.BodyEn).IsRequired();

        builder.HasIndex(r => new { r.DiseaseId, r.SortOrder }).IsUnique();

        builder.HasOne(r => r.Disease)
            .WithMany()
            .HasForeignKey(r => r.DiseaseId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}