using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.ProjectStatuses.GetAllProjectStatuss;

internal class GetAllProjectStatusesQueryHandler : IRequestHandler<GetAllProjectStatusesQuery, IEnumerable<ProjectStatusDTO>>
{
    private readonly IGenericRepository<Domain.Entities.ProjectStatus> _projectStatusRepository;

    public GetAllProjectStatusesQueryHandler(
        IGenericRepository<Domain.Entities.ProjectStatus> projectStatusRepository) =>
        _projectStatusRepository = projectStatusRepository;

    public async Task<IEnumerable<ProjectStatusDTO>> Handle(GetAllProjectStatusesQuery request, CancellationToken cancellationToken)
    {
        var companies = await _projectStatusRepository.GetAllAsync();

        var projectStatusList = companies.Select(x => new ProjectStatusDTO
        {
            Id = x.Id,
            Name = x.Name,
            ColorCode = x.ColorCode,
            IsDefaultStatus = x.IsDefaultStatus,
            Status = x.Status
        }).ToList();

        return projectStatusList;
    }
}
















