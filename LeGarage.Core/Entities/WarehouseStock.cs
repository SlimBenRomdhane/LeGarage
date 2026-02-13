using LeGarage.Core.Common;

namespace LeGarage.Core.Entities;

public class WarehouseStock : BaseEntity
{
    public int SparePartId { get; set; }

    public int WarehouseId { get; set; }

    public int? MinimumQuantity { get; set; }

    public int CurrentQuantity { get; set; }

    public SparePart? SparePart { get; set; }

    public Warehouse? Warehouse { get; set; }
}