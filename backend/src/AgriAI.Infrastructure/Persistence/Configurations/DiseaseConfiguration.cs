using AgriAI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgriAI.Infrastructure.Persistence.Configurations;

public class DiseaseConfiguration : IEntityTypeConfiguration<Disease>
{
    public void Configure(EntityTypeBuilder<Disease> builder)
    {
        builder.ToTable("Diseases");

        builder.HasKey(d => d.Id);
        builder.Property(d => d.Id)
            .ValueGeneratedNever();

        builder.Property(d => d.NameAr)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(d => d.NameEn)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(d => d.IsHealthy)
            .IsRequired();

        builder.Property(d => d.ScientificName)
            .HasMaxLength(150);

        builder.Property(d => d.PathogenType)
            .HasConversion<string>()
            .HasMaxLength(20);

        builder.Property(d => d.Severity)
            .HasConversion<string>()
            .HasMaxLength(20);

        builder.Property(d => d.SpreadRate)
            .HasConversion<string>()
            .HasMaxLength(20);

        builder.Property(d => d.ImageUrl)
            .HasMaxLength(500);

        builder.HasOne(d => d.Crop)
            .WithMany(c => c.Diseases)
            .HasForeignKey(d => d.CropId)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.Property(d => d.InfectionPatternAr).HasMaxLength(300);
        builder.Property(d => d.InfectionPatternEn).HasMaxLength(300);
    }
}