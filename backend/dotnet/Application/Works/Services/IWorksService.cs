using Application.Works.Dto;

namespace Application.Works.Services;

/// <summary>
/// Сервис для работ
/// </summary>
public interface IWorksService
{
    /// <summary>
    /// Получить список работ
    /// </summary>
    Task<ICollection<WorkDto>> GetWorks();
}