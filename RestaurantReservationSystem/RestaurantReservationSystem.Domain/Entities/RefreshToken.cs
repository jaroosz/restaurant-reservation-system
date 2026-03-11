namespace RestaurantReservationSystem.Domain.Entities;

public class RefreshToken
{
    public Guid Id { get; set; }
    public required string Token { get; set; }
    public DateTime ExpiresAt { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsRevoked { get; set; }
    public Guid? AdminId { get; set; }
    public Admin? Admin { get; set; }
    public Guid? StaffId { get; set; }
    public Staff? Staff { get; set; }
}
