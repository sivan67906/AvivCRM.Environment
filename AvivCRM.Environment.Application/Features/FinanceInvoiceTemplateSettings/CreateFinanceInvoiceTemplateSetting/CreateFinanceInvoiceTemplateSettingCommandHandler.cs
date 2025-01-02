using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.FinanceInvoiceTemplateSettings.CreateFinanceInvoiceTemplateSetting;

internal class CreateFinanceInvoiceTemplateSettingCommandHandler(
    IGenericRepository<FinanceInvoiceTemplateSetting> financeInvoiceTemplateSettingRepository) : IRequestHandler<CreateFinanceInvoiceTemplateSettingCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateFinanceInvoiceTemplateSettingCommand request, CancellationToken cancellationToken)
    {
        var financeInvoiceTemplateSetting = new FinanceInvoiceTemplateSetting
        {
            FIRBTemplateJsonSettings = request.FIRBTemplateJsonSettings,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await financeInvoiceTemplateSettingRepository.CreateAsync(financeInvoiceTemplateSetting);
    }
}








































