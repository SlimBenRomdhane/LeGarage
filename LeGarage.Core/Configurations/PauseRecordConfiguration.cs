using LeGarage.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeGarage.Core.Configurations
{
    public class PauseRecordConfiguration : BaseEntityConfiguration<PauseRecord>
    {
        public override void Configure(EntityTypeBuilder<PauseRecord> entity)
        {
            base.Configure(entity);
            entity.Property(e => e.Reason).HasMaxLength(50);
            entity.ToTable(tb =>
                    tb.HasCheckConstraint("CK_PauseRecord_DateRange", "EndTime IS NULL OR EndTime >= StartTime"));

        }
    }
}
