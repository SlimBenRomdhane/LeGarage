using LeGarage.Core.Common;
using LeGarage.Core.Common.Constants;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeGarage.Core.Entities;

public class Payment : BaseEntity
{
    public PaymentTypes PaymentType { get; set; }
    public int? PayPaymentId { get; set; }

    [ForeignKey("Client")]
    public int ClientId { get; set; }

    [ForeignKey("PaymentMethod")]
    public int PaymentMethodId { get; set; }
    public decimal Amount { get; set; }
    public DateTime PaymentDate { get; set; }
    public Payment? PayPayment { get; set; }
    public Client? Client { get; set; }
    public PaymentMethod? PaymentMethod { get; set; }
    //public ICollection<Payment> InversePayPayment { get; set; } = new List<Payment>();
    public ICollection<PaymentAllocation> PaymentAllocations { get; set; } = new List<PaymentAllocation>();

}
