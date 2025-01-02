using MediatR;

namespace AvivCRM.Environment.Application.Features.Taxes.CreateTax;
public class CreateTaxCommand : IRequest<Guid>
{
    public string? Name { get; set; }
    public float Rate { get; set; }
}
