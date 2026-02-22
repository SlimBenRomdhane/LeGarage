
using LeGarage.Core.Common;
using LeGarage.Core.Entities.UserManagement;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeGarage.Core.Entities;

public class Assignment : BaseEntity
{
    [ForeignKey("User")]
    public int UserId { get; set; }

    [ForeignKey("WorkShop")]
    public int WorkshopId { get; set; }
    public DateOnly? AssignmentDate { get; set; }
    public required string Role { get; set; }
    public ApplicationUser? User { get; set; }
    public WorkShop? WorkShop { get; set; }
}