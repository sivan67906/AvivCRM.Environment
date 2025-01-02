using MediatR;
using Microsoft.AspNetCore.Mvc;
using AvivCRM.Environment.Application.Features.TicketAgents.DeleteTicketAgent;
using AvivCRM.Environment.Application.Features.TicketAgents.GetAllTicketAgents;
using AvivCRM.Environment.Application.Features.TicketAgents.GetTicketAgentById;
using AvivCRM.Environment.Application.Features.TicketAgents.CreateTicketAgent;
using AvivCRM.Environment.Application.Features.TicketAgents.UpdateTicketAgent;

namespace AvivCRM.Environment.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TicketAgentController : ControllerBase
{
    private readonly ISender _sender;
    public TicketAgentController(ISender sender) => _sender = sender;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var ticketAgentList = await _sender.Send(new GetAllTicketAgentsQuery());
        return Ok(ticketAgentList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var ticketAgent = await _sender.Send(new GetTicketAgentByIdQuery { Id = Id });
        if (ticketAgent is not null) { return Ok(ticketAgent); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateTicketAgentCommand command)
    {
        await _sender.Send(command);
        return Ok("TicketAgents Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateTicketAgentCommand command)
    {
        await _sender.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _sender.Send(new DeleteTicketAgentCommand { Id = Id });
        return NoContent();
    }
}






























