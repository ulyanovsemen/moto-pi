namespace Web.Contracts;

/// <summary>
/// Контракт создания данных о человеке
/// </summary>
public record PersonCreateContract
{
    /// <summary>
    /// ФИО
    /// </summary>
    public string Fio { get; init; }

    /// <summary>
    /// Телефон
    /// </summary>
    public string TelNumber { get; init; }
}