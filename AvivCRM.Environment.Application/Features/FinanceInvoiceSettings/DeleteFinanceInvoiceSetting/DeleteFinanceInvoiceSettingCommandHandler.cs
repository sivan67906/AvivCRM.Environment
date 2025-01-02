using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.FinanceInvoiceSettings.DeleteFinanceInvoiceSetting;

internal class DeleteFinanceInvoiceSettingCommandHandler : IRequestHandler<DeleteFinanceInvoiceSettingCommand>
{
    private readonly IGenericRepository<FinanceInvoiceSetting> _timeLogRepository;

    public DeleteFinanceInvoiceSettingCommandHandler(
        IGenericRepository<FinanceInvoiceSetting> timeLogRepository) =>
        _timeLogRepository = timeLogRepository;
    public async System.Threading.Tasks.Task Handle(DeleteFinanceInvoiceSettingCommand request, CancellationToken cancellationToken)
    {
        await _timeLogRepository.DeleteAsync(request.Id);
    }
}












































