using LeGarage.Core.Common;

namespace LeGarage.Core.Entities;

public class ProvidedServiceCategory : BaseEntity
{
    public required string Name { get; set; }

    public required string Code { get; set; }

    public required string Description { get; set; }

    public ICollection<ProvidedService> ProvidedServices { get; set; } = new List<ProvidedService>();
}