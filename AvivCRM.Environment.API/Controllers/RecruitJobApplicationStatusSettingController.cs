using MediatR;
using Microsoft.AspNetCore.Mvc;
using AvivCRM.Environment.Application.Features.RecruitJobApplicationStatusSettings.DeleteRecruitJobApplicationStatusSetting;
using AvivCRM.Environment.Application.Features.RecruitJobApplicationStatusSettings.GetAllRecruitJobApplicationStatusSettings;
using AvivCRM.Environment.Application.Features.RecruitJobApplicationStatusSettings.GetRecruitJobApplicationStatusSettingById;
using AvivCRM.Environment.Application.Features.RecruitJobApplicationStatusSettings.CreateRecruitJobApplicationStatusSetting;
using AvivCRM.Environment.Application.Features.RecruitJobApplicationStatusSettings.UpdateRecruitJobApplicationStatusSetting;

namespace AvivCRM.Environment.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RecruitJobApplicationStatusSettingController : ControllerBase
{
    private readonly ISender _sender;
    public RecruitJobApplicationStatusSettingController(ISender sender) => _sender = sender;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var recruitJobApplicationStatusSettingList = await _sender.Send(new GetAllRecruitJobApplicationStatusSettingsQuery());
        return Ok(recruitJobApplicationStatusSettingList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var recruitJobApplicationStatusSetting = await _sender.Send(new GetRecruitJobApplicationStatusSettingByIdQuery { Id = Id });
        if (recruitJobApplicationStatusSetting is not null) { return Ok(recruitJobApplicationStatusSetting); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateRecruitJobApplicationStatusSettingCommand command)
    {
        await _sender.Send(command);
        return Ok("RecruitJobApplicationStatusSettings Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateRecruitJobApplicationStatusSettingCommand command)
    {
        await _sender.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _sender.Send(new DeleteRecruitJobApplicationStatusSettingCommand { Id = Id });
        return NoContent();
    }
}










