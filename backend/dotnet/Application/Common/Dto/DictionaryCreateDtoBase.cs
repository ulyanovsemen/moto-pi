namespace Application.Common.Dto;

/// <summary>
/// Базовый DTO для создания словарей
/// </summary>
public record DictionaryCreateDtoBase
{
    /// <summary>
    /// Наименование
    /// </summary>
    public string Name { get; init; }
}