using MediatR;
using Microsoft.AspNetCore.Mvc;
using AvivCRM.Environment.Application.Features.TicketChannels.DeleteTicketChannel;
using AvivCRM.Environment.Application.Features.TicketChannels.GetAllTicketChannels;
using AvivCRM.Environment.Application.Features.TicketChannels.GetTicketChannelById;
using AvivCRM.Environment.Application.Features.TicketChannels.CreateTicketChannel;
using AvivCRM.Environment.Application.Features.TicketChannels.UpdateTicketChannel;

namespace AvivCRM.Environment.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TicketChannelController : ControllerBase
{
    private readonly ISender _sender;
    public TicketChannelController(ISender sender) => _sender = sender;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var ticketChannelList = await _sender.Send(new GetAllTicketChannelsQuery());
        return Ok(ticketChannelList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var ticketChannel = await _sender.Send(new GetTicketChannelByIdQuery { Id = Id });
        if (ticketChannel is not null) { return Ok(ticketChannel); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateTicketChannelCommand command)
    {
        await _sender.Send(command);
        return Ok("TicketChannels Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateTicketChannelCommand command)
    {
        await _sender.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _sender.Send(new DeleteTicketChannelCommand { Id = Id });
        return NoContent();
    }
}






























