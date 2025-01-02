using AvivCRM.Environment.Application.Features.AttendanceSettings.CreateAttendanceSetting;
using AvivCRM.Environment.Application.Features.AttendanceSettings.DeleteAttendanceSetting;
using AvivCRM.Environment.Application.Features.AttendanceSettings.GetAllAttendanceSettings;
using AvivCRM.Environment.Application.Features.AttendanceSettings.GetAttendanceSettingById;
using AvivCRM.Environment.Application.Features.AttendanceSettings.UpdateAttendanceSetting;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AvivCRM.Environment.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AttendanceSettingController : ControllerBase
{
    private readonly ISender _sender;
    public AttendanceSettingController(ISender sender) => _sender = sender;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var attendanceSettingList = await _sender.Send(new GetAllAttendanceSettingsQuery());
        return Ok(attendanceSettingList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var attendanceSetting = await _sender.Send(new GetAttendanceSettingByIdQuery { Id = Id });
        if (attendanceSetting is not null) { return Ok(attendanceSetting); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateAttendanceSettingCommand command)
    {
        await _sender.Send(command);
        return Ok("AttendanceSettings Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateAttendanceSettingCommand command)
    {
        await _sender.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _sender.Send(new DeleteAttendanceSettingCommand { Id = Id });
        return NoContent();
    }
}






























