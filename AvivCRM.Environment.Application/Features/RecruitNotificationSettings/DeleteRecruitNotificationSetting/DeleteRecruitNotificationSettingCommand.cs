using MediatR;

namespace AvivCRM.Environment.Application.Features.RecruitNotificationSettings.DeleteRecruitNotificationSetting
{
    public class DeleteRecruitNotificationSettingCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
























