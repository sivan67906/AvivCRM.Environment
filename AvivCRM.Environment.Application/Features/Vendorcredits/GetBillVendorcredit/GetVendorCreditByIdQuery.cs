using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.Vendorcredits.GetBillVendorcredit;
public class GetVendorCreditByIdQuery : IRequest<VendorCreditDTO>
{
    public Guid Id { get; set; }
}
