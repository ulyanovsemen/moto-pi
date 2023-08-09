namespace Web.Contracts;

/// <summary>
/// Контракт для работ
/// </summary>
public class WorkContract : DictionaryContract
{
    /// <summary>
    /// Вид работ
    /// </summary>
    public DictionaryContract Type { get; set; }
}