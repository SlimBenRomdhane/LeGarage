
using LeGarage.Core.Common;

namespace LeGarage.Core.Entities;

public class Client : BaseEntity
{
    public required string Cin { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public required string Phone { get; set; }

    public string? Email { get; set; }

    public required string Address { get; set; }

    public string? CompanyId { get; set; }

    public string? CompanyName { get; set; }

    public ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();

    public ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
}