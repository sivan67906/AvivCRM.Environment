using MediatR;

namespace AvivCRM.Environment.Application.Features.RecruitJobApplicationStatusSettings.DeleteRecruitJobApplicationStatusSetting
{
    public class DeleteRecruitJobApplicationStatusSettingCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
























