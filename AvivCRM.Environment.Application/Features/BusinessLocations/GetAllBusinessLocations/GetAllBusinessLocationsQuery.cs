using AvivCRM.Environment.Application.DTOs;
using MediatR;

namespace AvivCRM.Environment.Application.Features.BusinessLocations.GetAllBusinessLocations;

public class GetAllBusinessLocationsQuery : IRequest<IEnumerable<BusinessLocationDTO>>
{
}

