using System.ComponentModel;
using Web.Contracts.Base;

namespace Web.Contracts;

/// <summary>
/// Контракт создания марки ТС
/// </summary>
public record VehicleModelCreateContract : DictionaryCreateContractBase
{
    /// <summary>
    /// Идентификатор производителя
    /// </summary>
    [DefaultValue(null)]
    public long? ManufacturerId { get; init; }

    /// <summary>
    /// Для создания нового производителя
    /// </summary>
    public ManufacturerCreateContract NewManufacturer { get; init; }
}