namespace Web.Contracts;

/// <summary>
/// Контракт для запчасти
/// </summary>
public class PartContract : DictionaryContract
{
    /// <summary>
    /// Тип запчасти
    /// </summary>
    public DictionaryContract Type { get; set; }

    /// <summary>
    /// Модель
    /// </summary>
    public string Model { get; set; }

    /// <summary>
    /// Номер
    /// </summary>
    public string Number { get; set; }
}