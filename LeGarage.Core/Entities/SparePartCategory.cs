using LeGarage.Core.Common;

namespace LeGarage.Core.Entities;

public class SparePartCategory : BaseEntity
{
    public required string Name { get; set; }

    public string? Description { get; set; }

    public ICollection<SparePart> SpareParts { get; set; } = new List<SparePart>();
}