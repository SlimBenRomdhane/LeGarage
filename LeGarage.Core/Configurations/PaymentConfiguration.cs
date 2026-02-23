using LeGarage.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeGarage.Core.Configurations
{
    public class PaymentConfiguration : BaseEntityConfiguration<Payment>
    {
        public override void Configure(EntityTypeBuilder<Payment> entity)
        {
            base.Configure(entity);
            entity.ToTable(tb => tb.HasCheckConstraint("CK_Payment_Positive", "Amount >= 0"));
            entity.HasOne(p => p.PayPayment)
                .WithMany()
                .HasForeignKey(p => p.PayPaymentId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);
            entity.HasIndex(p => p.PayPaymentId)
                .IsUnique();
        }
    }
}
