using LeGarage.Core.Common;

namespace LeGarage.Core.Entities;

public class SparePart : BaseEntity
{
    public int SparePartCategoryId { get; set; }

    public required string SparePartCode { get; set; }

    public required string Name { get; set; }

    public string? Description { get; set; }

    public decimal? UnitPrice { get; set; }

    public int? AvailableQuantity { get; set; }

    public int? MinimumStock { get; set; }

    public SparePartCategory? SparePartCategory { get; set; }

    public ICollection<StockReplenishment> StockReplenishments { get; set; } = new List<StockReplenishment>();

    public ICollection<TaskPartUsage> TaskPartUsages { get; set; } = new List<TaskPartUsage>();

    public ICollection<WarehouseStock> WarehouseStocks { get; set; } = new List<WarehouseStock>();
}