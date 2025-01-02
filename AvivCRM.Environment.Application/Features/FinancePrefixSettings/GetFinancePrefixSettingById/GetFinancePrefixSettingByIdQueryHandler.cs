using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.FinancePrefixSettings.GetFinancePrefixSettingById;

internal class GetFinancePrefixSettingByIdQueryHandler : IRequestHandler<GetFinancePrefixSettingByIdQuery, FinancePrefixSettingDTO>
{
    private readonly IGenericRepository<FinancePrefixSetting> _financeInvoiceTemplateSettingRepository;

    public GetFinancePrefixSettingByIdQueryHandler(
        IGenericRepository<FinancePrefixSetting> financeInvoiceTemplateSettingRepository) =>
        _financeInvoiceTemplateSettingRepository = financeInvoiceTemplateSettingRepository;

    public async Task<FinancePrefixSettingDTO> Handle(GetFinancePrefixSettingByIdQuery request, CancellationToken cancellationToken)
    {
        var financeInvoiceTemplateSetting = await _financeInvoiceTemplateSettingRepository.GetByIdAsync(request.Id);
        if (financeInvoiceTemplateSetting == null) return null;
        return new FinancePrefixSettingDTO
        {
            Id = financeInvoiceTemplateSetting.Id,
            FICBPrefixJsonSettings = financeInvoiceTemplateSetting.FICBPrefixJsonSettings
        };
    }
}




































