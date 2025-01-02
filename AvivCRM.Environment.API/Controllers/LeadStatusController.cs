using AvivCRM.Environment.Application.Services;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AvivCRM.Environment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeadStatusController : ControllerBase
    {
        private readonly IGenericRepository<LeadStatus> _leadStatusRepository;
        private readonly ILeadStatusService _leadStatusService;

        public LeadStatusController(IGenericRepository<LeadStatus> leadStatusRepository, ILeadStatusService leadStatusService)
        {
            _leadStatusRepository = leadStatusRepository;
            _leadStatusService = leadStatusService;
        }


        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var products = await _leadStatusRepository.GetAllAsync();
            if (products is null) return NotFound();
            return Ok(products);
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(Guid Id)
        {
            var product = await _leadStatusRepository.GetByIdAsync(Id);
            if (product is null) return NotFound();
            return Ok(product);
        }

        [HttpGet("{LeadStatus:required}")]
        public async Task<IActionResult> GetByName(string productName)
        {
            var product = await _leadStatusService.GetByLeadStatusNameAsync(productName);
            if (product is null) return NotFound();
            return Ok(product);
        }

        [HttpGet("SearchByName")]
        public async Task<IActionResult> SearchByName(string name)
        {
            var products = await _leadStatusService.SearchLeadStatusByNameAsync(name);
            if (products is null || !products.Any()) return NotFound("Searchable Lead not found.");
            return Ok(products);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(LeadStatus entity)
        {
            if (entity == null) return BadRequest();
            await _leadStatusRepository.CreateAsync(entity);
            return CreatedAtAction(nameof(GetById), new { id = entity.Id }, entity);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> UpdateProduct(LeadStatus product)
        {
            await _leadStatusRepository.UpdateAsync(product);
            return NoContent();
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> DeleteProduct(Guid id)
        {
            //var existingProduct = await _leadStatusRepository.GetByIdAsync(id);
            if (id == null) return NotFound();
            await _leadStatusRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
