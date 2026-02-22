using LeGarage.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeGarage.Core.Configurations
{
    public class ExternalServiceConfiguration : BaseEntityConfiguration<ExternalService>
    {
        public override void Configure(EntityTypeBuilder<ExternalService> entity)
        {
            base.Configure(entity);
            entity.Property(e => e.Name).HasMaxLength(50).IsRequired();
            entity.Property(e => e.Description).HasMaxLength(254);
            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.Unit).HasMaxLength(50);
            entity.Property(e => e.Cost)
                .HasColumnType("decimal(18,3)")
                .IsRequired();
            entity.ToTable(tb => tb.HasCheckConstraint("CK_ExternalService_Cost_Positive", "Cost >=0"));
        }
    }
}
