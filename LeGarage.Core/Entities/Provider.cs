using LeGarage.Core.Common;
using System.ComponentModel.DataAnnotations;

namespace LeGarage.Core.Entities;

public class Provider : BaseEntity
{
    public required string LegalName { get; set; }
    public string? ContactPerson { get; set; }

    [Phone]
    public required string Phone { get; set; }

    [EmailAddress]
    public string? Email { get; set; }
    public required string Address { get; set; }
    public required string CompanyRNE { get; set; }
    public string? PaymentTerms { get; set; }
    public ICollection<StockReplenishment> StockReplenishments { get; set; } = new List<StockReplenishment>();
    public ICollection<TaskExternalServiceUsage> TaskExternalServiceUsages { get; set; } = new List<TaskExternalServiceUsage>();
}