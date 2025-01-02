using AvivCRM.Environment.Application.Features.FinanceInvoiceSettings.CreateFinanceInvoiceSetting;
using AvivCRM.Environment.Application.Features.FinanceInvoiceSettings.DeleteFinanceInvoiceSetting;
using AvivCRM.Environment.Application.Features.FinanceInvoiceSettings.GetAllFinanceInvoiceSettings;
using AvivCRM.Environment.Application.Features.FinanceInvoiceSettings.GetFinanceInvoiceSettingById;
using AvivCRM.Environment.Application.Features.FinanceInvoiceSettings.UpdateFinanceInvoiceSetting;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AvivCRM.Environment.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FinanceInvoiceSettingController : ControllerBase
{
    private readonly ISender _sender;
    public FinanceInvoiceSettingController(ISender sender) => _sender = sender;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var financeInvoiceSettingList = await _sender.Send(new GetAllFinanceInvoiceSettingsQuery());
        return Ok(financeInvoiceSettingList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var financeInvoiceSetting = await _sender.Send(new GetFinanceInvoiceSettingByIdQuery { Id = Id });
        if (financeInvoiceSetting is not null) { return Ok(financeInvoiceSetting); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateFinanceInvoiceSettingCommand command)
    {
        await _sender.Send(command);
        return Ok("FinanceInvoiceSettings Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateFinanceInvoiceSettingCommand command)
    {
        await _sender.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _sender.Send(new DeleteFinanceInvoiceSettingCommand { Id = Id });
        return NoContent();
    }
}


































