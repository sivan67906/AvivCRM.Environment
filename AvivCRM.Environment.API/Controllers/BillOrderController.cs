using AvivCRM.Environment.Application.Features.BillOrders.CreateBillOrder;
using AvivCRM.Environment.Application.Features.BillOrders.DeleteBillOrder;
using AvivCRM.Environment.Application.Features.BillOrders.GetAllBillOrder;
using AvivCRM.Environment.Application.Features.BillOrders.GetBillOrderById;
using AvivCRM.Environment.Application.Features.BillOrders.UpdateBillOrder;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AvivCRM.Environment.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BillOrderController : ControllerBase
{
    private readonly IMediator _mediator;
    public BillOrderController(IMediator mediator) => _mediator = mediator;


    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var product = await _mediator.Send(new GetBillOrderByIdQuery { Id = Id });
        if (product is not null) { return Ok(product); }
        return NotFound();
    }


    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateBillOrderCommand command)
    {
        var id = await _mediator.Send(command);
        return CreatedAtAction(nameof(GetById), new { id }, command);
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateBillOrderCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var consumerList = await _mediator.Send(new GetAllBillOrderQuery());
        return Ok(consumerList);
    }


    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _mediator.Send(new DeleteBillOrderCommand { Id = Id });
        return NoContent();
    }
}
