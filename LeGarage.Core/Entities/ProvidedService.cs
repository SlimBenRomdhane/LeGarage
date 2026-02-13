using LeGarage.Core.Common;

namespace LeGarage.Core.Entities;

public partial class ProvidedService : BaseEntity
{
    public int ProvidedServiceCategoryId { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required string PricingModel { get; set; }
    public decimal? Rate { get; set; }
    public decimal? EstimatedHours { get; set; }
    public decimal? MinCharge { get; set; }
    public ProvidedServiceCategory? ProvidedServiceCategory { get; set; }
    public ICollection<Task> Tasks { get; set; } = new List<Task>();
}