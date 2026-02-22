using LeGarage.Core.Common;

namespace LeGarage.Core.Entities;

public class Vehicle : BaseEntity
{
    public int ClientId { get; set; }
    public required string Vin { get; set; }
    public string? PlateNumber { get; set; }
    public string? Make { get; set; }
    public string? Model { get; set; }
    public int Year { get; set; }
    public int Mileage { get; set; }
    public required string FuelType { get; set; }
    public DateTime InsuranceRenewal { get; set; }
    public DateTime RoadTaxRenewal { get; set; }
    public Client? Client { get; set; }
    public ICollection<WorkOrder> WorkOrders { get; set; } = new List<WorkOrder>();
}