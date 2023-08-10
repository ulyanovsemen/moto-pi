namespace Web.Contracts.Base;

/// <summary>
/// Базовый контракт для создания словарей
/// </summary>
public abstract record DictionaryCreateContractBase
{
    /// <summary>
    /// Наименование
    /// </summary>
    public string Name { get; init; }
}