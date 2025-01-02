using MediatR;

namespace AvivCRM.Environment.Application.Features.Contracts.UpdateContract;
public class UpdateContractCommand : IRequest<Guid>
{
    public Guid Id { get; set; }
    public string? ContractPrefix { get; set; }
    public string? ContractNumberSeprator { get; set; }
    public int ContractNumberDigits { get; set; }
    public string? ContractNumberExample { get; set; }
}
