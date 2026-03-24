using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantReservationSystem.Domain.Entities;

namespace RestaurantReservationSystem.Infrastructure.Configurations;

public class StaffPermissionConfiguration : IEntityTypeConfiguration<StaffPermission>
{
    public void Configure(EntityTypeBuilder<StaffPermission> builder)
    {
        builder.HasKey(sp => new { sp.StaffId, sp.PermissionId });

        builder.HasOne(sp => sp.Staff)
            .WithMany(s => s.StaffPermissions)
            .HasForeignKey(sp => sp.StaffId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(sp => sp.Permission)
            .WithMany()
            .HasForeignKey(sp => sp.PermissionId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
