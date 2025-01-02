using MediatR;

namespace AvivCRM.Environment.Application.Features.Contracts.DeleteContract;
public class DeleteContractCommand : IRequest
{
    public Guid Id { get; set; }
}
