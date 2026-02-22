using LeGarage.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeGarage.Core.Configurations
{
    public class AssignmentConfiguration : BaseEntityConfiguration<Assignment>
    {

        public override void Configure(EntityTypeBuilder<Assignment> entity)
        {
            // Call the base class's Configure method to apply common configurations
            base.Configure(entity);

            // Define a unique index on the combination of UserId and WorkshopId
            entity.HasIndex(e => new { e.UserId, e.WorkshopId })
                .IsUnique();
            // Define indexes on UserId and WorkshopId for faster lookups
            entity.HasIndex(e => e.UserId);
            entity.HasIndex(e => e.WorkshopId);
            // Map properties to their respective column names
            entity.Property(e => e.UserId);
            entity.Property(e => e.WorkshopId);
            entity.Property(e => e.AssignmentDate);
            entity.Property(e => e.Role).HasMaxLength(50);
            // Configure the relationship between Assignment and ApplicationUser
            entity.HasOne(a => a.User)
                .WithMany(u => u.Assignments)
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.Restrict);
            // Configure the relationship between Assignment and WorkShop
            entity.HasOne(d => d.WorkShop)
                .WithMany(d => d.Assignments)
                .HasForeignKey(d => d.WorkshopId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
