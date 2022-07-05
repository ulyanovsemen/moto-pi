using Data.Entities.Base;

namespace Data.Entities;

/// <summary>
/// Работа
/// </summary>
public class Work : DictionaryEntityBase
{
    /// <summary>
    /// Ссылка на вид работ
    /// </summary>
    public long WorkTypeId { get; set; }

    /// <summary>
    /// Вид работ
    /// </summary>
    public WorkType Type { get; set; }
}