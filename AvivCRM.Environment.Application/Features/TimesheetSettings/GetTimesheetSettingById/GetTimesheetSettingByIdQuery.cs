//using AvivCRM.Environment.Application.DTOs;
using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.TimesheetSettings.GetTimesheetSettingById
{
    public class GetTimesheetSettingByIdQuery : IRequest<TimesheetSettingDTO>
    {
        public Guid Id { get; set; }
    }
}




































