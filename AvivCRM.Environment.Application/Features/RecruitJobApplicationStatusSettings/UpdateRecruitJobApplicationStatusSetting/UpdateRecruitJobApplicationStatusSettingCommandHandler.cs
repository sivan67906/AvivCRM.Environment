using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.RecruitJobApplicationStatusSettings.UpdateRecruitJobApplicationStatusSetting;

internal class UpdateRecruitJobApplicationStatusSettingCommandHandler : IRequestHandler<UpdateRecruitJobApplicationStatusSettingCommand>
{
    private readonly IGenericRepository<RecruitJobApplicationStatusSetting> _recruitJobApplicationStatusSettingRepository;

    public UpdateRecruitJobApplicationStatusSettingCommandHandler(
        IGenericRepository<RecruitJobApplicationStatusSetting> recruitJobApplicationStatusSettingRepository) =>
        _recruitJobApplicationStatusSettingRepository = recruitJobApplicationStatusSettingRepository;

    public async System.Threading.Tasks.Task Handle(UpdateRecruitJobApplicationStatusSettingCommand request, CancellationToken cancellationToken)
    {
        var recruitJobApplicationStatusSetting = new RecruitJobApplicationStatusSetting
        {
            Id = request.Id,
            JobApplicationPositionId = request.JobApplicationPositionId,
            JobApplicationCategoryId = request.JobApplicationCategoryId,
            JASStatus = request.JASStatus,
            JASColor = request.JASColor,
            JASIsModelChecked = request.JASIsModelChecked,
            UpdatedDate = DateTime.Now
        };

        await _recruitJobApplicationStatusSettingRepository.UpdateAsync(recruitJobApplicationStatusSetting);
    }
}
























