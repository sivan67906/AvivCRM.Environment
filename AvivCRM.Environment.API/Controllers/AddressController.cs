using AvivCRM.Environment.Application.Features.Addresses.CreateAddress;
using AvivCRM.Environment.Application.Features.Addresses.DeleteAddress;
using AvivCRM.Environment.Application.Features.Addresses.GetAddressById;
using AvivCRM.Environment.Application.Features.Addresses.GetAllAddresss;
using AvivCRM.Environment.Application.Features.Addresses.UpdateAddress;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AvivCRM.Environment.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AddressController : ControllerBase
{
    private readonly IMediator _mediator;
    public AddressController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var addressList = await _mediator.Send(new GetAllAddressesQuery());
        return Ok(addressList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var address = await _mediator.Send(new GetAddressByIdQuery { Id = Id });
        if (address is not null) { return Ok(address); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateAddressCommand command)
    {
        await _mediator.Send(command);
        return Ok("Addresses Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateAddressCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _mediator.Send(new DeleteAddressCommand { Id = Id });
        return NoContent();
    }
}

