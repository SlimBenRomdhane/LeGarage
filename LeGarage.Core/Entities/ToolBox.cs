using LeGarage.Core.Common;

namespace LeGarage.Core.Entities
{
    public class ToolBox : BaseEntity
    {
        public int WorkshopId { get; set; }
        public required string Code { get; set; }
        public int PieceCount { get; set; }
        public WorkShop? Workshop { get; set; }


    }
}
