using MediatR;
using Microsoft.AspNetCore.Mvc;
using AvivCRM.Environment.Application.Features.Plannings.DeletePlanning;
using AvivCRM.Environment.Application.Features.Plannings.GetAllPlannings;
using AvivCRM.Environment.Application.Features.Plannings.GetPlanningById;
using AvivCRM.Environment.Application.Features.Plannings.CreatePlanning;
using AvivCRM.Environment.Application.Features.Plannings.UpdatePlanning;

namespace AvivCRM.Environment.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PlanningController : ControllerBase
{
    private readonly ISender _sender;
    public PlanningController(ISender sender) => _sender = sender;


    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var product = await _sender.Send(new GetPlanningByIdQuery { Id = Id });
        if (product is not null) { return Ok(product); }
        return NotFound();
    }


    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreatePlanningCommand command)
    {
        var id = await _sender.Send(command);
        return CreatedAtAction(nameof(GetById), new { id }, command);
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdatePlanningCommand command)
    {
        await _sender.Send(command);
        return NoContent();
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var consumerList = await _sender.Send(new GetAllPlanningsQuery());
        return Ok(consumerList);
    }


    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _sender.Send(new DeletePlanningCommand { Id = Id });
        return NoContent();
    }
}
