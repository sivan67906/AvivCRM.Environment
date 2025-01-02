using MediatR;

namespace AvivCRM.Environment.Application.Features.FinanceUnitSettings.UpdateFinanceUnitSetting;

public class UpdateFinanceUnitSettingCommand : IRequest
{
    public Guid Id { get; set; }
    public string? FUnitCode { get; set; }
    public string? FUnitName { get; set; }
    public bool FIsDefault { get; set; }
}
































