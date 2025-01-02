using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.RecruitGeneralSettings.CreateRecruitGeneralSetting;

internal class CreateRecruitGeneralSettingCommandHandler(
    IGenericRepository<RecruitGeneralSetting> recruitGeneralSettingRepository) : IRequestHandler<CreateRecruitGeneralSettingCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateRecruitGeneralSettingCommand request, CancellationToken cancellationToken)
    {
        var recruitGeneralSetting = new RecruitGeneralSetting
        {
            GeneralCompanyName = request.GeneralCompanyName,
            GeneralCompanyWebsite = request.GeneralCompanyWebsite,
            GeneralCompanyLogo = request.GeneralCompanyLogo,
            GeneralCompanyLogoPath = request.GeneralCompanyLogoPath,
            GeneralCompanyLogoImageFileName = request.GeneralCompanyLogoImageFileName,
            GeneralAboutCompany = request.GeneralAboutCompany,
            GeneralLegalTerm = request.GeneralLegalTerm,
            GeneralDuplJobApplnRestrictDays = request.GeneralDuplJobApplnRestrictDays,
            GeneralOLReminderToCandidate = request.GeneralOLReminderToCandidate,
            GeneralBGLogo = request.GeneralBGLogo,
            GeneralBGLogoPath = request.GeneralBGLogoPath,
            GeneralBGLogoImageFileName = request.GeneralBGLogoImageFileName,
            GeneralBGColorCode = request.GeneralBGColorCode,
            GeneralCBJsonSettings = request.GeneralCBJsonSettings == null ? "[]" : request.GeneralCBJsonSettings,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await recruitGeneralSettingRepository.CreateAsync(recruitGeneralSetting);
    }
}
























