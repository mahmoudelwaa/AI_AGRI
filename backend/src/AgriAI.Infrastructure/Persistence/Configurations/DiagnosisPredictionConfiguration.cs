using AgriAI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgriAI.Infrastructure.Persistence.Configurations;

public class DiagnosisPredictionConfiguration : IEntityTypeConfiguration<DiagnosisPrediction>
{
    public void Configure(EntityTypeBuilder<DiagnosisPrediction> builder)
    {
        builder.ToTable("DiagnosisPredictions");
        builder.HasKey(p => p.Id);

        builder.HasIndex(p => new { p.DiagnosisId, p.Rank }).IsUnique();

        builder.HasOne(p => p.Diagnosis)
            .WithMany(d => d.Predictions)
            .HasForeignKey(p => p.DiagnosisId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(p => p.Disease)
            .WithMany()
            .HasForeignKey(p => p.DiseaseId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}