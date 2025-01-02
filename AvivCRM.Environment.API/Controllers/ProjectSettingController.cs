using MediatR;
using Microsoft.AspNetCore.Mvc;
using AvivCRM.Environment.Application.Features.ProjectSettings.DeleteProjectSetting;
using AvivCRM.Environment.Application.Features.ProjectSettings.GetAllProjectSettings;
using AvivCRM.Environment.Application.Features.ProjectSettings.GetProjectSettingById;
using AvivCRM.Environment.Application.Features.ProjectSettings.CreateProjectSetting;
using AvivCRM.Environment.Application.Features.ProjectSettings.UpdateProjectSetting;

namespace AvivCRM.Environment.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProjectSettingController : ControllerBase
{
    private readonly ISender _sender;
    public ProjectSettingController(ISender sender) => _sender = sender;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var projectSettingList = await _sender.Send(new GetAllProjectSettingsQuery());
        return Ok(projectSettingList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var projectSetting = await _sender.Send(new GetProjectSettingByIdQuery { Id = Id });
        if (projectSetting is not null) { return Ok(projectSetting); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateProjectSettingCommand command)
    {
        await _sender.Send(command);
        return Ok("ProjectSettings Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateProjectSettingCommand command)
    {
        await _sender.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _sender.Send(new DeleteProjectSettingCommand { Id = Id });
        return NoContent();
    }
}










