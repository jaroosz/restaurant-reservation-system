using RestaurantReservationSystem.Domain.Enums;

namespace RestaurantReservationSystem.Domain.Entities;

public class Reservation
{
    public Guid Id { get; set; }
    public Guid RestaurantId { get; set; }
    public Restaurant Restaurant { get; set; } = null!;
    public Guid RestaurantTableId { get; set; }
    public RestaurantTable RestaurantTable { get; set; } = null!;
    public Guid GuestId { get; set; }
    public Guest Guest { get; set; } = null!;
    public DateTime ReservationDate { get; set; }
    public int GuestCount { get; set; }
    public DateTime? SeatedAt { get; set; }
    public DateTime EndTime { get; set; }
    public ReservationStatus Status { get; set; }
    public string? Notes { get; set; }
    public DateTime CreatedAt { get; set; }
    public ReservationSource Source { get; set; }
}
