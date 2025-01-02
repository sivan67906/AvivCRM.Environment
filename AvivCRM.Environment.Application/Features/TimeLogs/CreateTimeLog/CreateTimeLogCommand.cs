using MediatR;

namespace AvivCRM.Environment.Application.Features.TimeLogs.CreateTimeLog;

public class CreateTimeLogCommand : IRequest
{
    public string? CBTimeLogJsonSettings { get; set; }
    public bool IsTimeTrackerReminderEnabled { get; set; }
    public string? TLTime { get; set; }
    public bool IsDailyTimeLogReportEnabled { get; set; }
    public int RoleId { get; set; }
}




























