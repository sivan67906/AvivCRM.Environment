using MediatR;
using Microsoft.AspNetCore.Mvc;
using AvivCRM.Environment.Application.Features.TicketGroups.DeleteTicketGroup;
using AvivCRM.Environment.Application.Features.TicketGroups.GetAllTicketGroups;
using AvivCRM.Environment.Application.Features.TicketGroups.GetTicketGroupById;
using AvivCRM.Environment.Application.Features.TicketGroups.CreateTicketGroup;
using AvivCRM.Environment.Application.Features.TicketGroups.UpdateTicketGroup;

namespace AvivCRM.Environment.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TicketGroupController : ControllerBase
{
    private readonly IMediator _mediator;
    public TicketGroupController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var ticketGroupList = await _mediator.Send(new GetAllTicketGroupsQuery());
        return Ok(ticketGroupList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var ticketGroup = await _mediator.Send(new GetTicketGroupByIdQuery { Id = Id });
        if (ticketGroup is not null) { return Ok(ticketGroup); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateTicketGroupCommand command)
    {
        await _mediator.Send(command);
        return Ok("TicketGroups Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateTicketGroupCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _mediator.Send(new DeleteTicketGroupCommand { Id = Id });
        return NoContent();
    }
}






























