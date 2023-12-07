using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using week2_huseyingulerman.Core.Services;

namespace week2_huseyingulerman.Api.Controllers
{
    [Route("api/v1/planets")]
    [ApiController]
    public class PlanetsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IPlanetService _planetService;
        public PlanetsController(IMapper mapper,IPlanetService plantservice)
        {
            _planetService=plantservice;
            _mapper=mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var planets=await _planetService.GetAllActiveAsync();
            return Ok(planets.Data);

        }
    }
}
