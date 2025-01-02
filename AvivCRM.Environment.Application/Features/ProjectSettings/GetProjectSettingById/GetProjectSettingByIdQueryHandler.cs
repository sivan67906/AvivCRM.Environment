using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.ProjectSettings.GetProjectSettingById;

internal class GetProjectSettingByIdQueryHandler : IRequestHandler<GetProjectSettingByIdQuery, ProjectSettingDTO>
{
    private readonly IGenericRepository<ProjectSetting> _projectSettingRepository;

    public GetProjectSettingByIdQueryHandler(
        IGenericRepository<ProjectSetting> projectSettingRepository) =>
        _projectSettingRepository = projectSettingRepository;

    public async Task<ProjectSettingDTO> Handle(GetProjectSettingByIdQuery request, CancellationToken cancellationToken)
    {
        var projectSetting = await _projectSettingRepository.GetByIdAsync(request.Id);
        if (projectSetting == null) return null;
        return new ProjectSettingDTO
        {
            Id = projectSetting.Id,
            IsSendReminder = projectSetting.IsSendReminder,
            RemindBefore = projectSetting.RemindBefore
        };
    }
}




















