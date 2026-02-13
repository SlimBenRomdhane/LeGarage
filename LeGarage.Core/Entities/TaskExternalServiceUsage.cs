using LeGarage.Core.Common;

namespace LeGarage.Core.Entities;

public class TaskExternalServiceUsage : BaseEntity
{
    public int ProviderId { get; set; }

    public int ExternalServiceId { get; set; }

    public int TaskId { get; set; }

    public required string InvoiceNumber { get; set; }

    public decimal? UnitPrice { get; set; }

    public int? Quantity { get; set; }

    public decimal Cost { get; set; }

    public ExternalService? ExternalService { get; set; }

    public Provider? Provider { get; set; }

    public Task? Task { get; set; }
}