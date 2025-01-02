using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Taxes.GetTaxById;
public class GetTaxByIdQueryHandler : IRequestHandler<GetTaxByIdQuery, TaxDTO>
{
    private readonly IGenericRepository<Tax> _repository;
    public GetTaxByIdQueryHandler(IGenericRepository<Tax> repository)
    {
        _repository = repository;
    }

    public async Task<TaxDTO> Handle(GetTaxByIdQuery request, CancellationToken cancellationToken)
    {
        var client = await _repository.GetByIdAsync(request.Id);
        if (client == null) return null;
        return new TaxDTO
        {
            Id = client.Id,
            Name = client.Name,
            Rate = client.Rate
        };
    }
}
