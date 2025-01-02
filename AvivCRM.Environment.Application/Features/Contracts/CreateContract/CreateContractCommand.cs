using MediatR;

namespace AvivCRM.Environment.Application.Features.Contracts.CreateContract;
public class CreateContractCommand : IRequest<Guid>
{

    public string? ContractPrefix { get; set; }
    public string? ContractNumberSeprator { get; set; }
    public int ContractNumberDigits { get; set; }
    public string? ContractNumberExample { get; set; }
}
