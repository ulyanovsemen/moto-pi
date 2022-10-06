using System.ComponentModel;

namespace Web.Contracts;

/// <summary>
/// Контракт для создания ТС
/// </summary>
public record VehicleCreateContract
{
    /// <summary>
    /// Идентификатор марки ТС
    /// </summary>
    [DefaultValue(null)]
    public long? VehicleModelId { get; init; }
    
    /// <summary>
    /// Для создания новой марки ТС
    /// </summary>
    public VehicleModelCreateContract NewModel { get; init; }
}