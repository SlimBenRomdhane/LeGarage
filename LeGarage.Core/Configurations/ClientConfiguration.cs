using LeGarage.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeGarage.Core.Configurations
{
    public class ClientConfiguration : BaseEntityConfiguration<Client>
    {
        public override void Configure(EntityTypeBuilder<Client> entity)
        {
            // Call the base configuration to apply common settings
            base.Configure(entity);
            // Configure specific properties for the Client entity
            entity.Property(c => c.ClientType).HasMaxLength(20).IsRequired();
            entity.Property(c => c.Cin).HasMaxLength(8);
            entity.HasIndex(c => c.Cin).IsUnique();
            entity.Property(c => c.FirstName).HasMaxLength(50);
            entity.Property(c => c.LastName).HasMaxLength(50);
            entity.Property(c => c.Phone).HasMaxLength(50).IsRequired();
            entity.Property(c => c.Email).HasMaxLength(50);
            entity.Property(c => c.Address).HasMaxLength(254).IsRequired();
            entity.Property(c => c.CompanyId).HasMaxLength(50);
            entity.Property(c => c.CompanyName).HasMaxLength(50);
            entity.ToTable(tb =>
            {
                tb.HasCheckConstraint("CK_Client_Type",
                    @"CASE 
                            WHEN ClientType = 'Person' 
                                THEN Cin IS NOT NULL AND FirstName IS NOT NULL AND LastName IS NOT NULL
                            WHEN ClientType = 'Company' 
                                THEN CompanyId IS NOT NULL AND CompanyName IS NOT NULL 
                            ELSE 0=1 
                        END");
            });

        }
    }
}
