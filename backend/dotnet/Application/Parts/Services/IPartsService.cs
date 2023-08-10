using Application.Parts.Dto;

namespace Application.Parts.Services;

/// <summary>
/// Сервис для запчастей
/// </summary>
public interface IPartsService
{
    /// <summary>
    /// Получить список запчастей
    /// </summary>
    Task<ICollection<PartDto>> GetParts();
}