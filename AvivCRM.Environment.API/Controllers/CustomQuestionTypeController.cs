using AvivCRM.Environment.Application.Features.CustomQuestionTypes.DeleteCustomQuestionType;
using AvivCRM.Environment.Application.Features.CustomQuestionTypes.GetAllCustomQuestionTypes;
using AvivCRM.Environment.Application.Features.CustomQuestionTypes.GetCustomQuestionTypeById;
using AvivCRM.Environment.Application.Features.CustomQuestionTypes.UpdateCustomQuestionType;
using AvivCRM.Environment.Application.Features.Departments.CreateCustomQuestionType;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AvivCRM.Environment.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomQuestionTypeController : ControllerBase
{
    private readonly IMediator _mediator;
    public CustomQuestionTypeController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var customQuestionTypeList = await _mediator.Send(new GetAllCustomQuestionTypesQuery());
        return Ok(customQuestionTypeList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var customQuestionType = await _mediator.Send(new GetCustomQuestionTypeByIdQuery { Id = Id });
        if (customQuestionType is not null) { return Ok(customQuestionType); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateCustomQuestionTypeCommand command)
    {
        await _mediator.Send(command);
        return Ok("CustomQuestionTypes Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateCustomQuestionTypeCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _mediator.Send(new DeleteCustomQuestionTypeCommand { Id = Id });
        return NoContent();
    }
}














