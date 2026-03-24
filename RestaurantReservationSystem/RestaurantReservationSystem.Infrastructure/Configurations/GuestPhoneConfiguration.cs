using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantReservationSystem.Domain.Entities;

namespace RestaurantReservationSystem.Infrastructure.Configurations;

public class GuestPhoneConfiguration : IEntityTypeConfiguration<GuestPhone>
{
    public void Configure(EntityTypeBuilder<GuestPhone> builder)
    {
        builder.HasKey(p => p.Id);

        builder.HasOne(p => p.Guest)
            .WithMany(g => g.Phones)
            .HasForeignKey(p => p.GuestId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Property(p => p.Phone)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(p => p.IsPrimary)
            .IsRequired();

        builder.HasIndex(p => new { p.GuestId, p.Phone });
    }
}
