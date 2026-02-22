using LeGarage.Core.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeGarage.Core.Entities
{
    public class Machine : BaseEntity
    {
        [ForeignKey("Workshop")]
        public int WorkshopId { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal PurchasePrice { get; set; }
        public DateTime? LastMaintenanceDate { get; set; }
        public DateTime? NextMaintenanceDate { get; set; }
        public WorkShop? Workshop { get; set; }

    }
}
