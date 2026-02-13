using LeGarage.Core.Common;
using System;
using System.Collections.Generic;

namespace LeGarage.Core.Entities;

public class TaskPartUsage : BaseEntity
{

    public int WarehouseId { get; set; }

    public int SparePartId { get; set; }

    public int TaskId { get; set; }

    public int QuantityUsed { get; set; }

    public int UnitPrice { get; set; }

    public decimal TotalPartCost { get; set; }

    public required string DeliveryNote { get; set; }

    public SparePart? SparePart { get; set; }

    public Task? Task { get; set; }

    public Warehouse? Warehouse { get; set; }
}