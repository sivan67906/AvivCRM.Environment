using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.FinanceInvoiceTemplateSettings.UpdateFinanceInvoiceTemplateSetting;

internal class UpdateFinanceInvoiceTemplateSettingCommandHandler : IRequestHandler<UpdateFinanceInvoiceTemplateSettingCommand>
{
    private readonly IGenericRepository<FinanceInvoiceTemplateSetting> _financeInvoiceTemplateSettingRepository;

    public UpdateFinanceInvoiceTemplateSettingCommandHandler(
        IGenericRepository<FinanceInvoiceTemplateSetting> financeInvoiceTemplateSettingRepository) =>
        _financeInvoiceTemplateSettingRepository = financeInvoiceTemplateSettingRepository;

    public async System.Threading.Tasks.Task Handle(UpdateFinanceInvoiceTemplateSettingCommand request, CancellationToken cancellationToken)
    {
        var financeInvoiceTemplateSetting = new FinanceInvoiceTemplateSetting
        {
            Id = request.Id,
            FIRBTemplateJsonSettings = request.FIRBTemplateJsonSettings,
            UpdatedDate = DateTime.Now
        };

        await _financeInvoiceTemplateSettingRepository.UpdateAsync(financeInvoiceTemplateSetting);
    }
}








































