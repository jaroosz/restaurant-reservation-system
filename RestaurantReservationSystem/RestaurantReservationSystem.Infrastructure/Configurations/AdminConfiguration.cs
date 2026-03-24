using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantReservationSystem.Domain.Entities;

namespace RestaurantReservationSystem.Infrastructure.Configurations;

public class AdminConfiguration : IEntityTypeConfiguration<Admin>
{
    public void Configure(EntityTypeBuilder<Admin> builder)
    {
        builder.HasKey(a => a.Id);

        builder.Property(a => a.Login)
            .IsRequired()
            .HasMaxLength(50);

        builder.HasIndex(a => a.Login)
            .IsUnique();

        builder.Property(a => a.Email)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(a => a.PasswordHash)
            .IsRequired();

        builder.HasOne(a => a.Restaurant)
            .WithOne(r => r.Admin)
            .HasForeignKey<Restaurant>(r => r.AdminId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(a => a.RefreshTokens)
            .WithOne(rt => rt.Admin)
            .HasForeignKey(rt => rt.AdminId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}

