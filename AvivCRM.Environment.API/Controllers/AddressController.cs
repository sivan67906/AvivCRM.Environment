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
    private readonly ISender _sender;
    public AddressController(ISender sender) => _sender = sender;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var addressList = await _sender.Send(new GetAllAddressesQuery());
        return Ok(addressList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var address = await _sender.Send(new GetAddressByIdQuery { Id = Id });
        if (address is not null) { return Ok(address); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateAddressCommand command)
    {
        await _sender.Send(command);
        return Ok("Addresses Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateAddressCommand command)
    {
        await _sender.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _sender.Send(new DeleteAddressCommand { Id = Id });
        return NoContent();
    }
}

