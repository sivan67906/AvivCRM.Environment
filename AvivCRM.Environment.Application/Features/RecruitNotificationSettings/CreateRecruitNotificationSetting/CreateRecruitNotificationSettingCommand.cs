using MediatR;

namespace AvivCRM.Environment.Application.Features.RecruitNotificationSettings.CreateRecruitNotificationSetting;

public class CreateRecruitNotificationSettingCommand : IRequest
{
    public string? CBEMailJsonSettings { get; set; }
    public string? CBEMailNotificationJsonSettings { get; set; }
}
























