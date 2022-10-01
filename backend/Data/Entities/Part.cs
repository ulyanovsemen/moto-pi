using Data.Entities.Base;

namespace Data.Entities;

/// <summary>
/// Запчасть
/// </summary>
public class Part : DictionaryEntityBase
{
    /// <summary>
    /// Ссылка на тип запчасти
    /// </summary>
    public long PartTypeId { get; set; }
    
    /// <summary>
    /// Тип запчасти
    /// </summary>
    public PartType Type { get; set; }

    /// <summary>
    /// Идентификатор марки запчасти
    /// </summary>
    public long PartModelId { get; set; }
    
    /// <summary>
    /// Марка запчасти
    /// </summary>
    public PartModel Model { get; set; }
    
    /// <summary>
    /// Номер
    /// </summary>
    public string Number { get; set; }
}