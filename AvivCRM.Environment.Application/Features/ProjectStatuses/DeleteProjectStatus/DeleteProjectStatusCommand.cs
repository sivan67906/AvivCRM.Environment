using MediatR;

namespace AvivCRM.Environment.Application.Features.ProjectStatuses.DeleteProjectStatus
{
    public class DeleteProjectStatusCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
















