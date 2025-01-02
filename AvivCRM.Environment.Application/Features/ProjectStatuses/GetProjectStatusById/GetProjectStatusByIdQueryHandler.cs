using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.ProjectStatuses.GetProjectStatusById;

internal class GetProjectStatusByIdQueryHandler : IRequestHandler<GetProjectStatusByIdQuery, ProjectStatusDTO>
{
    private readonly IGenericRepository<Domain.Entities.ProjectStatus> _projectStatusRepository;

    public GetProjectStatusByIdQueryHandler(
        IGenericRepository<Domain.Entities.ProjectStatus> projectStatusRepository) =>
        _projectStatusRepository = projectStatusRepository;

    public async Task<ProjectStatusDTO> Handle(GetProjectStatusByIdQuery request, CancellationToken cancellationToken)
    {
        var projectStatus = await _projectStatusRepository.GetByIdAsync(request.Id);
        if (projectStatus == null) return null;
        return new ProjectStatusDTO
        {
            Id = projectStatus.Id,
            Name = projectStatus.Name,
            ColorCode = projectStatus.ColorCode,
            IsDefaultStatus = projectStatus.IsDefaultStatus,
            Status = projectStatus.Status
        };
    }
}
















