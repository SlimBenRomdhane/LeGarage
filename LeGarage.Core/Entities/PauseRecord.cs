
using LeGarage.Core.Common;

namespace LeGarage.Core.Entities;

public class PauseRecord : BaseEntity
{
    public int TaskId { get; set; }

    public required string Reason { get; set; }

    public DateOnly StartTime { get; set; }

    public DateOnly? EndTime { get; set; }

    public int? PauseDuration { get; set; }

    public Task? Task { get; set; }
}
