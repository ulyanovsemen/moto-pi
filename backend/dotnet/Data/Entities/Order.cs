using Core.Enums;
using Data.Entities.Base;

namespace Data.Entities;

/// <summary>
/// Заказ
/// </summary>
public class Order : EntityBase
{
    /// <summary>
    /// Дата создания
    /// </summary>
    public DateTime CreateDate { get; set; }
    
    /// <summary>
    /// Идентификатор заказчика
    /// </summary>
    public long CustomerId { get; set; }

    /// <summary>
    /// Заказчик
    /// </summary>
    public Customer Customer { get; set; }

    /// <summary>
    /// Идентификатор ТС
    /// </summary>
    public long VehicleId { get; set; }
    
    /// <summary>
    /// ТС
    /// </summary>
    public Vehicle Vehicle { get; set; }

    /// <summary>
    /// VIN
    /// </summary>
    public string Vin { get; set; }

    /// <summary>
    /// Номер
    /// </summary>
    public string Number { get; set; }
    
    /// <summary>
    /// Список работ
    /// </summary>
    public ICollection<OrderWork> Works { get; set; }

    /// <summary>
    /// Статус заказа
    /// </summary>
    public OrderStatus Status { get; set; } = OrderStatus.New;

    /// <summary>
    /// Дата изменения
    /// </summary>
    public DateTime ChangeDate { get; set; }
}