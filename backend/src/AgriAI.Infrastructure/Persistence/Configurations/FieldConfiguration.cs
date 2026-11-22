using AgriAI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgriAI.Infrastructure.Persistence.Configurations;

public class FieldConfiguration : IEntityTypeConfiguration<Field>
{
    public void Configure(EntityTypeBuilder<Field> builder)
    {
        builder.ToTable("Fields");
        builder.HasKey(f => f.Id);
        builder.Property(f => f.Name).IsRequired().HasMaxLength(150);
        builder.Property(f => f.AreaFeddan).HasPrecision(10, 2);

        builder.HasOne(f => f.Farm)
            .WithMany(x => x.Fields)
            .HasForeignKey(f => f.FarmId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(f => f.Crop)
            .WithMany()
            .HasForeignKey(f => f.CropId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}