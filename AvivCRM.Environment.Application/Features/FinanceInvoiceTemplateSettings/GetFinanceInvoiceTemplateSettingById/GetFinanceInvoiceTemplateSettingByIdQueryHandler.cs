using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.FinanceInvoiceTemplateSettings.GetFinanceInvoiceTemplateSettingById;

internal class GetFinanceInvoiceTemplateSettingByIdQueryHandler : IRequestHandler<GetFinanceInvoiceTemplateSettingByIdQuery, FinanceInvoiceTemplateSettingDTO>
{
    private readonly IGenericRepository<FinanceInvoiceTemplateSetting> _financeInvoiceTemplateSettingRepository;

    public GetFinanceInvoiceTemplateSettingByIdQueryHandler(
        IGenericRepository<FinanceInvoiceTemplateSetting> financeInvoiceTemplateSettingRepository) =>
        _financeInvoiceTemplateSettingRepository = financeInvoiceTemplateSettingRepository;

    public async Task<FinanceInvoiceTemplateSettingDTO> Handle(GetFinanceInvoiceTemplateSettingByIdQuery request, CancellationToken cancellationToken)
    {
        var financeInvoiceTemplateSetting = await _financeInvoiceTemplateSettingRepository.GetByIdAsync(request.Id);
        if (financeInvoiceTemplateSetting == null) return null;
        return new FinanceInvoiceTemplateSettingDTO
        {
            Id = financeInvoiceTemplateSetting.Id,
            FIRBTemplateJsonSettings = financeInvoiceTemplateSetting.FIRBTemplateJsonSettings
        };
    }
}








































