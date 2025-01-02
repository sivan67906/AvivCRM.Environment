using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.RecruitJobApplicationStatusSettings.GetAllRecruitJobApplicationStatusSettings;

internal class GetAllRecruitJobApplicationStatusSettingsQueryHandler : IRequestHandler<GetAllRecruitJobApplicationStatusSettingsQuery, IEnumerable<RecruitJobApplicationStatusSettingDTO>>
{
    private readonly IGenericRepository<RecruitJobApplicationStatusSetting> _recruitJobApplicationStatusSettingRepository;
    private readonly IGenericRepository<ProjectReminderPerson> _projectReminderPersonRepository;

    public GetAllRecruitJobApplicationStatusSettingsQueryHandler(
        IGenericRepository<RecruitJobApplicationStatusSetting> recruitJobApplicationStatusSettingRepository,
        IGenericRepository<ProjectReminderPerson> projectReminderPersonRepository)
    {
        _recruitJobApplicationStatusSettingRepository = recruitJobApplicationStatusSettingRepository;
        _projectReminderPersonRepository = projectReminderPersonRepository;
    }

    public async Task<IEnumerable<RecruitJobApplicationStatusSettingDTO>> Handle(GetAllRecruitJobApplicationStatusSettingsQuery request, CancellationToken cancellationToken)
    {
        var recruitJobApplicationStatusSettings = await _recruitJobApplicationStatusSettingRepository.GetAllAsync();

        var recruitJobApplicationStatusSettingList = recruitJobApplicationStatusSettings.Select(x => new RecruitJobApplicationStatusSettingDTO
        {
            Id = x.Id,
            JobApplicationPositionId = x.JobApplicationPositionId,
            JobApplicationCategoryId = x.JobApplicationCategoryId,
            JobApplicationPositionName = x.JobApplicationPosition.JAPositionName,
            JobApplicationCategoryName = x.JobApplicationCategory.JACategoryName,
            JASStatus = x.JASStatus,
            JASColor = x.JASColor,
            JASIsModelChecked = x.JASIsModelChecked
        }).ToList();

        return recruitJobApplicationStatusSettingList;
    }
}
























