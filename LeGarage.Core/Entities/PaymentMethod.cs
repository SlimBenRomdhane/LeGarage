
using LeGarage.Core.Common;

namespace LeGarage.Core.Entities;

public class PaymentMethod : BaseEntity
{
    public int PaymentMethodId { get; set; }

    public required string Name { get; set; }

    public required string Description { get; set; }

    public ICollection<Payment> Payments { get; set; } = new List<Payment>();
}