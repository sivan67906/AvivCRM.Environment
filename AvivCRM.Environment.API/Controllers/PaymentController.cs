using MediatR;
using Microsoft.AspNetCore.Mvc;
using AvivCRM.Environment.Application.Features.Payments.DeletePayment;
using AvivCRM.Environment.Application.Features.Payments.GetAllPayment;
using AvivCRM.Environment.Application.Features.Payments.GetPaymentById;
using AvivCRM.Environment.Application.Features.Payments.CreatePayment;
using AvivCRM.Environment.Application.Features.Payments.UpdatePayment;

namespace AvivCRM.Environment.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PaymentController : ControllerBase
{
    private readonly ISender _sender;
    public PaymentController(ISender sender) => _sender = sender;


    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var product = await _sender.Send(new GetPaymentByIdQuery { Id = Id });
        if (product is not null) { return Ok(product); }
        return NotFound();
    }


    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreatePaymentCommand command)
    {
        var id = await _sender.Send(command);
        return CreatedAtAction(nameof(GetById), new { id }, command);
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdatePaymentCommand command)
    {
        await _sender.Send(command);
        return NoContent();
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var consumerList = await _sender.Send(new GetAllPaymentQuery());
        return Ok(consumerList);
    }


    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _sender.Send(new DeletePaymentCommand { Id = Id });
        return NoContent();
    }
}
