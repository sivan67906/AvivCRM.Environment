using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Contracts.GetContractById;
public class GetContractByIdQueryHandler : IRequestHandler<GetContractByIdQuery, ContractDTO>
{
    private readonly IGenericRepository<Contract> _contractRepo;
    public GetContractByIdQueryHandler(IGenericRepository<Contract> repository) => _contractRepo = repository;

    public async Task<ContractDTO> Handle(GetContractByIdQuery request, CancellationToken cancellationToken)
    {
        var currency = await _contractRepo.GetByIdAsync(request.Id);
        if (currency == null) return null;
        return new ContractDTO
        {
            Id = currency.Id,
            ContractPrefix = currency.ContractPrefix,
            ContractNumberSeprator = currency.ContractNumberSeprator,
            ContractNumberDigits = currency.ContractNumberDigits,
            ContractNumberExample = currency.ContractNumberExample,
        };
    }
}
