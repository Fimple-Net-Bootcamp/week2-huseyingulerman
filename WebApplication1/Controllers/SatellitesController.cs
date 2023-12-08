using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using week2_huseyingulerman.Core.DTOs.Create;
using week2_huseyingulerman.Core.DTOs.Uptade;
using week2_huseyingulerman.Core.Enums;
using week2_huseyingulerman.Core.Services;
using X.PagedList;

namespace week2_huseyingulerman.Api.Controllers
{
    [Route("api/v1/satellites")]
    [ApiController]
    public class SatellitesController : ControllerBase
    {
       
        private readonly ISatellitesService _satellitesService;
        public SatellitesController( ISatellitesService satellitesService)
        {
            _satellitesService=satellitesService;
           
        }
        [HttpGet]
        public async Task<IActionResult> GetAll(int page = 1, int pagesize = 5, Arrangement sort = Arrangement.IdLowToHigh)
        {
            var satellites = await _satellitesService.GetAllActiveAsync(sort);
            return Ok(satellites.Data.ToPagedList(page, pagesize));

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var satellite = await _satellitesService.GetByIdAsync(id);
            return Ok(satellite.Data);
        }
        [HttpPost]
        public async Task<IActionResult> Create(SatellitesCreateDTO satellitesCreateDTO)
        {
            var satellite = await _satellitesService.AddAsync(satellitesCreateDTO);
            return CreatedAtAction(nameof(GetById), new { id = satellite.Data.Id }, satellite);
        }
        [HttpDelete("/satellite/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var satellite = await _satellitesService.RemoveAsync(id);
            return StatusCode(satellite.StatusCode);
        }
        [HttpPut]
        public async Task<IActionResult> Update(SatellitesUptadeDTO satellite)
        {
            var _satellite = await _satellitesService.UpdateAsync(satellite);

            return Ok(_satellite.StatusCode);
        }
    }
}
