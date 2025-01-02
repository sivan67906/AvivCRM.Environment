using MediatR;

namespace AvivCRM.Environment.Application.Features.Taxes.DeleteTax;
public class DeleteTaxCommand : IRequest
{
    public Guid Id { get; set; }
}
