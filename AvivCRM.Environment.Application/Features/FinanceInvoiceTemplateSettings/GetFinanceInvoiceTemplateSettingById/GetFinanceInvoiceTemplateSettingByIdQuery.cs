//using AvivCRM.Environment.Application.DTOs;
using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.FinanceInvoiceTemplateSettings.GetFinanceInvoiceTemplateSettingById
{
    public class GetFinanceInvoiceTemplateSettingByIdQuery : IRequest<FinanceInvoiceTemplateSettingDTO>
    {
        public Guid Id { get; set; }
    }
}








































