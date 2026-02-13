
using LeGarage.Core.Common;

namespace LeGarage.Core.Entities;

public class StockReplenishment : BaseEntity
{
    public int SparePartId { get; set; }

    public int ProviderId { get; set; }

    public int WarehouseId { get; set; }

    public required string ReceptionReceipt { get; set; }

    public int ReceivedQuantity { get; set; }

    public DateOnly ReceptionDate { get; set; }

    public decimal UnitPriceAtPurchase { get; set; }

    public decimal Discount { get; set; }

    public decimal Vat { get; set; }

    public decimal Margin { get; set; }

    public Provider? Provider { get; set; }

    public SparePart? SparePart { get; set; }

    public Warehouse? Warehouse { get; set; }
}