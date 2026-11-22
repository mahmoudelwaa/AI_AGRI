using AgriAI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgriAI.Infrastructure.Persistence.Configurations;

public class DiagnosisConfiguration : IEntityTypeConfiguration<Diagnosis>
{
    public void Configure(EntityTypeBuilder<Diagnosis> builder)
    {
        builder.ToTable("Diagnoses");
        builder.HasKey(d => d.Id);
        builder.Property(d => d.ImagePath).IsRequired().HasMaxLength(500);
        builder.Property(d => d.ModelVersion).HasMaxLength(50);
        builder.HasOne(d => d.User)
            .WithMany(u => u.Diagnoses)
            .HasForeignKey(d => d.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(d => d.Crop)
            .WithMany()
            .HasForeignKey(d => d.CropId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(d => d.Disease)
            .WithMany()
            .HasForeignKey(d => d.DiseaseId)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasOne(d => d.Field)
            .WithMany(f => f.Diagnoses)
            .HasForeignKey(d => d.FieldId)
            .OnDelete(DeleteBehavior.SetNull);
        
        builder.Property(d => d.ImageFileName).HasMaxLength(255);
    }
}