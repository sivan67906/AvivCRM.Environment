using MediatR;

namespace AvivCRM.Environment.Application.Features.FinanceInvoiceTemplateSettings.CreateFinanceInvoiceTemplateSetting;

public class CreateFinanceInvoiceTemplateSettingCommand : IRequest
{
    public string? FIRBTemplateJsonSettings { get; set; }
}








































