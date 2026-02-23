using LeGarage.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeGarage.Core.Configurations
{
    public class ProvidedServiceConfiguration : BaseEntityConfiguration<ProvidedService>
    {
        public override void Configure(EntityTypeBuilder<ProvidedService> entity)
        {
            base.Configure(entity);
            entity.HasIndex(p => p.PricingModel);
            entity.Property(p => p.Name).HasMaxLength(50);
            entity.HasIndex(p => p.Name).IsUnique();
            entity.Property(p=>p.Rate).HasColumnType("decimal(18,3)");
            entity.Property(p => p.EstimatedHours).HasColumnType("decimal(6,2)");
            entity.ToTable(tb => tb.HasCheckConstraint("CK_ProvidedService_Cost_Positive", "Rate >=0"));
            entity.ToTable(tb => tb.HasCheckConstraint("ProvidedService_Cost_Not_Null", "Rate IS NOT NULL"));

        }
    }
}
