using MediatR;
using Microsoft.AspNetCore.Mvc;
using AvivCRM.Environment.Application.Features.JobApplicationPositions.DeleteJobApplicationPosition;
using AvivCRM.Environment.Application.Features.JobApplicationPositions.GetAllJobApplicationPositions;
using AvivCRM.Environment.Application.Features.JobApplicationPositions.GetJobApplicationPositionById;
using AvivCRM.Environment.Application.Features.JobApplicationPositions.CreateJobApplicationPosition;
using AvivCRM.Environment.Application.Features.JobApplicationPositions.UpdateJobApplicationPosition;

namespace AvivCRM.Environment.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class JobApplicationPositionController : ControllerBase
{
    private readonly ISender _sender;
    public JobApplicationPositionController(ISender sender) => _sender = sender;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var jobApplicationPositionList = await _sender.Send(new GetAllJobApplicationPositionsQuery());
        return Ok(jobApplicationPositionList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var jobApplicationPosition = await _sender.Send(new GetJobApplicationPositionByIdQuery { Id = Id });
        if (jobApplicationPosition is not null) { return Ok(jobApplicationPosition); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateJobApplicationPositionCommand command)
    {
        await _sender.Send(command);
        return Ok("JobApplicationPositions Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateJobApplicationPositionCommand command)
    {
        await _sender.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _sender.Send(new DeleteJobApplicationPositionCommand { Id = Id });
        return NoContent();
    }
}














