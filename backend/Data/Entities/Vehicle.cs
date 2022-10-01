using Data.Entities.Base;

namespace Data.Entities;

/// <summary>
/// ТС
/// </summary>
public class Vehicle : EntityBase
{
    /// <summary>
    /// Идентификатор марки ТС
    /// </summary>
    public long VehicleModelId { get; set; }
    
    /// <summary>
    /// Марка ТС
    /// </summary>
    public VehicleModel Model { get; set; }
}