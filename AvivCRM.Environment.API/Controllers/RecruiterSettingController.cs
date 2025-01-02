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
    private readonly ISender _sender;
    public RecruiterSettingController(ISender sender) => _sender = sender;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var recruiterSettingList = await _sender.Send(new GetAllRecruiterSettingsQuery());
        return Ok(recruiterSettingList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var recruiterSetting = await _sender.Send(new GetRecruiterSettingByIdQuery { Id = Id });
        if (recruiterSetting is not null) { return Ok(recruiterSetting); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateRecruiterSettingCommand command)
    {
        await _sender.Send(command);
        return Ok("RecruiterSettings Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateRecruiterSettingCommand command)
    {
        await _sender.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _sender.Send(new DeleteRecruiterSettingCommand { Id = Id });
        return NoContent();
    }
}










