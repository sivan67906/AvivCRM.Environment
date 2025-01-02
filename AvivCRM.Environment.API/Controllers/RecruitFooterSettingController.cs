using MediatR;
using Microsoft.AspNetCore.Mvc;
using AvivCRM.Environment.Application.Features.RecruitFooterSettings.DeleteRecruitFooterSetting;
using AvivCRM.Environment.Application.Features.RecruitFooterSettings.GetAllRecruitFooterSettings;
using AvivCRM.Environment.Application.Features.RecruitFooterSettings.GetRecruitFooterSettingById;
using AvivCRM.Environment.Application.Features.RecruitFooterSettings.CreateRecruitFooterSetting;
using AvivCRM.Environment.Application.Features.RecruitFooterSettings.UpdateRecruitFooterSetting;

namespace AvivCRM.Environment.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RecruitFooterSettingController : ControllerBase
{
    private readonly IMediator _mediator;
    public RecruitFooterSettingController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var recruitFooterSettingList = await _mediator.Send(new GetAllRecruitFooterSettingsQuery());
        return Ok(recruitFooterSettingList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var recruitFooterSetting = await _mediator.Send(new GetRecruitFooterSettingByIdQuery { Id = Id });
        if (recruitFooterSetting is not null) { return Ok(recruitFooterSetting); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateRecruitFooterSettingCommand command)
    {
        await _mediator.Send(command);
        return Ok("RecruitFooterSettings Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateRecruitFooterSettingCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _mediator.Send(new DeleteRecruitFooterSettingCommand { Id = Id });
        return NoContent();
    }
}














