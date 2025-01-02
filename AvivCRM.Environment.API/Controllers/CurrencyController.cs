using AvivCRM.Environment.Application.Features.Currencies.CreateCurrency;
using AvivCRM.Environment.Application.Features.Currencies.DeleteCurrency;
using AvivCRM.Environment.Application.Features.Currencies.GetAllCurrencies;
using AvivCRM.Environment.Application.Features.Currencies.GetCurrencyById;
using AvivCRM.Environment.Application.Features.Currencies.UpdateCurrency;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AvivCRM.Environment.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CurrencyController : ControllerBase
{
    private readonly ISender _sender;
    public CurrencyController(ISender sender) => _sender = sender;


    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var product = await _sender.Send(new GetCurrencyByIdQuery { Id = Id });
        if (product is not null) { return Ok(product); }
        return NotFound();
    }


    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateCurrencyCommand command)
    {
        var id = await _sender.Send(command);
        return CreatedAtAction(nameof(GetById), new { id }, command);
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateCurrencyCommand command)
    {
        await _sender.Send(command);
        return NoContent();
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var consumerList = await _sender.Send(new GetAllCurrencyQuery());
        return Ok(consumerList);
    }


    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _sender.Send(new DeleteCurrencyCommand { Id = Id });
        return NoContent();
    }
}
