using Data.Entities.Base;

namespace Data.Entities;

/// <summary>
/// Запись о запчасти в работе заказа
/// </summary>
public class OrderWorkPart : EntityBase
{
    /// <summary>
    /// Идентификатор работы в заказе
    /// </summary>
    public long OrderWorkId { get; set; }

    /// <summary>
    /// Идентификатор запчасти
    /// </summary>
    public long PartId { get; set; }

    /// <summary>
    /// Запчасть
    /// </summary>
    public Part Part { get; set; }

    /// <summary>
    /// Стоимость запчасти
    /// </summary>
    public decimal Cost { get; set; }
}