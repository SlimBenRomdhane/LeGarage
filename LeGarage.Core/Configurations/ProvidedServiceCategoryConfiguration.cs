using LeGarage.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeGarage.Core.Configurations
{
    public class ProvidedServiceCategoryConfiguration : BaseEntityConfiguration<ProvidedServiceCategory>
    {
        public override void Configure(EntityTypeBuilder<ProvidedServiceCategory> entity)
        {
            base.Configure(entity);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(254);
            entity.HasIndex(e => e.Code).IsUnique();
            entity.HasIndex(e => e.Name).IsUnique();
            entity.ToTable(tb => tb.HasCheckConstraint("CK_Code_Not_Null", "Code IS NOT NULL"));
            entity.ToTable(tb => tb.HasCheckConstraint("CK_Name_Not_Null", "Name IS NOT NULL"));

        }
    }
}
