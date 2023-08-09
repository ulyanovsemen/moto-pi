namespace Application.Employees.Dto;

/// <summary>
/// DTO Сотрудника
/// </summary>
public class EmployeeDto
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