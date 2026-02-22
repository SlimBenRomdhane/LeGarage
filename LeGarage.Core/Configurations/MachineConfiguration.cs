using LeGarage.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeGarage.Core.Configurations
{
    public class MachineConfiguration : BaseEntityConfiguration<Machine>
    {
        override public void Configure(EntityTypeBuilder<Machine> entity)
        {
            base.Configure(entity);
            entity.HasIndex(m => m.WorkshopId);
            entity.Property(m => m.Name).HasMaxLength(50);
            entity.Property(m => m.Description).HasMaxLength(254);
            entity.Property(m => m.PurchasePrice).HasColumnType("decimal(18,3)");
            entity.Property(m => m.LastMaintenanceDate).IsRequired(false);
            entity.Property(m => m.NextMaintenanceDate).IsRequired(false);
        }
    }
}
