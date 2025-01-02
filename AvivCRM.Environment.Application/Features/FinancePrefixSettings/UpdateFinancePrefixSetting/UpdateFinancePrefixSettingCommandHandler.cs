using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.FinancePrefixSettings.UpdateFinancePrefixSetting;

internal class UpdateFinancePrefixSettingCommandHandler : IRequestHandler<UpdateFinancePrefixSettingCommand>
{
    private readonly IGenericRepository<FinancePrefixSetting> _financeInvoiceTemplateSettingRepository;

    public UpdateFinancePrefixSettingCommandHandler(
        IGenericRepository<FinancePrefixSetting> financeInvoiceTemplateSettingRepository) =>
        _financeInvoiceTemplateSettingRepository = financeInvoiceTemplateSettingRepository;

    public async System.Threading.Tasks.Task Handle(UpdateFinancePrefixSettingCommand request, CancellationToken cancellationToken)
    {
        var financeInvoiceTemplateSetting = new FinancePrefixSetting
        {
            Id = request.Id,
            FICBPrefixJsonSettings = request.FICBPrefixJsonSettings,
            UpdatedDate = DateTime.Now
        };

        await _financeInvoiceTemplateSettingRepository.UpdateAsync(financeInvoiceTemplateSetting);
    }
}




































