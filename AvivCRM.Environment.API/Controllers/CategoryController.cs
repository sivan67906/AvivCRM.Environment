using AvivCRM.Environment.Application.Features.Categories.CreateCategory;
using AvivCRM.Environment.Application.Features.Categories.DeleteCategory;
using AvivCRM.Environment.Application.Features.Categories.GetAllCategorys;
using AvivCRM.Environment.Application.Features.Categories.GetCategoryById;
using AvivCRM.Environment.Application.Features.Categories.UpdateCategory;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AvivCRM.Environment.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly ISender _sender;
    public CategoryController(ISender sender) => _sender = sender;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var categoryList = await _sender.Send(new GetAllCategoriesQuery());
        return Ok(categoryList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var category = await _sender.Send(new GetCategoryByIdQuery { Id = Id });
        if (category is not null) { return Ok(category); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateCategoryCommand command)
    {
        await _sender.Send(command);
        return Ok("Categories Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateCategoryCommand command)
    {
        await _sender.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _sender.Send(new DeleteCategoryCommand { Id = Id });
        return NoContent();
    }
}



