using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.FinanceInvoiceTemplateSettings.GetAllFinanceInvoiceTemplateSettings;

internal class GetAllFinanceInvoiceTemplateSettingsQueryHandler : IRequestHandler<GetAllFinanceInvoiceTemplateSettingsQuery, IEnumerable<FinanceInvoiceTemplateSettingDTO>>
{
    private readonly IGenericRepository<FinanceInvoiceTemplateSetting> _financeInvoiceTemplateSettingRepository;

    public GetAllFinanceInvoiceTemplateSettingsQueryHandler(
        IGenericRepository<FinanceInvoiceTemplateSetting> financeInvoiceTemplateSettingRepository)
    {
        _financeInvoiceTemplateSettingRepository = financeInvoiceTemplateSettingRepository;
    }

    public async Task<IEnumerable<FinanceInvoiceTemplateSettingDTO>> Handle(GetAllFinanceInvoiceTemplateSettingsQuery request, CancellationToken cancellationToken)
    {
        var financeInvoiceTemplateSettings = await _financeInvoiceTemplateSettingRepository.GetAllAsync();
        var financeInvoiceTemplateSettingList = financeInvoiceTemplateSettings.Select(x => new FinanceInvoiceTemplateSettingDTO
        {
            Id = x.Id,
            FIRBTemplateJsonSettings = x.FIRBTemplateJsonSettings
        }).ToList();

        return financeInvoiceTemplateSettingList;
    }
}








































