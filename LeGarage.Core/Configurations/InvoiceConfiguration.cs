using LeGarage.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeGarage.Core.Configurations
{
    public class InvoiceConfiguration : BaseEntityConfiguration<Invoice>
    {
        public override void Configure(EntityTypeBuilder<Invoice> entity)
        {
            base.Configure(entity);

            entity.HasIndex(i => i.ClientId);
            entity.Property(i => i.IssueDate).IsRequired();
            entity.Property(i => i.DueDate).IsRequired();
            entity.Property(i => i.Status).HasMaxLength(50);
            entity.Property(i => i.SubtotalLabor).HasColumnType("decimal(18,3)");
            entity.Property(i => i.SubtotalParts).HasColumnType("decimal(18,3)");
            entity.Property(i => i.SubtotalExternalServices).HasColumnType("decimal(18,3)");
            entity.Property(i => i.TaxAmount).HasColumnType("decimal(18,3)");
            entity.Property(i => i.DiscountAmount).HasColumnType("decimal(18,3)");
            entity.Property(i => i.TotalAmount).HasColumnType("decimal(18,3)");



        }
    }
}
