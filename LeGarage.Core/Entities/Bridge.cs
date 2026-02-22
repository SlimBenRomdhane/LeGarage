
using LeGarage.Core.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeGarage.Core.Entities;

public class Bridge : BaseEntity
{
    [ForeignKey("WorkShop")]
    public int WorkshopId { get; set; }

    public required string Code { get; set; }

    public required string Name { get; set; }

    public int CapacityKg { get; set; }

    public bool IsAvailable { get; set; }

    public ICollection<Task> Tasks { get; set; } = new List<Task>();

    public WorkShop? WorkShop { get; set; }
}