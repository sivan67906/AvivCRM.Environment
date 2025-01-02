using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.FinanceInvoiceTemplateSettings.DeleteFinanceInvoiceTemplateSetting;

internal class DeleteFinanceInvoiceTemplateSettingCommandHandler : IRequestHandler<DeleteFinanceInvoiceTemplateSettingCommand>
{
    private readonly IGenericRepository<FinanceInvoiceTemplateSetting> _timeLogRepository;

    public DeleteFinanceInvoiceTemplateSettingCommandHandler(
        IGenericRepository<FinanceInvoiceTemplateSetting> timeLogRepository) =>
        _timeLogRepository = timeLogRepository;
    public async System.Threading.Tasks.Task Handle(DeleteFinanceInvoiceTemplateSettingCommand request, CancellationToken cancellationToken)
    {
        await _timeLogRepository.DeleteAsync(request.Id);
    }
}








































