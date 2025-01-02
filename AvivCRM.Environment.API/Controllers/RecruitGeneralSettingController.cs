using MediatR;
using Microsoft.AspNetCore.Mvc;
using AvivCRM.Environment.Application.Features.RecruitGeneralSettings.DeleteRecruitGeneralSetting;
using AvivCRM.Environment.Application.Features.RecruitGeneralSettings.GetAllRecruitGeneralSettings;
using AvivCRM.Environment.Application.Features.RecruitGeneralSettings.GetRecruitGeneralSettingById;
using AvivCRM.Environment.Application.Features.RecruitGeneralSettings.CreateRecruitGeneralSetting;
using AvivCRM.Environment.Application.Features.RecruitGeneralSettings.UpdateRecruitGeneralSetting;

namespace AvivCRM.Environment.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RecruitGeneralSettingController : ControllerBase
{
    private readonly ISender _sender;
    public RecruitGeneralSettingController(ISender sender) => _sender = sender;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var recruitGeneralSettingList = await _sender.Send(new GetAllRecruitGeneralSettingsQuery());
        return Ok(recruitGeneralSettingList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var recruitGeneralSetting = await _sender.Send(new GetRecruitGeneralSettingByIdQuery { Id = Id });
        if (recruitGeneralSetting is not null) { return Ok(recruitGeneralSetting); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateRecruitGeneralSettingCommand command)
    {
        await _sender.Send(command);
        return Ok("RecruitGeneralSettings Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateRecruitGeneralSettingCommand command)
    {
        await _sender.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _sender.Send(new DeleteRecruitGeneralSettingCommand { Id = Id });
        return NoContent();
    }
}














