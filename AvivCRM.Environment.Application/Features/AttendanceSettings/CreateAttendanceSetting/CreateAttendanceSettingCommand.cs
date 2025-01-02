using MediatR;

namespace AvivCRM.Environment.Application.Features.AttendanceSettings.CreateAttendanceSetting;

public class CreateAttendanceSettingCommand : IRequest
{
    public string? AttendanceSettingCode { get; set; }
    public string? AttendanceSettingName { get; set; }
}








































