using Data.Entities.Base;

namespace Data.Entities;

/// <summary>
/// Марка запчасти
/// </summary>
public class PartModel : DictionaryEntityBase
{
    /// <summary>
    /// Идентификатор производителя
    /// </summary>
    public long ManufacturerId { get; set; }

    /// <summary>
    /// Производитель
    /// </summary>
    public Manufacturer Manufacturer { get; set; }
}