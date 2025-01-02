using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.FinanceUnitSettings.DeleteFinanceUnitSetting;

internal class DeleteFinanceUnitSettingCommandHandler : IRequestHandler<DeleteFinanceUnitSettingCommand>
{
    private readonly IGenericRepository<FinanceUnitSetting> _timeLogRepository;

    public DeleteFinanceUnitSettingCommandHandler(
        IGenericRepository<FinanceUnitSetting> timeLogRepository) =>
        _timeLogRepository = timeLogRepository;
    public async System.Threading.Tasks.Task Handle(DeleteFinanceUnitSettingCommand request, CancellationToken cancellationToken)
    {
        await _timeLogRepository.DeleteAsync(request.Id);
    }
}
































