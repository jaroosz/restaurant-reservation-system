namespace RestaurantReservationSystem.Domain.Entities;

public class Restaurant
{
    public Guid Id { get; set; }
    public Guid AdminId { get; set; }
    public Admin Admin { get; set; } = null!;
    public required string Name { get; set; }
    public required string WidgetUrl { get; set; }
    public int DefaultReservationDuration { get; set; }
    public ICollection<Staff> Staff { get; set; } = new List<Staff>();
    public ICollection<Guest> Guests { get; set; } = new List<Guest>();
    public ICollection<RestaurantTable> Tables { get; set; } = new List<RestaurantTable>();
    public ICollection<RestaurantHours> Hours { get; set; } = new List<RestaurantHours>();
    public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
