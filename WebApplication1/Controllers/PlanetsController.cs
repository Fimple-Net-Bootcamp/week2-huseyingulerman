using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using week2_huseyingulerman.Core.DTOs;
using week2_huseyingulerman.Core.DTOs.Create;
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
        [HttpGet("{id}/Weather")]
        public async Task<IActionResult> GetById(int id)
        {
            var planet = await _planetService.GetByIdAsync(id);
            return Ok(planet.Data);
        }
        [HttpPost("/Create/Weather")]
        public async Task<IActionResult> Create(PlanetsCreateDTO planetsCreateDTO)
        {
            var planet=await _planetService.AddAsync(planetsCreateDTO);
            return CreatedAtAction(nameof(GetById), new { id = planet.Data.Id }, planet);
        }
        [HttpDelete("/Delete/Planet/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var planet=await _planetService.RemoveAsync(id);
            return Ok(planet.StatusCode);
        }
        [HttpPut("/Update/Weather{id}")]
        public async Task<IActionResult> Update(int id,PlanetsCreateDTO planets)
        {
            var _planet = await _planetService.GetByIdAsync(id);
            var _planetMapper = _mapper.Map<PlanetsCreateDTO>(_planet);

           var planet= await _planetService.UpdateAsync(_planetMapper);

            return Ok(planet.StatusCode);
        }
    }
}
