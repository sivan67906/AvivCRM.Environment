using AvivCRM.Environment.Application.Features.Cities.CreateCity;
using AvivCRM.Environment.Application.Features.Cities.DeleteCity;
using AvivCRM.Environment.Application.Features.Cities.GetAllCities;
using AvivCRM.Environment.Application.Features.Cities.GetCitiesByParentId;
using AvivCRM.Environment.Application.Features.Cities.GetCityById;
using AvivCRM.Environment.Application.Features.Cities.UpdateCity;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AvivCRM.Environment.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CityController : ControllerBase
{
    private readonly ISender _sender;
    public CityController(ISender sender) => _sender = sender;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var cityList = await _sender.Send(new GetAllCitiesQuery());
        return Ok(cityList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var city = await _sender.Send(new GetCityByIdQuery { Id = Id });
        if (city is not null) { return Ok(city); }
        return NotFound();
    }
    [HttpGet("GetByParentId")]
    public async Task<IActionResult> GetByParentId(Guid parentId)
    {
        var state = await _sender.Send(new GetCitiesByParentIdQuery { StateId = parentId });
        if (state is not null) { return Ok(state); }
        return NotFound();
    }
    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateCityCommand command)
    {
        await _sender.Send(command);
        return Ok("Cities Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateCityCommand command)
    {
        await _sender.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _sender.Send(new DeleteCityCommand { Id = Id });
        return NoContent();
    }
}

