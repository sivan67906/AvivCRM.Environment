using AvivCRM.Environment.Application.Features.Countries.CreateCountry;
using AvivCRM.Environment.Application.Features.Countries.DeleteCountry;
using AvivCRM.Environment.Application.Features.Countries.GetAllCountries;
using AvivCRM.Environment.Application.Features.Countries.GetCountryById;
using AvivCRM.Environment.Application.Features.Countries.UpdateCountry;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AvivCRM.Environment.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CountryController : ControllerBase
{
    private readonly ISender _sender;
    public CountryController(ISender sender) => _sender = sender;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var countryList = await _sender.Send(new GetAllCountriesQuery());
        return Ok(countryList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var country = await _sender.Send(new GetCountryByIdQuery { Id = Id });
        if (country is not null) { return Ok(country); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateCountryCommand command)
    {
        await _sender.Send(command);
        return Ok("Countries Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateCountryCommand command)
    {
        await _sender.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _sender.Send(new DeleteCountryCommand { Id = Id });
        return NoContent();
    }
}

