namespace Application.Orders.Dto;

public record PersonCreateDto
{
    /// <summary>
    /// ФИО
    /// </summary>
    public string Fio { get; set; }

    /// <summary>
    /// Телефон
    /// </summary>
    public string TelNumber { get; set; }
}