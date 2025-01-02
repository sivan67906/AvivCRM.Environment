using MediatR;

namespace AvivCRM.Environment.Application.Features.ProjectStatuses.UpdateProjectStatus;

public class UpdateProjectStatusCommand : IRequest
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? ColorCode { get; set; }
    public bool IsDefaultStatus { get; set; }
    public bool Status { get; set; }
}
















