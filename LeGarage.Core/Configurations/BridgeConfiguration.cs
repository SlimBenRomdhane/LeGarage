using LeGarage.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeGarage.Core.Configurations
{
    public class BridgeConfiguration : BaseEntityConfiguration<Bridge>
    {

        public override void Configure(EntityTypeBuilder<Bridge> entity)
        {
            // Call the base configuration to apply common configurations for all entities
            base.Configure(entity);
            // Configure specific properties for the Bridge entity
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.CapacityKg).IsRequired();
            // Add a check constraint to ensure that CapacityKg is greater than or equal to 0
            entity.ToTable(tb => tb.HasCheckConstraint("CK_Bridge_Capacity", "CapacityKg >=0"));
            //// Configure the relationship between Bridge and WorkShop
            //entity.HasOne(b => b.WorkShop)
            //    .WithMany(w => w.Bridges)
            //    .HasForeignKey(b => b.WorkshopId)
            //    .OnDelete(DeleteBehavior.Restrict);





        }
    }
}
