using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Contracts.GetAllContract;
public class GetAllContractQueryHandler : IRequestHandler<GetAllContractQuery, IEnumerable<ContractDTO>>
{
    private readonly IGenericRepository<Contract> _contractRepository;
    public GetAllContractQueryHandler(IGenericRepository<Contract> repository) => _contractRepository = repository;

    public async Task<IEnumerable<ContractDTO>> Handle(GetAllContractQuery request, CancellationToken cancellationToken)
    {
        var currencys = await _contractRepository.GetAllAsync();

        var currencylist = currencys.Select(x => new ContractDTO
        {
            Id = x.Id,
            ContractPrefix = x.ContractPrefix,
            ContractNumberSeprator = x.ContractNumberSeprator,
            ContractNumberDigits = x.ContractNumberDigits,
            ContractNumberExample = x.ContractNumberExample,
        }).ToList();

        return currencylist;
    }
}