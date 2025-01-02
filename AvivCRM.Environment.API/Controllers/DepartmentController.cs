using AvivCRM.Environment.Application.Features.Departments.CreateDepartment;
using AvivCRM.Environment.Application.Features.Departments.DeleteDepartment;
using AvivCRM.Environment.Application.Features.Departments.GetAllDepartments;
using AvivCRM.Environment.Application.Features.Departments.GetDepartmentById;
using AvivCRM.Environment.Application.Features.Departments.UpdateDepartment;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AvivCRM.Environment.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DepartmentController : ControllerBase
{
    private readonly ISender _sender;
    public DepartmentController(ISender sender) => _sender = sender;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var departmentList = await _sender.Send(new GetAllDepartmentsQuery());
        return Ok(departmentList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var department = await _sender.Send(new GetDepartmentByIdQuery { Id = Id });
        if (department is null) return NotFound();
        return Ok(department);
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateDepartmentCommand command)
    {
        await _sender.Send(command);
        return Ok("Departments Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateDepartmentCommand command)
    {
        await _sender.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _sender.Send(new DeleteDepartmentCommand { Id = Id });
        return NoContent();
    }
}


