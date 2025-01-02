using AvivCRM.Environment.Application.Features.FinancePrefixSettings.CreateFinancePrefixSetting;
using AvivCRM.Environment.Application.Features.FinancePrefixSettings.DeleteFinancePrefixSetting;
using AvivCRM.Environment.Application.Features.FinancePrefixSettings.GetAllFinancePrefixSettings;
using AvivCRM.Environment.Application.Features.FinancePrefixSettings.GetFinancePrefixSettingById;
using AvivCRM.Environment.Application.Features.FinancePrefixSettings.UpdateFinancePrefixSetting;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AvivCRM.Environment.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FinancePrefixSettingController : ControllerBase
{
    private readonly IMediator _mediator;
    public FinancePrefixSettingController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var financeInvoiceTemplateSettingList = await _mediator.Send(new GetAllFinancePrefixSettingsQuery());
        return Ok(financeInvoiceTemplateSettingList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var financeInvoiceTemplateSetting = await _mediator.Send(new GetFinancePrefixSettingByIdQuery { Id = Id });
        if (financeInvoiceTemplateSetting is not null) { return Ok(financeInvoiceTemplateSetting); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateFinancePrefixSettingCommand command)
    {
        await _mediator.Send(command);
        return Ok("FinancePrefixSettings Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateFinancePrefixSettingCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _mediator.Send(new DeleteFinancePrefixSettingCommand { Id = Id });
        return NoContent();
    }
}


























