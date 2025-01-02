using MediatR;
using Microsoft.AspNetCore.Mvc;
using AvivCRM.Environment.Application.Features.TicketTypes.DeleteTicketType;
using AvivCRM.Environment.Application.Features.TicketTypes.GetAllTicketTypes;
using AvivCRM.Environment.Application.Features.TicketTypes.GetTicketTypeById;
using AvivCRM.Environment.Application.Features.TicketTypes.CreateTicketType;
using AvivCRM.Environment.Application.Features.TicketTypes.UpdateTicketType;

namespace AvivCRM.Environment.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TicketTypeController : ControllerBase
{
    private readonly IMediator _mediator;
    public TicketTypeController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var ticketTypeList = await _mediator.Send(new GetAllTicketTypesQuery());
        return Ok(ticketTypeList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var ticketType = await _mediator.Send(new GetTicketTypeByIdQuery { Id = Id });
        if (ticketType is not null) { return Ok(ticketType); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateTicketTypeCommand command)
    {
        await _mediator.Send(command);
        return Ok("TicketTypes Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateTicketTypeCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _mediator.Send(new DeleteTicketTypeCommand { Id = Id });
        return NoContent();
    }
}






























