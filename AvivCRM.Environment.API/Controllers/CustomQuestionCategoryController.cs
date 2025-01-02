using AvivCRM.Environment.Application.Features.CustomQuestionCategories.CreateCustomQuestionCategory;
using AvivCRM.Environment.Application.Features.CustomQuestionCategories.DeleteCustomQuestionCategory;
using AvivCRM.Environment.Application.Features.CustomQuestionCategories.GetAllCustomQuestionCategorys;
using AvivCRM.Environment.Application.Features.CustomQuestionCategories.GetCustomQuestionCategoryById;
using AvivCRM.Environment.Application.Features.CustomQuestionCategories.UpdateCustomQuestionCategory;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AvivCRM.Environment.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomQuestionCategoryController : ControllerBase
{
    private readonly ISender _sender;
    public CustomQuestionCategoryController(ISender sender) => _sender = sender;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var customQuestionCategoryList = await _sender.Send(new GetAllCustomQuestionCategoriesQuery());
        return Ok(customQuestionCategoryList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var customQuestionCategory = await _sender.Send(new GetCustomQuestionCategoryByIdQuery { Id = Id });
        if (customQuestionCategory is not null) { return Ok(customQuestionCategory); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateCustomQuestionCategoryCommand command)
    {
        await _sender.Send(command);
        return Ok("CustomQuestionCategories Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateCustomQuestionCategoryCommand command)
    {
        await _sender.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _sender.Send(new DeleteCustomQuestionCategoryCommand { Id = Id });
        return NoContent();
    }
}














