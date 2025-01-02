using AvivCRM.Environment.Application.Features.States.CreateState;
using AvivCRM.Environment.Application.Features.States.UpdateState;
using AvivCRM.Environment.Application.Features.States.DeleteState;
using AvivCRM.Environment.Application.Features.States.GetAllStates;
using AvivCRM.Environment.Application.Features.States.GetStateById;
using AvivCRM.Environment.Application.Features.States.GetStatesByParentId;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AvivCRM.Environment.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StateController : ControllerBase
{
    private readonly IMediator _mediator;
    public StateController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var stateList = await _mediator.Send(new GetAllStatesQuery());
        return Ok(stateList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var state = await _mediator.Send(new GetStateByIdQuery { Id = Id });
        if (state is not null) { return Ok(state); }
        return NotFound();
    }

    [HttpGet("GetByParentId")]
    public async Task<IActionResult> GetByParentId(Guid parentId)
    {
        var state = await _mediator.Send(new GetStatesByParentIdQuery { CountryId = parentId });
        if (state is not null) { return Ok(state); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateStateCommand command)
    {
        await _mediator.Send(command);
        return Ok("States Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateStateCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _mediator.Send(new DeleteStateCommand { Id = Id });
        return NoContent();
    }
}







