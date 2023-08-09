using Data.Entities.Base;

namespace Data.Entities;

/// <summary>
/// Сотрудник
/// </summary>
public class Employee : EntityBase
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