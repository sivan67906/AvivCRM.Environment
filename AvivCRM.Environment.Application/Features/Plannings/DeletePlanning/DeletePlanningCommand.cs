using MediatR;

namespace AvivCRM.Environment.Application.Features.Plannings.DeletePlanning;
public class DeletePlanningCommand : IRequest
{
    public Guid Id { get; set; }
}
