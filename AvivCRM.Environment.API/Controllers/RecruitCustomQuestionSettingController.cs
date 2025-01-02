using MediatR;
using Microsoft.AspNetCore.Mvc;
using AvivCRM.Environment.Application.Features.RecruitCustomQuestionSettings.DeleteRecruitCustomQuestionSetting;
using AvivCRM.Environment.Application.Features.RecruitCustomQuestionSettings.GetAllRecruitCustomQuestionSettings;
using AvivCRM.Environment.Application.Features.RecruitCustomQuestionSettings.GetRecruitCustomQuestionSettingById;
using AvivCRM.Environment.Application.Features.RecruitCustomQuestionSettings.CreateRecruitCustomQuestionSetting;
using AvivCRM.Environment.Application.Features.RecruitCustomQuestionSettings.UpdateRecruitCustomQuestionSetting;

namespace AvivCRM.Environment.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RecruitCustomQuestionSettingController : ControllerBase
{
    private readonly IMediator _mediator;
    public RecruitCustomQuestionSettingController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var recruitCustomQuestionSettingList = await _mediator.Send(new GetAllRecruitCustomQuestionSettingsQuery());
        return Ok(recruitCustomQuestionSettingList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var recruitCustomQuestionSetting = await _mediator.Send(new GetRecruitCustomQuestionSettingByIdQuery { Id = Id });
        if (recruitCustomQuestionSetting is not null) { return Ok(recruitCustomQuestionSetting); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateRecruitCustomQuestionSettingCommand command)
    {
        await _mediator.Send(command);
        return Ok("RecruitCustomQuestionSettings Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateRecruitCustomQuestionSettingCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _mediator.Send(new DeleteRecruitCustomQuestionSettingCommand { Id = Id });
        return NoContent();
    }
}









