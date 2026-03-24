using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantReservationSystem.Domain.Entities;

namespace RestaurantReservationSystem.Infrastructure.Configurations;

public class GuestEmailConfiguration : IEntityTypeConfiguration<GuestEmail>
{
    public void Configure(EntityTypeBuilder<GuestEmail> builder)
    {
        builder.HasKey(p => p.Id);

        builder.HasOne(p => p.Guest)
            .WithMany(g => g.Emails)
            .HasForeignKey(p => p.GuestId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Property(p => p.Email)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(p => p.IsPrimary)
            .IsRequired();

        builder.HasIndex(p => new { p.GuestId, p.Email });
    }
}
