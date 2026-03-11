namespace RestaurantReservationSystem.Domain.Entities;

public class StaffPermission
{
    public Guid StaffId { get; set; }
    public Staff Staff { get; set; } = null!;
    public Guid PermissionId { get; set; }
    public Permission Permission { get; set; } = null!;
}
