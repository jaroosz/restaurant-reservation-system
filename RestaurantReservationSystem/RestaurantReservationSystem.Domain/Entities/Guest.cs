namespace RestaurantReservationSystem.Domain.Entities;

public class Guest
{
    public Guid Id { get; set; }
    public Guid RestaurantId { get; set; }
    public Restaurant Restaurant { get; set; } = null!;
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public bool NeedsMergeReview { get; set; }
    public Guid? MergedIntoGuestId { get; set; }
    public Guest? MergedIntoGuest { get; set; }
    public DateTime CreatedAt { get; set; }
    public required string Source {  get; set; }
    public ICollection<GuestPhone> Phones { get; set; } = new List<GuestPhone>();
    public ICollection<GuestEmail> Emails { get; set; } = new List<GuestEmail>();
    public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
