using MediatR;

namespace AvivCRM.Environment.Application.Features.FinancePrefixSettings.DeleteFinancePrefixSetting
{
    public class DeleteFinancePrefixSettingCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}




































