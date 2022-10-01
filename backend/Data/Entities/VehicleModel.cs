using Data.Entities.Base;

namespace Data.Entities;

/// <summary>
/// Марка ТС
/// </summary>
public class VehicleModel : DictionaryEntityBase
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