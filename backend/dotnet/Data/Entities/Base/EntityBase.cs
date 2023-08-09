namespace Data.Entities.Base;

/// <summary>
/// Базовый класс всех сущностей
/// </summary>
public abstract class EntityBase
{
    /// <summary>
    /// Идентификатор записи
    /// </summary>
    public long Id { get; set; }
}