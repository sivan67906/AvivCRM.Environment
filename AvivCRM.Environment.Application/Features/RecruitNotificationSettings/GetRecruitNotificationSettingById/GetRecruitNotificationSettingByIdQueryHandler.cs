using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.RecruitNotificationSettings.GetRecruitNotificationSettingById;

internal class GetRecruitNotificationSettingByIdQueryHandler : IRequestHandler<GetRecruitNotificationSettingByIdQuery, RecruitNotificationSettingDTO>
{
    private readonly IGenericRepository<RecruitNotificationSetting> _recruitNotificationSettingRepository;

    public GetRecruitNotificationSettingByIdQueryHandler(
        IGenericRepository<RecruitNotificationSetting> recruitNotificationSettingRepository) =>
        _recruitNotificationSettingRepository = recruitNotificationSettingRepository;

    public async Task<RecruitNotificationSettingDTO> Handle(GetRecruitNotificationSettingByIdQuery request, CancellationToken cancellationToken)
    {
        var recruitNotificationSetting = await _recruitNotificationSettingRepository.GetByIdAsync(request.Id);
        if (recruitNotificationSetting == null) return null;
        return new RecruitNotificationSettingDTO
        {
            Id = recruitNotificationSetting.Id,
            CBEMailJsonSettings = recruitNotificationSetting.CBEMailJsonSettings,
            CBEMailNotificationJsonSettings = recruitNotificationSetting.CBEMailNotificationJsonSettings
        };
    }
}
























