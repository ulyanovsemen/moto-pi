namespace Web.Contracts;

/// <summary>
/// Контракт для справочников
/// </summary>
public class DictionaryContract
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// Наименование
    /// </summary>
    public string Name { get; set; }
}