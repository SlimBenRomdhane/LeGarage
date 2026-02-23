using LeGarage.Core.Common;

namespace LeGarage.Core.Entities;

public class PaymentMethod : BaseEntity
{
    public required string MethodCode { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public ICollection<Payment> Payments { get; set; } = new List<Payment>();
}