namespace Application.Orders.Dto;

/// <summary>
/// DTO создания заказа
/// </summary>
public record OrderCreateDto
{
    /// <summary>
    /// VIN
    /// </summary>
    public string Vin { get; init; }

    /// <summary>
    /// Номер
    /// </summary>
    public string Number { get; init; }
    
    /// <summary>
    /// Идентификатор заказчика
    /// </summary>
    public long? CustomerId { get; init; }

    /// <summary>
    /// Данные для создания нового клиента
    /// </summary>
    public PersonCreateDto NewCustomer { get; init; }
    
    /// <summary>
    /// Идентификатор ТС
    /// </summary>
    public long? VehicleId { get; set; }

    /// <summary>
    /// Данные для создания нового ТС
    /// </summary>
    public VehicleCreateDto NewVehicle { get; init; }
}