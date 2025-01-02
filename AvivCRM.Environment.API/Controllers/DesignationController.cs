using AvivCRM.Environment.Application.Features.Designations.CreateDesignation;
using AvivCRM.Environment.Application.Features.Designations.DeleteDesignation;
using AvivCRM.Environment.Application.Features.Designations.GetAllDesignations;
using AvivCRM.Environment.Application.Features.Designations.GetDesignationById;
using AvivCRM.Environment.Application.Features.Designations.UpdateDesignation;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AvivCRM.Environment.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DesignationController : ControllerBase
{
    private readonly ISender _sender;
    public DesignationController(ISender sender) => _sender = sender;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var designationList = await _sender.Send(new GetAllDesignationsQuery());
        return Ok(designationList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var designation = await _sender.Send(new GetDesignationByIdQuery { Id = Id });
        if (designation is not null) { return Ok(designation); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateDesignationCommand command)
    {
        await _sender.Send(command);
        return Ok("Designations Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateDesignationCommand command)
    {
        await _sender.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _sender.Send(new DeleteDesignationCommand { Id = Id });
        return NoContent();
    }
}


