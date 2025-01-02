using AvivCRM.Environment.Application.Features.ProjectCategories.CreateProjectCategory;
using AvivCRM.Environment.Application.Features.ProjectCategories.DeleteProjectCategory;
using AvivCRM.Environment.Application.Features.ProjectCategories.GetAllProjectCategorys;
using AvivCRM.Environment.Application.Features.ProjectCategories.GetProjectCategoryById;
using AvivCRM.Environment.Application.Features.ProjectCategories.UpdateProjectCategory;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AvivCRM.Environment.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProjectCategoryController : ControllerBase
{
    private readonly ISender _sender;
    public ProjectCategoryController(ISender sender) => _sender = sender;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var projectCategoryList = await _sender.Send(new GetAllProjectCategoriesQuery());
        return Ok(projectCategoryList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var projectCategory = await _sender.Send(new GetProjectCategoryByIdQuery { Id = Id });
        if (projectCategory is not null) { return Ok(projectCategory); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateProjectCategoryCommand command)
    {
        await _sender.Send(command);
        return Ok("ProjectCategories Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateProjectCategoryCommand command)
    {
        await _sender.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _sender.Send(new DeleteProjectCategoryCommand { Id = Id });
        return NoContent();
    }
}


