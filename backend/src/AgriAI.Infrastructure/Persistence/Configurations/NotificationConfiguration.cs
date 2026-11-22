using AgriAI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AgriAI.Infrastructure.Persistence.Configurations;

public class NotificationConfiguration : IEntityTypeConfiguration<Notification>
{
    public void Configure(EntityTypeBuilder<Notification> builder)
    {
        builder.ToTable("Notifications");
        builder.HasKey(n => n.Id);

        builder.Property(n => n.Type).IsRequired().HasMaxLength(30);
        builder.Property(n => n.TitleAr).IsRequired().HasMaxLength(200);
        builder.Property(n => n.TitleEn).IsRequired().HasMaxLength(200);
        builder.Property(n => n.BodyAr).IsRequired();
        builder.Property(n => n.BodyEn).IsRequired();
        builder.Property(n => n.IsRead).HasDefaultValue(false);

        builder.HasIndex(n => new { n.UserId, n.IsRead });

        builder.HasOne(n => n.User)
            .WithMany(u => u.Notifications)
            .HasForeignKey(n => n.UserId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}