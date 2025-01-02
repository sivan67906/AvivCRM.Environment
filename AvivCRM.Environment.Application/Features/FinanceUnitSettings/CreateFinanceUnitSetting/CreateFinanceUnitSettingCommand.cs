using MediatR;

namespace AvivCRM.Environment.Application.Features.FinanceUnitSettings.CreateFinanceUnitSetting;

public class CreateFinanceUnitSettingCommand : IRequest
{
    public string? FUnitCode { get; set; }
    public string? FUnitName { get; set; }
    public bool FIsDefault { get; set; }
}
































