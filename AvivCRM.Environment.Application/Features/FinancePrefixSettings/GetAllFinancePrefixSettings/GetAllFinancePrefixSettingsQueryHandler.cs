using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.FinancePrefixSettings.GetAllFinancePrefixSettings;

internal class GetAllFinancePrefixSettingsQueryHandler : IRequestHandler<GetAllFinancePrefixSettingsQuery, IEnumerable<FinancePrefixSettingDTO>>
{
    private readonly IGenericRepository<FinancePrefixSetting> _financeInvoiceTemplateSettingRepository;

    public GetAllFinancePrefixSettingsQueryHandler(
        IGenericRepository<FinancePrefixSetting> financeInvoiceTemplateSettingRepository)
    {
        _financeInvoiceTemplateSettingRepository = financeInvoiceTemplateSettingRepository;
    }

    public async Task<IEnumerable<FinancePrefixSettingDTO>> Handle(GetAllFinancePrefixSettingsQuery request, CancellationToken cancellationToken)
    {
        var financePrefixSettings = await _financeInvoiceTemplateSettingRepository.GetAllAsync();
        var financeInvoiceTemplateSettingList = financePrefixSettings.Select(x => new FinancePrefixSettingDTO
        {
            Id = x.Id,
            FICBPrefixJsonSettings = x.FICBPrefixJsonSettings
        }).ToList();

        return financeInvoiceTemplateSettingList;
    }
}




































