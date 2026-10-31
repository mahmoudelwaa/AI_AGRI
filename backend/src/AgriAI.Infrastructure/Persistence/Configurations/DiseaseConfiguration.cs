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

        builder.HasOne(d => d.Crop)
            .WithMany(c => c.Diseases)
            .HasForeignKey(d => d.CropId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}