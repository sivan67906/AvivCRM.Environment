using AvivCRM.Environment.Application.DTOs;
using MediatR;

namespace AvivCRM.Environment.Application.Features.Cities.GetCitiesByParentId;
public class GetCitiesByParentIdQuery : IRequest<IEnumerable<CityDTO>>
{
    public Guid StateId { get; set; }
}

