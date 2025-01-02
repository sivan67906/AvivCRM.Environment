using MediatR;

namespace AvivCRM.Environment.Application.Features.TimesheetSettings.DeleteTimesheetSetting
{
    public class DeleteTimesheetSettingCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}




































