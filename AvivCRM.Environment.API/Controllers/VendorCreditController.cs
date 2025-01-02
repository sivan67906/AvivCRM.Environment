using MediatR;
using Microsoft.AspNetCore.Mvc;
using AvivCRM.Environment.Application.Features.Vendorcredits.DeleteVendorcredit;
using AvivCRM.Environment.Application.Features.Vendorcredits.GetAllVendorcredit;
using AvivCRM.Environment.Application.Features.Vendorcredits.GetBillVendorcredit;
using AvivCRM.Environment.Application.Features.Vendorcredits.CreateVendorcredit;
using AvivCRM.Environment.Application.Features.Vendorcredits.UpdateVendorcredit;

namespace AvivCRM.Environment.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class VendorCreditController : ControllerBase
{
    private readonly ISender _sender;
    public VendorCreditController(ISender sender) => _sender = sender;


    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var product = await _sender.Send(new GetVendorCreditByIdQuery { Id = Id });
        if (product is not null) { return Ok(product); }
        return NotFound();
    }


    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateVendorCreditCommand command)
    {
        var id = await _sender.Send(command);
        return CreatedAtAction(nameof(GetById), new { id }, command);
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateVendorCreditCommand command)
    {
        await _sender.Send(command);
        return NoContent();
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var consumerList = await _sender.Send(new GetAllVendorCreditQuery());
        return Ok(consumerList);
    }


    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _sender.Send(new DeleteVendorCreditCommand { Id = Id });
        return NoContent();
    }
}
