//using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Application.DTOs;
using MediatR;

namespace AvivCRM.Environment.Application.Features.AttendanceSettings.GetAttendanceSettingById
{
    public class GetAttendanceSettingByIdQuery : IRequest<AttendanceSettingDTO>
    {
        public Guid Id { get; set; }
    }
}








































