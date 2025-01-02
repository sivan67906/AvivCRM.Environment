using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.Plannings.GetAllPlannings;
public class GetAllPlanningsQuery : IRequest<IEnumerable<PlanningDTO>>
{

}
