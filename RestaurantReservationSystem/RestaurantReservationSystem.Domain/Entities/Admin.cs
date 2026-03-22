namespace RestaurantReservationSystem.Domain.Entities;

public class Admin
{
    public Guid Id { get; set; }
    public required string Email { get; set; }
    public required string Login { get; set; }
    public required string PasswordHash { get; set; }
    public Restaurant? Restaurant { get; set; }
    public ICollection<RefreshToken> RefreshTokens { get; set; } = new List<RefreshToken>();
}
