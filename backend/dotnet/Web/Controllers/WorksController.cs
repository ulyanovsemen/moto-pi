using Application.Works.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Web.Contracts;

namespace Web.Controllers
{
    /// <summary>
    /// Контроллер для работ
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class WorksController : ControllerBase
    {
        private readonly IWorksService _worksService;
        private readonly IMapper _mapper;

        /// <summary>
        /// Контроллер для работ
        /// </summary>
        public WorksController(IWorksService worksService, IMapper mapper)
        {
            _worksService = worksService;
            _mapper = mapper;
        }
        
        /// <summary>
        /// Получить список работ
        /// </summary>
        [HttpGet]
        public async Task<ICollection<WorkContract>> GetParts()
        {
            var dtos = await _worksService.GetWorks();

            return _mapper.Map<ICollection<WorkContract>>(dtos);
        }
    }
}
