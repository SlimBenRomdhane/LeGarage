
using LeGarage.Core.Common;

namespace LeGarage.Core.Entities;

public class Invoice : BaseEntity
{
    public int ClientId { get; set; }

    public DateOnly IssueDate { get; set; }

    public DateOnly? DueDate { get; set; }

    public required string Status { get; set; }

    public decimal? SubtotalLabor { get; set; }

    public decimal? SubtotalParts { get; set; }

    public decimal? SubtotalExternalServices { get; set; }

    public decimal? TaxAmount { get; set; }

    public decimal? DiscountAmount { get; set; }

    public decimal? TotalAmount { get; set; }

    public Client? Client { get; set; }

    public ICollection<PaymentAllocation> PaymentAllocations { get; set; } = new List<PaymentAllocation>();

    public ICollection<WorkOrder> WorkOrders { get; set; } = new List<WorkOrder>();
}
