
using LeGarage.Core.Common;

namespace LeGarage.Core.Entities;

public class Warehouse : BaseEntity
{

    public required string Name { get; set; }
    public required string Location { get; set; }
    public decimal? Capacity { get; set; }
    public string? CapacityUnit { get; set; }
    public ICollection<StockReplenishment> StockReplenishments { get; set; } = new List<StockReplenishment>();
    public ICollection<TaskPartUsage> TaskPartUsages { get; set; } = new List<TaskPartUsage>();
    public ICollection<WarehouseStock> WarehouseStocks { get; set; } = new List<WarehouseStock>();
}