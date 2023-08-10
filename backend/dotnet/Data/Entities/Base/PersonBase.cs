namespace Data.Entities.Base;

/// <summary>
/// Базовый класс для данных людей
/// </summary>
public abstract class PersonBase : EntityBase
{
    /// <summary>
    /// ФИО
    /// </summary>
    public string Fio { get; set; }

    /// <summary>
    /// Телефон
    /// </summary>
    public string TelNumber { get; set; }
}