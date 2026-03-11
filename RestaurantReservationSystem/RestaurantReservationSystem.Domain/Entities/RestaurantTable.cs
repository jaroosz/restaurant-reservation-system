namespace RestaurantReservationSystem.Domain.Entities;

public class RestaurantTable
{
    public Guid Id { get; set; }
    public Guid RestaurantId { get; set; }
    public Restaurant Restaurant { get; set; } = null!;
    public required string TableNumber { get; set; }
    public int Capacity { get; set; }
    public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
