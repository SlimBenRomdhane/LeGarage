using Microsoft.AspNetCore.Identity;

namespace LeGarage.Core.Entities;

public class ApplicationUser : IdentityUser<int>
{
    public required string Name { get; set; }

    public required string Lastname { get; set; }
    public string? Phonenumber { get; set; }

    public string? Address { get; set; }

    public DateOnly? Hiredate { get; set; }

    public required string Availabilitystatus { get; set; }

    public ICollection<Assignment> Assignments { get; set; } = new List<Assignment>();

    public ICollection<Task> Tasks { get; set; } = new List<Task>();
}