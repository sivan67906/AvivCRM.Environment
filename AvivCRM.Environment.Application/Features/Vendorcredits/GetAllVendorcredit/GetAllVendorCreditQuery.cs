using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.Vendorcredits.GetAllVendorcredit;
public class GetAllVendorCreditQuery : IRequest<IEnumerable<VendorCreditDTO>>
{
}
