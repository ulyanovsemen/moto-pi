using System.ComponentModel;

namespace Web.Contracts;

/// <summary>
/// Контракт для создания заказа
/// </summary>
public record OrderCreateContract
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
    [DefaultValue(null)]
    public long? CustomerId { get; init; }

    /// <summary>
    /// Данные для создания нового клиента
    /// </summary>
    public PersonCreateContract NewCustomer { get; init; }
    
    /// <summary>
    /// Идентификатор ТС
    /// </summary>
    [DefaultValue(null)]
    public long? VehicleId { get; set; }
    
    /// <summary>
    /// Данные для создания нового ТС
    /// </summary>
    public VehicleCreateContract NewVehicle { get; init; }
}