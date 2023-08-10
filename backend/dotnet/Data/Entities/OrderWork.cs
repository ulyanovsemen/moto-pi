using Data.Entities.Base;

namespace Data.Entities;

/// <summary>
/// Запись о работе в заказе
/// </summary>
public class OrderWork : EntityBase
{
    /// <summary>
    /// Идентификатор заказа
    /// </summary>
    public long OrderId { get; set; }
    
    /// <summary>
    /// Идентификатор работы
    /// </summary>
    public long WorkId { get; set; }

    /// <summary>
    /// Работа
    /// </summary>
    public Work Work { get; set; }

    /// <summary>
    /// Идентификатор сотрудника
    /// </summary>
    public long EmployeeId { get; set; }

    /// <summary>
    /// Сотрудник
    /// </summary>
    public Employee Employee { get; set; }

    /// <summary>
    /// Стоимость работы
    /// </summary>
    public decimal Cost { get; set; }

    /// <summary>
    /// Запчасти, использованные в работе
    /// </summary>
    public ICollection<OrderWorkPart> Parts { get; set; }
}