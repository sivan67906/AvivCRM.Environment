using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.Taxes.GetAllTax;
public class GetAllTaxQuery : IRequest<IEnumerable<TaxDTO>>
{
}
