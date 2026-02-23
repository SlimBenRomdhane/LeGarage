using LeGarage.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeGarage.Core.Configurations
{
    public class PaymentAllocationConfiguration : BaseEntityConfiguration<PaymentAllocation>
    {
        public override void Configure(EntityTypeBuilder<PaymentAllocation> entity)
        {
            base.Configure(entity);
            entity.HasIndex(p => p.InvoiceId);
            entity.HasIndex(p => p.PaymentId);
            entity.HasIndex(p => new { p.InvoiceId, p.PaymentId }).IsUnique();
            entity.ToTable(tb => tb.HasCheckConstraint("Ck_Amount_Positive", "AmountAllocated >=0"));
        }
    }
}
