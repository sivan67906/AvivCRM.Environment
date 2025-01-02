using AvivCRM.Environment.Application.DTOs;
using MediatR;

namespace AvivCRM.Environment.Application.Features.ProjectStatuses.GetProjectStatusById
{
    public class GetProjectStatusByIdQuery : IRequest<ProjectStatusDTO>
    {
        public Guid Id { get; set; }
    }
}
















