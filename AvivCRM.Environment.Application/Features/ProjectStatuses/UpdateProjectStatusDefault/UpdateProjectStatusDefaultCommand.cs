using MediatR;

namespace AvivCRM.Environment.Application.Features.ProjectStatuses.UpdateProjectStatusDefault;
public class UpdateProjectStatusDefaultCommand : IRequest
{
    public Guid Id { get; set; }
}
