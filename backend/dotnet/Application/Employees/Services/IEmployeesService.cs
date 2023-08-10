using Application.Employees.Dto;

namespace Application.Employees.Services;

/// <summary>
/// Сервис для работы с сотрудниками
/// </summary>
public interface IEmployeesService
{
    /// <summary>
    /// Получить список запчастей
    /// </summary>
    Task<ICollection<EmployeeDto>> GetEmployees();
}