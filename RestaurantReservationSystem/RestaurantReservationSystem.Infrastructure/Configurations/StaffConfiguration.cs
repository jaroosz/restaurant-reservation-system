using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantReservationSystem.Domain.Entities;

namespace RestaurantReservationSystem.Infrastructure.Configurations;

public class StaffConfiguration : IEntityTypeConfiguration<Staff>
{
    public void Configure(EntityTypeBuilder<Staff> builder)
    {
        builder.HasKey(a => a.Id);

        builder.Property(a => a.Login)
            .IsRequired()
            .HasMaxLength(50);

        builder.HasIndex(a => a.Login)
            .IsUnique();

        builder.Property(a => a.PasswordHash)
            .IsRequired();

        builder.HasOne(s => s.Restaurant)
            .WithMany(r => r.Staff)
            .HasForeignKey(s => s.RestaurantId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(a => a.RefreshTokens)
            .WithOne(rt => rt.Staff)
            .HasForeignKey(rt => rt.StaffId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(a => a.StaffPermissions)
            .WithOne(rt => rt.Staff)
            .HasForeignKey(rt => rt.StaffId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Property(n => n.DisplayName)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(t => t.RoleTitle)
            .IsRequired()
            .HasMaxLength(50);
    }

}
