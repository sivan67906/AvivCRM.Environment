using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.Taxes.GetTaxById;
public class GetTaxByIdQuery : IRequest<TaxDTO>
{
    public Guid Id { get; set; }
}
