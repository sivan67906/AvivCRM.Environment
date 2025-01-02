using MediatR;

namespace AvivCRM.Environment.Application.Features.FinancePrefixSettings.UpdateFinancePrefixSetting;

public class UpdateFinancePrefixSettingCommand : IRequest
{
    public Guid Id { get; set; }
    public string? FICBPrefixJsonSettings { get; set; }
}




































