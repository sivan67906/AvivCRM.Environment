using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.Plannings.GetPlanningById;
public class GetPlanningByIdQuery : IRequest<PlanningDTO>
{
    public Guid Id { get; set; }
}
