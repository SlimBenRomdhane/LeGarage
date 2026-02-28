using LeGarage.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeGarage.Core.Configurations
{
    public class ProviderConfiguration : BaseEntityConfiguration<Provider>
    {
        public override void Configure(EntityTypeBuilder<Provider> entity)
        {
            base.Configure(entity);
            entity.Property(p => p.LegalName).HasMaxLength(100);
            entity.Property(p => p.ContactPerson).HasMaxLength(100);
            entity.Property(p => p.Phone).HasMaxLength(25);
            entity.Property(p => p.Email).HasMaxLength(100);
            entity.Property(p => p.Address).HasMaxLength(254);
            entity.Property(p => p.CompanyRNE).HasMaxLength(50);
            entity.HasIndex(p => p.Phone);
            entity.HasIndex(p => p.CompanyRNE).IsUnique();
        }
    }
}
