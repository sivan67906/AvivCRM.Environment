using AvivCRM.Environment.Application.Services;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AvivCRM.Environment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeadSourceController : ControllerBase
    {
        private readonly IGenericRepository<LeadSource> _leadsourceRepository;
        private readonly ILeadSourceService _leadsourceService;

        public LeadSourceController(IGenericRepository<LeadSource> leadsourceRepository, ILeadSourceService leadsourceService)
        {
            _leadsourceRepository = leadsourceRepository;
            _leadsourceService = leadsourceService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var products = await _leadsourceRepository.GetAllAsync();
            if (products is null) return NotFound();
            return Ok(products);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid Id)
        {
            var product = await _leadsourceRepository.GetByIdAsync(Id);
            if (product is null) return NotFound();
            return Ok(product);
        }

        [HttpGet("{LeadStatus:required}")]
        public async Task<IActionResult> GetByName(string productName)
        {
            var product = await _leadsourceService.GetByLeadSourceNameAsync(productName);
            if (product is null) return NotFound();
            return Ok(product);
        }

        [HttpGet("SearchByName")]
        public async Task<IActionResult> SearchByName(string name)
        {
            var products = await _leadsourceService.SearchLeadSourceByNameAsync(name);
            if (products is null || !products.Any()) return NotFound("Searchable Lead not found.");
            return Ok(products);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(LeadSource entity)
        {
            if (entity == null) return BadRequest();
            await _leadsourceRepository.CreateAsync(entity);
            return CreatedAtAction(nameof(GetById), new { id = entity.Id }, entity);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> UpdateProduct(LeadSource product)
        {
            await _leadsourceRepository.UpdateAsync(product);
            return NoContent();
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> DeleteProduct(Guid id)
        {
            //var existingProduct = await _leadsourceRepository.GetByIdAsync(id);
            if (id == null) return NotFound();
            await _leadsourceRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
