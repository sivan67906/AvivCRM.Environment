using MediatR;
using Microsoft.AspNetCore.Mvc;
using AvivCRM.Environment.Application.Features.RecruitNotificationSettings.DeleteRecruitNotificationSetting;
using AvivCRM.Environment.Application.Features.RecruitNotificationSettings.GetAllRecruitNotificationSettings;
using AvivCRM.Environment.Application.Features.RecruitNotificationSettings.GetRecruitNotificationSettingById;
using AvivCRM.Environment.Application.Features.RecruitNotificationSettings.CreateRecruitNotificationSetting;
using AvivCRM.Environment.Application.Features.RecruitNotificationSettings.UpdateRecruitNotificationSetting;

namespace AvivCRM.Environment.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RecruitNotificationSettingController : ControllerBase
{
    private readonly ISender _sender;
    public RecruitNotificationSettingController(ISender sender) => _sender = sender;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var recruitNotificationSettingList = await _sender.Send(new GetAllRecruitNotificationSettingsQuery());
        return Ok(recruitNotificationSettingList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var recruitNotificationSetting = await _sender.Send(new GetRecruitNotificationSettingByIdQuery { Id = Id });
        if (recruitNotificationSetting is not null) { return Ok(recruitNotificationSetting); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateRecruitNotificationSettingCommand command)
    {
        await _sender.Send(command);
        return Ok("RecruitNotificationSettings Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateRecruitNotificationSettingCommand command)
    {
        await _sender.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _sender.Send(new DeleteRecruitNotificationSettingCommand { Id = Id });
        return NoContent();
    }
}














