using LeGarage.Core.Common;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeGarage.Core.Entities;

public class PaymentAllocation : BaseEntity
{
    [ForeignKey("Invoice")]
    public int InvoiceId { get; set; }


    [ForeignKey("Payment")]
    public int PaymentId { get; set; }
    public decimal AmountAllocated { get; set; }

    public Invoice? Invoice { get; set; }

    public Payment? Payment { get; set; }
}
