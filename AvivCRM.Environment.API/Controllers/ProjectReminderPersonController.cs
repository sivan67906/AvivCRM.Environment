using MediatR;
using Microsoft.AspNetCore.Mvc;
using AvivCRM.Environment.Application.Features.ProjectReminderPersons.DeleteProjectReminderPerson;
using AvivCRM.Environment.Application.Features.ProjectReminderPersons.GetAllProjectReminderPersons;
using AvivCRM.Environment.Application.Features.ProjectReminderPersons.GetProjectReminderPersonById;
using AvivCRM.Environment.Application.Features.ProjectReminderPersons.CreateProjectReminderPerson;
using AvivCRM.Environment.Application.Features.ProjectReminderPersons.UpdateProjectReminderPerson;

namespace AvivCRM.Environment.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProjectReminderPersonController : ControllerBase
{
    private readonly ISender _sender;
    public ProjectReminderPersonController(ISender sender) => _sender = sender;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var projectReminderPersonList = await _sender.Send(new GetAllProjectReminderPersonsQuery());
        return Ok(projectReminderPersonList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var projectReminderPerson = await _sender.Send(new GetProjectReminderPersonByIdQuery { Id = Id });
        if (projectReminderPerson is not null) { return Ok(projectReminderPerson); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateProjectReminderPersonCommand command)
    {
        await _sender.Send(command);
        return Ok("ProjectReminderPersons Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateProjectReminderPersonCommand command)
    {
        await _sender.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _sender.Send(new DeleteProjectReminderPersonCommand { Id = Id });
        return NoContent();
    }
}














