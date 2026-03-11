namespace RestaurantReservationSystem.Domain.Entities;

public class GuestPhone
{
    public Guid Id { get; set; }
    public Guid GuestId { get; set; }
    public Guest Guest { get; set; } = null!;
    public required string Phone {  get; set; }
    public bool IsPrimary { get; set; }
}
