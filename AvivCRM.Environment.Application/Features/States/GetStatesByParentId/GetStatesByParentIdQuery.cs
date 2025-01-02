using AvivCRM.Environment.Application.DTOs;
using MediatR;

namespace AvivCRM.Environment.Application.Features.States.GetStatesByParentId;
public class GetStatesByParentIdQuery : IRequest<IEnumerable<StateDTO>>
{
    public Guid CountryId { get; set; }
}

