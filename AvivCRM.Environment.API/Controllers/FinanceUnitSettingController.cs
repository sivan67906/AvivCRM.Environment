using AvivCRM.Environment.Application.Features.FinanceUnitSettings.CreateFinanceUnitSetting;
using AvivCRM.Environment.Application.Features.FinanceUnitSettings.DeleteFinanceUnitSetting;
using AvivCRM.Environment.Application.Features.FinanceUnitSettings.GetAllFinanceUnitSettings;
using AvivCRM.Environment.Application.Features.FinanceUnitSettings.GetFinanceUnitSettingById;
using AvivCRM.Environment.Application.Features.FinanceUnitSettings.UpdateFinanceUnitSetting;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AvivCRM.Environment.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FinanceUnitSettingController : ControllerBase
{
    private readonly IMediator _mediator;
    public FinanceUnitSettingController(IMediator mediator) => _mediator = mediator;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var financeUnitSettingList = await _mediator.Send(new GetAllFinanceUnitSettingsQuery());
        return Ok(financeUnitSettingList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var financeUnitSetting = await _mediator.Send(new GetFinanceUnitSettingByIdQuery { Id = Id });
        if (financeUnitSetting is not null) { return Ok(financeUnitSetting); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateFinanceUnitSettingCommand command)
    {
        await _mediator.Send(command);
        return Ok("FinanceUnitSettings Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateFinanceUnitSettingCommand command)
    {
        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _mediator.Send(new DeleteFinanceUnitSettingCommand { Id = Id });
        return NoContent();
    }
}






















