using MediatR;

namespace AvivCRM.Environment.Application.Features.ProjectStatuses.CreateProjectStatus;

public class CreateProjectStatusCommand : IRequest
{
    public string? Name { get; set; }
    public string? ColorCode { get; set; }
    public bool IsDefaultStatus { get; set; }
    public bool Status { get; set; }
}
















