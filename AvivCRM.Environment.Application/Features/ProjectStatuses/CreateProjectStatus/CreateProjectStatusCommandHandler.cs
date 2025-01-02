using MediatR;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.ProjectStatuses.CreateProjectStatus;

internal class CreateProjectStatusCommandHandler(
    IGenericRepository<Domain.Entities.ProjectStatus> projectStatusRepository) : IRequestHandler<CreateProjectStatusCommand>
{
    public async Task Handle(CreateProjectStatusCommand request, CancellationToken cancellationToken)
    {
        var projectStatus = new Domain.Entities.ProjectStatus
        {
            Name = request.Name,
            ColorCode = request.ColorCode,
            IsDefaultStatus = request.IsDefaultStatus,
            Status = request.Status,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await projectStatusRepository.CreateAsync(projectStatus);
    }
}
















