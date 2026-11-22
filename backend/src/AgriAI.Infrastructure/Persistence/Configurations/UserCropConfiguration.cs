using AgriAI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgriAI.Infrastructure.Persistence.Configurations;

public class UserCropConfiguration : IEntityTypeConfiguration<UserCrop>
{
    public void Configure(EntityTypeBuilder<UserCrop> builder)
    {
        builder.ToTable("UserCrops");

        builder.HasKey(uc => new { uc.UserId, uc.CropId });

        builder.HasOne(uc => uc.User)
            .WithMany(u => u.UserCrops)
            .HasForeignKey(uc => uc.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(uc => uc.Crop)
            .WithMany(c => c.UserCrops)
            .HasForeignKey(uc => uc.CropId)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.Property(uc => uc.Variety).HasMaxLength(100);
    }
}