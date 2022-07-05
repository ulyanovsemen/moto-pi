using Application.Common.Dto;

namespace Application.Works.Dto;

/// <summary>
/// DTO для работы
/// </summary>
public class WorkDto : DictionaryDto
{
    /// <summary>
    /// Вид работ
    /// </summary>
    public DictionaryDto Type { get; set; }
}