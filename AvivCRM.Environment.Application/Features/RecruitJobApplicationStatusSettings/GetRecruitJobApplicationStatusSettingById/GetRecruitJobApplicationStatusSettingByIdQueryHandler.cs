using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.RecruitJobApplicationStatusSettings.GetRecruitJobApplicationStatusSettingById;

internal class GetRecruitJobApplicationStatusSettingByIdQueryHandler : IRequestHandler<GetRecruitJobApplicationStatusSettingByIdQuery, RecruitJobApplicationStatusSettingDTO>
{
    private readonly IGenericRepository<RecruitJobApplicationStatusSetting> _recruitJobApplicationStatusSettingRepository;

    public GetRecruitJobApplicationStatusSettingByIdQueryHandler(
        IGenericRepository<RecruitJobApplicationStatusSetting> recruitJobApplicationStatusSettingRepository) =>
        _recruitJobApplicationStatusSettingRepository = recruitJobApplicationStatusSettingRepository;

    public async Task<RecruitJobApplicationStatusSettingDTO> Handle(GetRecruitJobApplicationStatusSettingByIdQuery request, CancellationToken cancellationToken)
    {
        var recruitJobApplicationStatusSetting = await _recruitJobApplicationStatusSettingRepository.GetByIdAsync(request.Id);
        if (recruitJobApplicationStatusSetting == null) return null;
        return new RecruitJobApplicationStatusSettingDTO
        {
            Id = recruitJobApplicationStatusSetting.Id,
            JobApplicationPositionId = recruitJobApplicationStatusSetting.JobApplicationPositionId,
            JobApplicationCategoryId = recruitJobApplicationStatusSetting.JobApplicationCategoryId,
            JobApplicationPositionName = recruitJobApplicationStatusSetting.JobApplicationPosition.JAPositionName,
            JobApplicationCategoryName = recruitJobApplicationStatusSetting.JobApplicationCategory.JACategoryName,
            JASStatus = recruitJobApplicationStatusSetting.JASStatus,
            JASColor = recruitJobApplicationStatusSetting.JASColor,
            JASIsModelChecked = recruitJobApplicationStatusSetting.JASIsModelChecked
        };
    }
}
























