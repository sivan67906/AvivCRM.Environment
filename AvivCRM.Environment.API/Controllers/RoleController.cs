using AvivCRM.Environment.Application.Features.Roles.CreateRole;
using AvivCRM.Environment.Application.Features.Roles.UpdateRole;
using AvivCRM.Environment.Application.Features.Roles.DeleteRole;
using AvivCRM.Environment.Application.Features.Roles.GetAllRoles;
using AvivCRM.Environment.Application.Features.Roles.GetRoleById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AvivCRM.Environment.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RoleController : ControllerBase
{
    private readonly ISender _sender;
    public RoleController(ISender sender) => _sender = sender;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var roleList = await _sender.Send(new GetAllRolesQuery());
        return Ok(roleList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var role = await _sender.Send(new GetRoleByIdQuery { Id = Id });
        if (role is not null) { return Ok(role); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateRoleCommand command)
    {
        await _sender.Send(command);
        return Ok("Roles Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateRoleCommand command)
    {
        await _sender.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _sender.Send(new DeleteRoleCommand { Id = Id });
        return NoContent();
    }
}


