namespace RestaurantReservationSystem.Domain.Entities;

public class GuestEmail
{
    public Guid Id { get; set; }
    public Guid GuestId { get; set; }
    public Guest Guest { get; set; } = null!;
    public required string Email { get; set; }
    public bool IsPrimary { get; set; }
}
