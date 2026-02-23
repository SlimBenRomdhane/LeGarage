using LeGarage.Core.Common;
using LeGarage.Core.Common.Constants;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeGarage.Core.Entities;

public class ProvidedService : BaseEntity
{
    [ForeignKey("ProvidedServiceCategory")]
    public int ProvidedServiceCategoryId { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public ModelPricingType PricingModel { get; set; }
    public decimal Rate { get; set; }
    public decimal EstimatedHours { get; set; }
    public decimal? MinCharge { get; set; }
    public ProvidedServiceCategory? ProvidedServiceCategory { get; set; }
    public ICollection<Task> Tasks { get; set; } = new List<Task>();
}