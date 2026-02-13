using LeGarage.Core.Common;

namespace LeGarage.Core.Entities;

public class Task : BaseEntity
{
    // Additional properties or methods can be added here if needed.
    public int TaskId { get; set; }

    public int BridgeId { get; set; }

    public int UserId { get; set; }

    public int WorkOrderId { get; set; }

    public int ProvidedServiceId { get; set; }

    public required string Description { get; set; }

    public DateOnly StartTime { get; set; }

    public DateOnly? EndTime { get; set; }

    public decimal LaborCost { get; set; }

    public decimal PartsCost { get; set; }

    public decimal ExternalServiceCost { get; set; }

    public decimal TaskTotalCost { get; set; }

    public Bridge? Bridge { get; set; }

    public ICollection<PauseRecord> PauseRecords { get; set; } = new List<PauseRecord>();

    public ProvidedService? ProvidedService { get; set; }

    public ICollection<TaskExternalServiceUsage> TaskExternalServiceUsages { get; set; } = new List<TaskExternalServiceUsage>();

    public ICollection<TaskPartUsage> TaskPartUsages { get; set; } = new List<TaskPartUsage>();

    public ApplicationUser? User { get; set; }

    public WorkOrder? WorkOrder { get; set; }
}