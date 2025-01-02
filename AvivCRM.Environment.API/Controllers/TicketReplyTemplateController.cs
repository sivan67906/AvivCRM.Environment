using MediatR;
using Microsoft.AspNetCore.Mvc;
using AvivCRM.Environment.Application.Features.TicketReplyTemplates.DeleteTicketReplyTemplate;
using AvivCRM.Environment.Application.Features.TicketReplyTemplates.GetAllTicketReplyTemplates;
using AvivCRM.Environment.Application.Features.TicketReplyTemplates.GetTicketReplyTemplateById;
using AvivCRM.Environment.Application.Features.TicketReplyTemplates.CreateTicketReplyTemplate;
using AvivCRM.Environment.Application.Features.TicketReplyTemplates.UpdateTicketReplyTemplate;

namespace AvivCRM.Environment.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TicketReplyTemplateController : ControllerBase
{
    private readonly ISender _sender;
    public TicketReplyTemplateController(ISender sender) => _sender = sender;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var ticketReplyTemplateList = await _sender.Send(new GetAllTicketReplyTemplatesQuery());
        return Ok(ticketReplyTemplateList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var ticketReplyTemplate = await _sender.Send(new GetTicketReplyTemplateByIdQuery { Id = Id });
        if (ticketReplyTemplate is not null) { return Ok(ticketReplyTemplate); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateTicketReplyTemplateCommand command)
    {
        await _sender.Send(command);
        return Ok("TicketReplyTemplates Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateTicketReplyTemplateCommand command)
    {
        await _sender.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _sender.Send(new DeleteTicketReplyTemplateCommand { Id = Id });
        return NoContent();
    }
}






























