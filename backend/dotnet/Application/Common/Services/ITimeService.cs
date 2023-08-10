namespace Application.Common.Services;

/// <summary>
/// Сервис для получения времени
/// </summary>
public interface ITimeService
{
    /// <summary>
    /// Получить текущее время
    /// </summary>
    DateTime UtcNow();
}