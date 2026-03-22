using Microsoft.EntityFrameworkCore;
using RestaurantReservationSystem.Domain.Entities;

namespace RestaurantReservationSystem.Infrastructure.Data;

public interface IApplicationDbContext
{
    DbSet<Admin> Admins { get; }
    DbSet<Guest> Guests { get; }
    DbSet<GuestEmail> GuestEmails { get; }
    DbSet<GuestPhone> GuestPhones { get; }
    DbSet<Permission> Permissions { get; }
    DbSet<RefreshToken> RefreshTokens { get; }
    DbSet<Reservation> Reservations { get; }
    DbSet<Restaurant> Restaurants { get; }
    DbSet<RestaurantHours> RestaurantsHours { get; }
    DbSet<RestaurantTable> RestaurantTables { get; }
    DbSet<Staff> Staff { get; }
    DbSet<StaffPermission> StaffPermissions { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
