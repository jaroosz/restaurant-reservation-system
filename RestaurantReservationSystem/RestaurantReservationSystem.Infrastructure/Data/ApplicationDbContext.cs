using Microsoft.EntityFrameworkCore;
using RestaurantReservationSystem.Domain.Entities;
using System.Reflection;

namespace RestaurantReservationSystem.Infrastructure.Data;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    public DbSet<Admin> Admins { get; set; }
    public DbSet<Guest> Guests { get; set; }
    public DbSet<GuestEmail> GuestEmails { get; set; }
    public DbSet<GuestPhone> GuestPhones { get; set; }
    public DbSet<Permission> Permissions { get; set; }
    public DbSet<RefreshToken> RefreshTokens { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<Restaurant> Restaurants { get; set; }
    public DbSet<RestaurantHours> RestaurantsHours { get; set; }
    public DbSet<RestaurantTable> RestaurantTables { get; set; }
    public DbSet<Staff> Staff { get; set; }
    public DbSet<StaffPermission> StaffPermissions { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}

