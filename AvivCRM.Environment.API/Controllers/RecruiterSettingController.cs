using MediatR;
using Microsoft.AspNetCore.Mvc;
using AvivCRM.Environment.Application.Features.RecruiterSettings.DeleteRecruiterSetting;
using AvivCRM.Environment.Application.Features.RecruiterSettings.GetAllRecruiterSettings;
using AvivCRM.Environment.Application.Features.RecruiterSettings.GetRecruiterSettingById;
using AvivCRM.Environment.Application.Features.RecruiterSettings.CreateRecruiterSetting;
using AvivCRM.Environment.Application.Features.RecruiterSettings.UpdateRecruiterSetting;

namespace AvivCRM.Environment.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RecruiterSettingController : ControllerBase
{
    private readonly IMediator _mediator;
    public RecruiterSettingController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var recruiterSettingList = await _mediator.Send(new GetAllRecruiterSettingsQuery());
        return Ok(recruiterSettingList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var recruiterSetting = await _mediator.Send(new GetRecruiterSettingByIdQuery { Id = Id });
        if (recruiterSetting is not null) { return Ok(recruiterSetting); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateRecruiterSettingCommand command)
    {
        await _mediator.Send(command);
        return Ok("RecruiterSettings Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateRecruiterSettingCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _mediator.Send(new DeleteRecruiterSettingCommand { Id = Id });
        return NoContent();
    }
}










