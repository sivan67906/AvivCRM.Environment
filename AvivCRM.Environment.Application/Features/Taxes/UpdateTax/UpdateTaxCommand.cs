using MediatR;

namespace AvivCRM.Environment.Application.Features.Taxes.UpdateTax;
public class UpdateTaxCommand : IRequest<Guid>
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public float Rate { get; set; }
}
