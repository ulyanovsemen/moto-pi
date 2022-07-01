namespace Data.Entities.Base;

/// <summary>
/// Базовый класс справочной записи
/// </summary>
public class DictionaryBase : EntityBase
{
    /// <summary>
    /// Наименование
    /// </summary>
    public string Name { get; set; }
}