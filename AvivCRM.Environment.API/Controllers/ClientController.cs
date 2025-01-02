using AvivCRM.Environment.Application.Features.Clients.CreateClient;
using AvivCRM.Environment.Application.Features.Clients.DeleteClient;
using AvivCRM.Environment.Application.Features.Clients.GetAllClients;
using AvivCRM.Environment.Application.Features.Clients.GetClientById;
using AvivCRM.Environment.Application.Features.Clients.UpdateClient;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AvivCRM.Environment.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ClientController : ControllerBase
{
    private readonly ISender _sender;
    public ClientController(ISender sender) => _sender = sender;


    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var product = await _sender.Send(new GetClientByIdQuery { Id = Id });
        if (product is not null) { return Ok(product); }
        return NotFound();
    }


    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateClientCommand command)
    {
        await _sender.Send(command);
        return Ok("Clients Created Successfully.");
    }


    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateClientCommand command)
    {
        await _sender.Send(command);
        return NoContent();
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var consumerList = await _sender.Send(new GetAllClientsQuery());
        return Ok(consumerList);
    }


    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _sender.Send(new DeleteClientCommand { Id = Id });
        return NoContent();
    }
}
