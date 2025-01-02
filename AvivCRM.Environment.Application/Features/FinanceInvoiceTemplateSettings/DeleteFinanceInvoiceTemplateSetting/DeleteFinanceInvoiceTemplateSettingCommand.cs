using MediatR;

namespace AvivCRM.Environment.Application.Features.FinanceInvoiceTemplateSettings.DeleteFinanceInvoiceTemplateSetting
{
    public class DeleteFinanceInvoiceTemplateSettingCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}








































