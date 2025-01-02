using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;
using MediatR;

namespace AvivCRM.Environment.Application.Features.FinancePrefixSettings.DeleteFinancePrefixSetting;

internal class DeleteFinancePrefixSettingCommandHandler : IRequestHandler<DeleteFinancePrefixSettingCommand>
{
    private readonly IGenericRepository<FinancePrefixSetting> _timeLogRepository;

    public DeleteFinancePrefixSettingCommandHandler(
        IGenericRepository<FinancePrefixSetting> timeLogRepository) =>
        _timeLogRepository = timeLogRepository;
    public async System.Threading.Tasks.Task Handle(DeleteFinancePrefixSettingCommand request, CancellationToken cancellationToken)
    {
        await _timeLogRepository.DeleteAsync(request.Id);
    }
}




































