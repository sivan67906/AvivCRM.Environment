using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.Contracts.GetContractById;
public class GetContractByIdQuery : IRequest<ContractDTO>
{
    public Guid Id { get; set; }
}
