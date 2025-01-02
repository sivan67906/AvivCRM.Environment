using MediatR;

namespace AvivCRM.Environment.Application.Features.AttendanceSettings.DeleteAttendanceSetting
{
    public class DeleteAttendanceSettingCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}








































