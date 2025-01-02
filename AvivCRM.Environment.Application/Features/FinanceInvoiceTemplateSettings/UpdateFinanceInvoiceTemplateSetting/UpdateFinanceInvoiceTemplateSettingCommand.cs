using MediatR;

namespace AvivCRM.Environment.Application.Features.FinanceInvoiceTemplateSettings.UpdateFinanceInvoiceTemplateSetting;

public class UpdateFinanceInvoiceTemplateSettingCommand : IRequest
{
    public Guid Id { get; set; }
    public string? FIRBTemplateJsonSettings { get; set; }
}








































