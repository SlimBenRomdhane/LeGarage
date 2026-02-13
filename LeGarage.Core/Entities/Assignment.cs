
using LeGarage.Core.Common;

namespace LeGarage.Core.Entities;

public class Assignment : BaseEntity
{
    public int UserId { get; set; }

    public int WorkshopId { get; set; }

    public int AssignmentId { get; set; }

    public DateOnly? AssignmentDate { get; set; }

    public required string Role { get; set; }

    public ApplicationUser? User { get; set; }

    public WorkShop? WorkShop { get; set; }
}