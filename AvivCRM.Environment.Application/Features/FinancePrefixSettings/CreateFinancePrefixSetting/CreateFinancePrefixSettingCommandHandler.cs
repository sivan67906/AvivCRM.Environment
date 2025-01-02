using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.FinancePrefixSettings.CreateFinancePrefixSetting;

internal class CreateFinancePrefixSettingCommandHandler(
    IGenericRepository<FinancePrefixSetting> financeInvoiceTemplateSettingRepository) : IRequestHandler<CreateFinancePrefixSettingCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateFinancePrefixSettingCommand request, CancellationToken cancellationToken)
    {
        var financeInvoiceTemplateSetting = new FinancePrefixSetting
        {
            FICBPrefixJsonSettings = request.FICBPrefixJsonSettings,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await financeInvoiceTemplateSettingRepository.CreateAsync(financeInvoiceTemplateSetting);
    }
}




































