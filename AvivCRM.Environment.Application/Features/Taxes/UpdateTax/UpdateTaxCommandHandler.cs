using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Taxes.UpdateTax;
public class UpdateTaxCommandHandler : IRequestHandler<UpdateTaxCommand, Guid>
{
    private readonly IGenericRepository<Tax> _taxRepository;
    public UpdateTaxCommandHandler(IGenericRepository<Tax> taxRepository) => _taxRepository = taxRepository;

    public async Task<Guid> Handle(UpdateTaxCommand request, CancellationToken cancellationToken)
    {
        var product = new Tax
        {
            Id = request.Id,
            Name = request.Name,
            Rate = request.Rate
        };
        await _taxRepository.UpdateAsync(product);
        return request.Id;
    }
}
