using AvivCRM.Environment.Application.Features.Employees.CreateEmployee;
using AvivCRM.Environment.Application.Features.Employees.DeleteEmployee;
using AvivCRM.Environment.Application.Features.Employees.GetAllEmployee;
using AvivCRM.Environment.Application.Features.Employees.GetEmployeeById;
using AvivCRM.Environment.Application.Features.Employees.UpdateEmployee;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AvivCRM.Environment.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class EmployeeController : ControllerBase
{

    private readonly ISender _sender;
    public EmployeeController(ISender sender) => _sender = sender;


    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var product = await _sender.Send(new GetEmployeeByIdQuery { Id = Id });
        if (product is not null) { return Ok(product); }
        return NotFound();
    }


    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateEmployeeCommand command)
    {
        await _sender.Send(command);
        return Ok("Clients Created Successfully.");
    }


    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateEmployeeCommand command)
    {
        await _sender.Send(command);
        return NoContent();
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var consumerList = await _sender.Send(new GetAllEmployeeQuery());
        return Ok(consumerList);
    }


    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _sender.Send(new DeleteEmployeeCommand { Id = Id });
        return NoContent();
    }
}
