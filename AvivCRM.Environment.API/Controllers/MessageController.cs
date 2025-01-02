using MediatR;
using Microsoft.AspNetCore.Mvc;
using AvivCRM.Environment.Application.Features.Messages.DeleteMessage;
using AvivCRM.Environment.Application.Features.Messages.GetAllMessage;
using AvivCRM.Environment.Application.Features.Messages.GetMessageById;
using AvivCRM.Environment.Application.Features.Messages.CreateMessage;
using AvivCRM.Environment.Application.Features.Messages.UpdateMessage;

namespace AvivCRM.Environment.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class MessageController : ControllerBase
{
    private readonly ISender _sender;
    public MessageController(ISender sender) => _sender = sender;


    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var product = await _sender.Send(new GetMessageByIdQuery { Id = Id });
        if (product is not null) { return Ok(product); }
        return NotFound();
    }


    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateMessageCommand command)
    {
        var id = await _sender.Send(command);
        return CreatedAtAction(nameof(GetById), new { id }, command);
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateMessageCommand command)
    {
        await _sender.Send(command);
        return NoContent();
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var consumerList = await _sender.Send(new GetAllMessageQuery());
        return Ok(consumerList);
    }


    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _sender.Send(new DeleteMessageCommand { Id = Id });
        return NoContent();
    }
}
