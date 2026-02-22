using LeGarage.Core.Common;
using LeGarage.Core.Common.Constants;
using LeGarage.Core.Common.Exceptions;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeGarage.Core.Entities;

public class PauseRecord : BaseEntity
{
    [ForeignKey("Task")]
    public int TaskId { get; set; }
    public PauseReasons Reason { get; set; }
    public DateTime StartTime { get; set; }

    private DateTime? _endTime;
    public DateTime? EndTime
    {
        get => _endTime;
        set
        {
            if (value.HasValue && value.Value < StartTime)
            {
                //throw new ArgumentException("EndTime cannot be earlier than StartTime.");
                throw new InvalidDateRangeException($"EndTime {value.Value:G} cannot be earlier than StartTime {StartTime:G}.");
            }
            _endTime = value;
            if (_endTime.HasValue)
            {
                PauseDuration = _endTime.Value - StartTime;
            }
        }

    }
    public TimeSpan? PauseDuration { get; private set; }
    public Task? Task { get; set; }
}
