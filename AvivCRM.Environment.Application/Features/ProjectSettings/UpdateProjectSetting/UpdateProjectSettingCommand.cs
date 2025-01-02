using MediatR;

namespace AvivCRM.Environment.Application.Features.ProjectSettings.UpdateProjectSetting;

public class UpdateProjectSettingCommand : IRequest
{
    public Guid Id { get; set; }
    public bool IsSendReminder { get; set; }
    public int SendReminderTo { get; set; }
    public int ProjectReminderPersonId { get; set; }
    public int RemindBefore { get; set; }
}




















