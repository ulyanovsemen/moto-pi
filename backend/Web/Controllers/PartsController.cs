using Application.Parts.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Web.Contracts;

namespace Web.Controllers;

/// <summary>
/// Контроллер запчастей
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class PartsController : ControllerBase
{
    private readonly IPartsService _partsService;
    private readonly IMapper _mapper;

    /// <summary>
    /// Контроллер запчастей
    /// </summary>
    public PartsController(IPartsService partsService, IMapper mapper)
    {
        _partsService = partsService;
        _mapper = mapper;
    }
    
    /// <summary>
    /// Получить список запчастей
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<ICollection<PartContract>> GetParts()
    {
        var dtos = await _partsService.GetParts();

        return _mapper.Map<ICollection<PartContract>>(dtos);
    }
}