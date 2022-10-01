namespace Web.Contracts;

/// <summary>
/// Контракт для запчасти
/// </summary>
public class EmployeeContract
{
    /// <summary>
    /// Идентификатор сотрудника
    /// </summary>
    public long Id { get; set; }
    
    /// <summary>
    /// ФИО
    /// </summary>
    public string Fio { get; set; }

    /// <summary>
    /// Телефон
    /// </summary>
    public string TelNumber { get; set; }
}