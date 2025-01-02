using MediatR;
using Microsoft.AspNetCore.Mvc;
using AvivCRM.Environment.Application.Features.Clients.CreateClient;
using AvivCRM.Environment.Application.Features.Clients.DeleteClient;
using AvivCRM.Environment.Application.Features.Clients.UpdateClient;
using AvivCRM.Environment.Application.Features.Clients.GetAllClients;
using AvivCRM.Environment.Application.Features.Clients.GetClientById;
using AvivCRM.Environment.Application.Features.Taxes.DeleteTax;
using AvivCRM.Environment.Application.Features.Taxes.GetAllTax;
using AvivCRM.Environment.Application.Features.Taxes.GetTaxById;
using AvivCRM.Environment.Application.Features.Taxes.CreateTax;
using AvivCRM.Environment.Application.Features.Taxes.UpdateTax;

namespace AvivCRM.Environment.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TaxController : ControllerBase
{
    private readonly ISender _sender;
    public TaxController(ISender sender) => _sender = sender;


    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var product = await _sender.Send(new GetTaxByIdQuery { Id = Id });
        if (product is not null) { return Ok(product); }
        return NotFound();
    }


    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateTaxCommand command)
    {
        var id = await _sender.Send(command);
        return CreatedAtAction(nameof(GetById), new { id }, command);
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateTaxCommand command)
    {
        await _sender.Send(command);
        return NoContent();
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var consumerList = await _sender.Send(new GetAllTaxQuery());
        return Ok(consumerList);
    }


    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _sender.Send(new DeleteTaxCommand { Id = Id });
        return NoContent();
    }
}
