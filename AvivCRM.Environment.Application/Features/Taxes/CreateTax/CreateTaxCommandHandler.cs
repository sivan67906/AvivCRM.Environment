using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Taxes.CreateTax;
public class CreateTaxCommandHandler : IRequestHandler<CreateTaxCommand, Guid>
{
    private readonly IGenericRepository<Tax> _taxrepo;
    public CreateTaxCommandHandler(IGenericRepository<Tax> taxrepo) => _taxrepo = taxrepo;

    public async Task<Guid> Handle(CreateTaxCommand request, CancellationToken cancellationToken)
    {
        var tax = new Tax
        {
            Name = request.Name,
            Rate = request.Rate
        };
        await _taxrepo.CreateAsync(tax);
        return tax.Id;
    }
}
