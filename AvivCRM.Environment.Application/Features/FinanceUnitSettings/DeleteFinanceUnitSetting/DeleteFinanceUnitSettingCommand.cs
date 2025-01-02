using MediatR;

namespace AvivCRM.Environment.Application.Features.FinanceUnitSettings.DeleteFinanceUnitSetting
{
    public class DeleteFinanceUnitSettingCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
































