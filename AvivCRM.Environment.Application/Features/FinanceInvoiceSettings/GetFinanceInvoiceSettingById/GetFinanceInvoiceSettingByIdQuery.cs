//using AvivCRM.Environment.Application.DTOs;
using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.FinanceInvoiceSettings.GetFinanceInvoiceSettingById
{
    public class GetFinanceInvoiceSettingByIdQuery : IRequest<FinanceInvoiceSettingDTO>
    {
        public Guid Id { get; set; }
    }
}












































