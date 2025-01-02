using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.RecruitNotificationSettings.GetAllRecruitNotificationSettings;

internal class GetAllRecruitNotificationSettingsQueryHandler : IRequestHandler<GetAllRecruitNotificationSettingsQuery, IEnumerable<RecruitNotificationSettingDTO>>
{
    private readonly IGenericRepository<RecruitNotificationSetting> _recruitNotificationSettingRepository;
    private readonly IGenericRepository<ProjectReminderPerson> _projectReminderPersonRepository;

    public GetAllRecruitNotificationSettingsQueryHandler(
        IGenericRepository<RecruitNotificationSetting> recruitNotificationSettingRepository,
        IGenericRepository<ProjectReminderPerson> projectReminderPersonRepository)
    {
        _recruitNotificationSettingRepository = recruitNotificationSettingRepository;
        _projectReminderPersonRepository = projectReminderPersonRepository;
    }

    public async Task<IEnumerable<RecruitNotificationSettingDTO>> Handle(GetAllRecruitNotificationSettingsQuery request, CancellationToken cancellationToken)
    {
        var recruitNotificationSettings = await _recruitNotificationSettingRepository.GetAllAsync();

        var recruitNotificationSettingList = recruitNotificationSettings.Select(x => new RecruitNotificationSettingDTO
        {
            Id = x.Id,
            CBEMailJsonSettings = x.CBEMailJsonSettings,
            CBEMailNotificationJsonSettings = x.CBEMailNotificationJsonSettings
        }).ToList();

        return recruitNotificationSettingList;
    }
}
























