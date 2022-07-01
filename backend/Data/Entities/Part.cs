using Data.Entities.Base;

namespace Data.Entities;

/// <summary>
/// Запчасть
/// </summary>
public class Part : DictionaryBase
{
    /// <summary>
    /// Модель
    /// </summary>
    public string Model { get; set; }

    /// <summary>
    /// Номер
    /// </summary>
    public string Number { get; set; }
}