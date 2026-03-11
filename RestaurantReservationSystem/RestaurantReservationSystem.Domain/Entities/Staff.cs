namespace RestaurantReservationSystem.Domain.Entities;

public class Staff
{
    public Guid Id { get; set; }
    public Guid RestaurantId { get; set; }
    public Restaurant Restaurant { get; set; } = null!;
    public required string Login {  get; set; }
    public required string PasswordHash { get; set; }
    public required string DisplayName { get; set; }
    public required string RoleTitle { get; set; }
    public ICollection<StaffPermission> StaffPermissions { get; set; } = new List<StaffPermission>();
}
