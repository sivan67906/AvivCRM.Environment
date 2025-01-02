using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.RecruitGeneralSettings.UpdateRecruitGeneralSetting;

internal class UpdateRecruitGeneralSettingCommandHandler : IRequestHandler<UpdateRecruitGeneralSettingCommand>
{
    private readonly IGenericRepository<RecruitGeneralSetting> _recruitGeneralSettingRepository;

    public UpdateRecruitGeneralSettingCommandHandler(
        IGenericRepository<RecruitGeneralSetting> recruitGeneralSettingRepository) =>
        _recruitGeneralSettingRepository = recruitGeneralSettingRepository;

    public async System.Threading.Tasks.Task Handle(UpdateRecruitGeneralSettingCommand request, CancellationToken cancellationToken)
    {
        var recruitGeneralSetting = new RecruitGeneralSetting
        {
            Id = request.Id,
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
            UpdatedDate = DateTime.Now
        };

        await _recruitGeneralSettingRepository.UpdateAsync(recruitGeneralSetting);
    }
}
























