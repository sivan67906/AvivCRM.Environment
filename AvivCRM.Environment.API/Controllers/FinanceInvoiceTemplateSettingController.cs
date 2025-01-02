using AvivCRM.Environment.Application.Features.FinanceInvoiceTemplateSettings.CreateFinanceInvoiceTemplateSetting;
using AvivCRM.Environment.Application.Features.FinanceInvoiceTemplateSettings.DeleteFinanceInvoiceTemplateSetting;
using AvivCRM.Environment.Application.Features.FinanceInvoiceTemplateSettings.GetAllFinanceInvoiceTemplateSettings;
using AvivCRM.Environment.Application.Features.FinanceInvoiceTemplateSettings.GetFinanceInvoiceTemplateSettingById;
using AvivCRM.Environment.Application.Features.FinanceInvoiceTemplateSettings.UpdateFinanceInvoiceTemplateSetting;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AvivCRM.Environment.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FinanceInvoiceTemplateSettingController : ControllerBase
{
    private readonly ISender _sender;
    public FinanceInvoiceTemplateSettingController(ISender sender) => _sender = sender;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var financeInvoiceTemplateSettingList = await _sender.Send(new GetAllFinanceInvoiceTemplateSettingsQuery());
        return Ok(financeInvoiceTemplateSettingList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var financeInvoiceTemplateSetting = await _sender.Send(new GetFinanceInvoiceTemplateSettingByIdQuery { Id = Id });
        if (financeInvoiceTemplateSetting is not null) { return Ok(financeInvoiceTemplateSetting); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateFinanceInvoiceTemplateSettingCommand command)
    {
        await _sender.Send(command);
        return Ok("FinanceInvoiceTemplateSettings Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateFinanceInvoiceTemplateSettingCommand command)
    {
        await _sender.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _sender.Send(new DeleteFinanceInvoiceTemplateSettingCommand { Id = Id });
        return NoContent();
    }
}






























