using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;
using MediatR;

namespace AvivCRM.Environment.Application.Features.RecruitJobApplicationStatusSettings.CreateRecruitJobApplicationStatusSetting;

internal class CreateRecruitJobApplicationStatusSettingCommandHandler(
    IGenericRepository<RecruitJobApplicationStatusSetting> recruitJobApplicationStatusSettingRepository) : IRequestHandler<CreateRecruitJobApplicationStatusSettingCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateRecruitJobApplicationStatusSettingCommand request, CancellationToken cancellationToken)
    {
        var recruitJobApplicationStatusSetting = new RecruitJobApplicationStatusSetting
        {
            JobApplicationPositionId = request.JobApplicationPositionId,
            JobApplicationCategoryId = request.JobApplicationCategoryId,
            JASStatus = request.JASStatus,
            JASColor = request.JASColor,
            JASIsModelChecked = request.JASIsModelChecked,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await recruitJobApplicationStatusSettingRepository.CreateAsync(recruitJobApplicationStatusSetting);
    }
}
























