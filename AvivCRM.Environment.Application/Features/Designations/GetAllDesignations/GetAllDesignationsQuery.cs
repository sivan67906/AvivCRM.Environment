using AvivCRM.Environment.Application.DTOs;
using MediatR;

namespace AvivCRM.Environment.Application.Features.Designations.GetAllDesignations;

public class GetAllDesignationsQuery : IRequest<IEnumerable<DesignationDTO>>
{
}






