using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.FinanceUnitSettings.CreateFinanceUnitSetting;

internal class CreateFinanceUnitSettingCommandHandler(
    IGenericRepository<FinanceUnitSetting> financeUnitSettingRepository) : IRequestHandler<CreateFinanceUnitSettingCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateFinanceUnitSettingCommand request, CancellationToken cancellationToken)
    {
        var financeUnitSetting = new FinanceUnitSetting
        {
            FUnitCode = request.FUnitCode,
            FUnitName = request.FUnitName,
            FIsDefault = request.FIsDefault,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await financeUnitSettingRepository.CreateAsync(financeUnitSetting);
    }
}
































