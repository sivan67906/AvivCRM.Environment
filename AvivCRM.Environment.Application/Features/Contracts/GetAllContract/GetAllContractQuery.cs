using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.Contracts.GetAllContract;
public class GetAllContractQuery : IRequest<IEnumerable<ContractDTO>>
{
}
