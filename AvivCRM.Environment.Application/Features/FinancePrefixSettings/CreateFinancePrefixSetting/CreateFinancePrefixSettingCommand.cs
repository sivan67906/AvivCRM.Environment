using MediatR;

namespace AvivCRM.Environment.Application.Features.FinancePrefixSettings.CreateFinancePrefixSetting;

public class CreateFinancePrefixSettingCommand : IRequest
{
    public string? FICBPrefixJsonSettings { get; set; }
}




































