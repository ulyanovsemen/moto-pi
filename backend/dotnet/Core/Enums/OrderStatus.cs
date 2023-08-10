namespace Core.Enums;

/// <summary>
/// Статусы заказа
/// </summary>
public enum OrderStatus
{
    /// <summary>
    /// Новый
    /// </summary>
    New,
    
    /// <summary>
    /// В процессе
    /// </summary>
    InProcess,
    
    /// <summary>
    /// Завершен
    /// </summary>
    Finished,
    
    /// <summary>
    /// Оплачен
    /// </summary>
    Paid
}