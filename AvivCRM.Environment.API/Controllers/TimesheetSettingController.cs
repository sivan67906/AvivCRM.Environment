using MediatR;
using Microsoft.AspNetCore.Mvc;
using AvivCRM.Environment.Application.Features.TimesheetSettings.DeleteTimesheetSetting;
using AvivCRM.Environment.Application.Features.TimesheetSettings.GetAllTimesheetSettings;
using AvivCRM.Environment.Application.Features.TimesheetSettings.GetTimesheetSettingById;
using AvivCRM.Environment.Application.Features.TimesheetSettings.CreateTimesheetSetting;
using AvivCRM.Environment.Application.Features.TimesheetSettings.UpdateTimesheetSetting;

namespace AvivCRM.Environment.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TimesheetSettingController : ControllerBase
{
    private readonly IMediator _mediator;
    public TimesheetSettingController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var timesheetSettingList = await _mediator.Send(new GetAllTimesheetSettingsQuery());
        return Ok(timesheetSettingList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var timesheetSetting = await _mediator.Send(new GetTimesheetSettingByIdQuery { Id = Id });
        if (timesheetSetting is not null) { return Ok(timesheetSetting); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateTimesheetSettingCommand command)
    {
        await _mediator.Send(command);
        return Ok("TimesheetSettings Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateTimesheetSettingCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _mediator.Send(new DeleteTimesheetSettingCommand { Id = Id });
        return NoContent();
    }
}


























