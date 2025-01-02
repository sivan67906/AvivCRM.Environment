using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.RecruitGeneralSettings.GetAllRecruitGeneralSettings;

internal class GetAllRecruitGeneralSettingsQueryHandler : IRequestHandler<GetAllRecruitGeneralSettingsQuery, IEnumerable<RecruitGeneralSettingDTO>>
{
    private readonly IGenericRepository<RecruitGeneralSetting> _recruitGeneralSettingRepository;
    private readonly IGenericRepository<ProjectReminderPerson> _projectReminderPersonRepository;

    public GetAllRecruitGeneralSettingsQueryHandler(
        IGenericRepository<RecruitGeneralSetting> recruitGeneralSettingRepository,
        IGenericRepository<ProjectReminderPerson> projectReminderPersonRepository)
    {
        _recruitGeneralSettingRepository = recruitGeneralSettingRepository;
        _projectReminderPersonRepository = projectReminderPersonRepository;
    }

    public async Task<IEnumerable<RecruitGeneralSettingDTO>> Handle(GetAllRecruitGeneralSettingsQuery request, CancellationToken cancellationToken)
    {
        var recruitGeneralSettings = await _recruitGeneralSettingRepository.GetAllAsync();

        var recruitGeneralSettingList = recruitGeneralSettings.Select(x => new RecruitGeneralSettingDTO
        {
            Id = x.Id,
            GeneralCompanyName = x.GeneralCompanyName,
            GeneralCompanyWebsite = x.GeneralCompanyWebsite,
            GeneralCompanyLogo = x.GeneralCompanyLogo,
            GeneralCompanyLogoPath = x.GeneralCompanyLogoPath,
            GeneralCompanyLogoImageFileName = x.GeneralCompanyLogoImageFileName,
            GeneralAboutCompany = x.GeneralAboutCompany,
            GeneralLegalTerm = x.GeneralLegalTerm,
            GeneralDuplJobApplnRestrictDays = x.GeneralDuplJobApplnRestrictDays,
            GeneralOLReminderToCandidate = x.GeneralOLReminderToCandidate,
            GeneralBGLogo = x.GeneralBGLogo,
            GeneralBGLogoPath = x.GeneralBGLogoPath,
            GeneralBGLogoImageFileName = x.GeneralBGLogoImageFileName,
            GeneralBGColorCode = x.GeneralBGColorCode,
            GeneralCBJsonSettings = x.GeneralCBJsonSettings
        }).ToList();

        return recruitGeneralSettingList;
    }
}
























