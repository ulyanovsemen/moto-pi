using Application.Common.Dto;

namespace Application.Orders.Dto;

/// <summary>
/// DTO создания марки ТС
/// </summary>
public record VehicleModelCreateDto : DictionaryCreateDtoBase
{
    /// <summary>
    /// Идентификатор производителя
    /// </summary>
    public long? ManufacturerId { get; init; }

    /// <summary>
    /// Для создания нового производителя
    /// </summary>
    public ManufacturerCreateDto NewManufacturer { get; init; }
}