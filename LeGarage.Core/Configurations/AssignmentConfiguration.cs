using LeGarage.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeGarage.Core.Configurations
{
    public class AssignmentConfiguration : IEntityTypeConfiguration<Assignment>
    {
        public void Configure(EntityTypeBuilder<Assignment> entity)
        {
            entity.HasKey(x => x.Id);

            //entity.HasKey(e => new { e.Userid, e.Workshopid, e.Assignmentid }).HasName("pk_assignment");
            //entity.ToTable("assignment");
            entity.HasIndex(e => new { e.UserId, e.WorkshopId }, "assignment_pk").IsUnique();
            
            entity.HasIndex(e => e.Userid, "association7_fk");
            entity.HasIndex(e => e.Workshopid, "association7_fk2");
            entity.Property(e => e.Userid).HasColumnName("userid");
            entity.Property(e => e.Workshopid).HasColumnName("workshopid");
            entity.Property(e => e.Assignmentid).HasColumnName("assignmentid");
            entity.Property(e => e.Assignmentdate).HasColumnName("assignmentdate");
            entity.Property(e => e.Role)
                .HasMaxLength(254)
                .HasColumnName("role");

            entity.HasOne(d => d.User).WithMany(p => p.Assignments)
                .HasForeignKey(d => d.Userid)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_assignme_associati_user");

            entity.HasOne(d => d.Workshop).WithMany(p => p.Assignments)
                .HasForeignKey(d => d.Workshopid)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_assignme_associati_workshop");

        }
    }
}
