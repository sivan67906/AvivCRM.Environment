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
    private readonly IMediator _mediator;
    public DesignationController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var designationList = await _mediator.Send(new GetAllDesignationsQuery());
        return Ok(designationList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var designation = await _mediator.Send(new GetDesignationByIdQuery { Id = Id });
        if (designation is not null) { return Ok(designation); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateDesignationCommand command)
    {
        await _mediator.Send(command);
        return Ok("Designations Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateDesignationCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _mediator.Send(new DeleteDesignationCommand { Id = Id });
        return NoContent();
    }
}


