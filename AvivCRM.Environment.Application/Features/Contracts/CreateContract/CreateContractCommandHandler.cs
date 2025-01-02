using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Contracts.CreateContract;
public class CreateContractCommandHandler : IRequestHandler<CreateContractCommand, Guid>
{
    private readonly IGenericRepository<Contract> _contractRepo;
    public CreateContractCommandHandler(IGenericRepository<Contract> repository) => _contractRepo = repository;

    public async Task<Guid> Handle(CreateContractCommand request, CancellationToken cancellationToken)
    {
        var Contract = new Contract
        {
            ContractPrefix = request.ContractPrefix,
            ContractNumberSeprator = request.ContractNumberSeprator,
            ContractNumberDigits = request.ContractNumberDigits,
            ContractNumberExample = request.ContractNumberExample,
        };
        await _contractRepo.CreateAsync(Contract);
        return Contract.Id;
    }
}