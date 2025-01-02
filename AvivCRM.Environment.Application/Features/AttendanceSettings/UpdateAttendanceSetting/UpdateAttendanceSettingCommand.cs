using MediatR;

namespace AvivCRM.Environment.Application.Features.AttendanceSettings.UpdateAttendanceSetting;

public class UpdateAttendanceSettingCommand : IRequest
{
    public Guid Id { get; set; }
    public string? AttendanceSettingCode { get; set; }
    public string? AttendanceSettingName { get; set; }
}








































