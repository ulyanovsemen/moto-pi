namespace Application.Common.Services;

/// <inheritdoc/>
public class TimeService : ITimeService
{
    /// <inheritdoc/>
    public DateTime UtcNow()
    {
        return DateTime.UtcNow;
    }
}