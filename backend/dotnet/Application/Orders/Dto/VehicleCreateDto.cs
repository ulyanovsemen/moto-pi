namespace Application.Orders.Dto;

/// <summary>
/// DTO для создания ТС
/// </summary>
public record VehicleCreateDto
{
    /// <summary>
    /// Идентификатор марки ТС
    /// </summary>
    public long? VehicleModelId { get; init; }
    
    /// <summary>
    /// Для создания новой марки ТС
    /// </summary>
    public VehicleModelCreateDto NewModel { get; init; }
}