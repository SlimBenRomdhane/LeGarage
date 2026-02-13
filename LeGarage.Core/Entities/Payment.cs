using LeGarage.Core.Common;

namespace LeGarage.Core.Entities;

public class Payment : BaseEntity
{
    public int? PayPaymentId { get; set; }

    public int ClientId { get; set; }

    public int PaymentMethodId { get; set; }

    public decimal? Amount { get; set; }

    public DateOnly? PaymentDate { get; set; }

    public required string PaymentType { get; set; }

    public Client? Client { get; set; }

    public ICollection<Payment> InversePayPayment { get; set; } = new List<Payment>();

    public Payment? PayPayment { get; set; }

    public ICollection<PaymentAllocation> PaymentAllocations { get; set; } = new List<PaymentAllocation>();

    public PaymentMethod? PaymentMethod { get; set; }
}
