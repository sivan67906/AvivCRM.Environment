using AvivCRM.Environment.Application.Features.BusinessTypes.CreateBusinessType;
using AvivCRM.Environment.Application.Features.BusinessTypes.DeleteBusinessType;
using AvivCRM.Environment.Application.Features.BusinessTypes.GetAllBusinessTypes;
using AvivCRM.Environment.Application.Features.BusinessTypes.GetBusinessTypeById;
using AvivCRM.Environment.Application.Features.BusinessTypes.UpdateBusinessType;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AvivCRM.Environment.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BusinessTypeController : ControllerBase
{
    private readonly ISender _sender;
    public BusinessTypeController(ISender sender) => _sender = sender;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var businessTypeList = await _sender.Send(new GetAllBusinessTypesQuery());
        return Ok(businessTypeList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var businessType = await _sender.Send(new GetBusinessTypeByIdQuery { Id = Id });
        if (businessType is not null) { return Ok(businessType); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateBusinessTypeCommand command)
    {
        await _sender.Send(command);
        return Ok("BusinessTypes Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateBusinessTypeCommand command)
    {
        await _sender.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _sender.Send(new DeleteBusinessTypeCommand { Id = Id });
        return NoContent();
    }
}



