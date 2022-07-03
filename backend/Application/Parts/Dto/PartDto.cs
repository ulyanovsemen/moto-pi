using Application.Common.Dto;

namespace Application.Parts.Dto;

public class PartDto : DictionaryDto
{
    /// <summary>
    /// Тип запчасти
    /// </summary>
    public DictionaryDto Type { get; set; }

    /// <summary>
    /// Модель
    /// </summary>
    public string Model { get; set; }

    /// <summary>
    /// Номер
    /// </summary>
    public string Number { get; set; }

}