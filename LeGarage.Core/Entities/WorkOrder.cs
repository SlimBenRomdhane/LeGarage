using LeGarage.Core.Common;

namespace LeGarage.Core.Entities;

public class WorkOrder : BaseEntity
{
    public int WorkshopId { get; set; }
    public int? InvoiceId { get; set; }
    public int VehicleId { get; set; }
    public int? WorkOrderNumber { get; set; }
    public int Mileage { get; set; }
    public required string Status { get; set; }
    public DateOnly? ScheduledStart { get; set; }
    public DateOnly? ActualStart { get; set; }
    public DateOnly? ActualEnd { get; set; }
    public decimal? LaborCost { get; set; }
    public decimal? PartsCost { get; set; }
    public decimal? ExternalServiceCost { get; set; }
    public decimal? TotalCost { get; set; }
    public Invoice? Invoice { get; set; }
    public ICollection<Task> Tasks { get; set; } = new List<Task>();
    public Vehicle? Vehicle { get; set; }
    public WorkShop? Workshop { get; set; }
}