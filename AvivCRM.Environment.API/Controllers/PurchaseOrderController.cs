using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AvivCRM.Environment.Application.Features.PurchaseOrders.DeletePurchaseOrder;
using AvivCRM.Environment.Application.Features.PurchaseOrders.GetAllPurchaseOrder;
using AvivCRM.Environment.Application.Features.PurchaseOrders.GetPurchaseOrderById;
using AvivCRM.Environment.Application.Features.Taxes.CreateTax;
using AvivCRM.Environment.Application.Features.Taxes.DeleteTax;
using AvivCRM.Environment.Application.Features.Taxes.UpdateTax;
using AvivCRM.Environment.Application.Features.Taxes.GetAllTax;
using AvivCRM.Environment.Application.Features.Taxes.GetTaxById;
using AvivCRM.Environment.Application.Features.PurchaseOrders.CreatePurchaseOrder;
using AvivCRM.Environment.Application.Features.PurchaseOrders.UpdatePurchaseOrder;

namespace AvivCRM.Environment.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PurchaseOrderController : ControllerBase
{
    private readonly IMediator _mediator;
    public PurchaseOrderController(IMediator mediator) => _mediator = mediator;


    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var product = await _mediator.Send(new GetPurchaseOrderByIdQuery { Id = Id });
        if (product is not null) { return Ok(product); }
        return NotFound();
    }


    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreatePurchaseOrderCommand command)
    {
        var id = await _mediator.Send(command);
        return CreatedAtAction(nameof(GetById), new { id }, command);
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdatePurchaseOrderCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var consumerList = await _mediator.Send(new GetAllPurchaseOrderQuery());
        return Ok(consumerList);
    }


    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _mediator.Send(new DeletePurchaseOrderCommand { Id = Id });
        return NoContent();
    }
}
