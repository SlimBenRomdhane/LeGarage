using LeGarage.Core.Common;

namespace LeGarage.Core.Entities;

public class WorkShop : BaseEntity
{
    public required string Code { get; set; }

    public required string Name { get; set; }

    public required string Location { get; set; }

    public required string Phone { get; set; }

    public string? Email { get; set; }

    public string? OpeningHours { get; set; }

    public ICollection<Assignment> Assignments { get; set; } = new List<Assignment>();

    public ICollection<Bridge> Bridges { get; set; } = new List<Bridge>();

    public ICollection<WorkOrder> Workorders { get; set; } = new List<WorkOrder>();
}