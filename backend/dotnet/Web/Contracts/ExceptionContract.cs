namespace Web.Contracts;

/// <summary>
/// Контракт для исключений
/// </summary>
public class ExceptionContract
{
    /// <summary>
    /// Тип
    /// </summary>
    public string Type { get; set; }

    /// <summary>
    /// Сообщение
    /// </summary>
    public string Message { get; set; }

    /// <inheritdoc cref="ExceptionContract"/>
    public ExceptionContract(string type, string message)
    {
        Type = type;
        Message = message;
    }
}
