using LeGarage.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeGarage.Core.Configurations
{
    public class PaymentMethodConfiguration : BaseEntityConfiguration<PaymentMethod>
    {
        public override void Configure(EntityTypeBuilder<PaymentMethod> entity)
        {
            base.Configure(entity);
            entity.HasIndex(pm => pm.MethodCode).IsUnique();
            entity.Property(pm => pm.MethodCode).HasMaxLength(50);
            entity.Property(pm => pm.Name).HasMaxLength(50);
            entity.Property(pm => pm.Description).HasMaxLength(254);


        }
    }
}
