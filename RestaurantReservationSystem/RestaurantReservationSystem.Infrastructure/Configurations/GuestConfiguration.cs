using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantReservationSystem.Domain.Entities;

namespace RestaurantReservationSystem.Infrastructure.Configurations;


public class GuestConfiguration : IEntityTypeConfiguration<Guest>
{
    public void Configure(EntityTypeBuilder<Guest> builder)
    {
        builder.HasKey(a => a.Id);

        builder.HasOne(s => s.Restaurant)
            .WithMany(r => r.Guests)
            .HasForeignKey(s => s.RestaurantId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Property(a => a.FirstName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(a => a.LastName)
            .HasMaxLength(100);

        builder.Property(b => b.NeedsMergeReview);

        builder.Property(s => s.Source)
            .IsRequired();

        builder.HasOne(g => g.MergedIntoGuest)
            .WithMany()
            .HasForeignKey(g => g.MergedIntoGuestId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(g => g.Phones)
            .WithOne(p => p.Guest)
            .HasForeignKey(p => p.GuestId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(g => g.Emails)
            .WithOne(p => p.Guest)
            .HasForeignKey(p => p.GuestId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(g => g.Reservations)
            .WithOne(r => r.Guest)
            .HasForeignKey(r => r.GuestId)
            .OnDelete(DeleteBehavior.SetNull);
    }
}
