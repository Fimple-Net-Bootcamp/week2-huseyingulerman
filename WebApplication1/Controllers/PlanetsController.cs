using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using week2_huseyingulerman.Core.DTOs;
using week2_huseyingulerman.Core.DTOs.Create;
using week2_huseyingulerman.Core.DTOs.Uptade;
using week2_huseyingulerman.Core.Enums;
using week2_huseyingulerman.Core.Services;
using week2_huseyingulerman.Core.VMs;
using X.PagedList;

namespace week2_huseyingulerman.Api.Controllers
{
    [Route("api/v1/planets")]
    [ApiController]
    public class PlanetsController : ControllerBase
    {
      
        private readonly IPlanetService _planetService;
        public PlanetsController(IPlanetService plantservice)
        {
            _planetService=plantservice;
          
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(int page=1,int pagesize=5, Arrangement sort= Arrangement.IdLowToHigh)
        {
            var planets=await _planetService.GetAllActiveAsync(sort);
            return Ok(planets.Data.ToPagedList(page, pagesize));

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var planet = await _planetService.GetByIdAsync(id);
            return Ok(planet.Data);
        }
        [HttpPost]
        public async Task<IActionResult> Create(PlanetsCreateDTO planetsCreateDTO)
        {
            var planet=await _planetService.AddAsync(planetsCreateDTO);
            return CreatedAtAction(nameof(GetById), new { id = planet.Data.Id }, planet);
        }
        [HttpDelete("/planet/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var planet=await _planetService.RemoveAsync(id);
            return StatusCode(planet.StatusCode);
        }
        [HttpPut]
        public async Task<IActionResult> Update(PlanetsUpdateDTO planets)
        {
           var planet= await _planetService.UpdateAsync(planets);

            return Ok(planet.StatusCode);
        }
    }
}
