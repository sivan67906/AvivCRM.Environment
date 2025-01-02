using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.ProjectSettings.GetAllProjectSettings;

internal class GetAllProjectSettingsQueryHandler : IRequestHandler<GetAllProjectSettingsQuery, IEnumerable<ProjectSettingDTO>>
{
    private readonly IGenericRepository<ProjectSetting> _projectSettingRepository;
    private readonly IGenericRepository<ProjectReminderPerson> _projectReminderPersonRepository;

    public GetAllProjectSettingsQueryHandler(
        IGenericRepository<ProjectSetting> projectSettingRepository,
        IGenericRepository<ProjectReminderPerson> projectReminderPersonRepository)
    {
        _projectSettingRepository = projectSettingRepository;
        _projectReminderPersonRepository = projectReminderPersonRepository;
    }

    public async Task<IEnumerable<ProjectSettingDTO>> Handle(GetAllProjectSettingsQuery request, CancellationToken cancellationToken)
    {
        var projectSettings = await _projectSettingRepository.GetAllAsync();
        var projectReminderPersons = await _projectReminderPersonRepository.GetAllAsync();
        var projectReminderPersonsList = projectReminderPersons.Select(x => new ProjectReminderPersonDTO
        {
            Id = x.Id,
            Name = x.Name,
        }).ToList();

        var projectSettingList = projectSettings.Select(x => new ProjectSettingDTO
        {
            Id = x.Id,
            IsSendReminder = x.IsSendReminder,
            RemindBefore = x.RemindBefore,
            ProjectReminderPersonId = x.ProjectReminderPersonId,
            projectReminderPersons = projectReminderPersonsList
        }).ToList();

        return projectSettingList;
    }
}




















