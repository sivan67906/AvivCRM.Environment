using AvivCRM.Environment.Application.Features.NotificationMains.CreateNotificationMain;
using AvivCRM.Environment.Application.Features.NotificationMains.DeleteNotificationMain;
using AvivCRM.Environment.Application.Features.NotificationMains.GetAllNotificationMains;
using AvivCRM.Environment.Application.Features.NotificationMains.GetNotificationMainById;
using AvivCRM.Environment.Application.Features.NotificationMains.UpdateNotificationMain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AvivCRM.Environment.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class NotificationMainController : ControllerBase
{
    private readonly ISender _sender;
    public NotificationMainController(ISender sender) => _sender = sender;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var notificationMainList = await _sender.Send(new GetAllNotificationMainQuery());
        return Ok(notificationMainList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var notificationMain = await _sender.Send(new GetNotificationMainByIdQuery { Id = Id });
        if (notificationMain is not null) { return Ok(notificationMain); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateNotificationMainCommand command)
    {
        await _sender.Send(command);
        return Ok("NotificationMains Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateNotificationMainCommand command)
    {
        await _sender.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _sender.Send(new DeleteNotificationMainCommand { Id = Id });
        return NoContent();
    }
}


