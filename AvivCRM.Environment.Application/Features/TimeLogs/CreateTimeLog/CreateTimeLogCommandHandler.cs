using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.TimeLogs.CreateTimeLog;

internal class CreateTimeLogCommandHandler(
    IGenericRepository<TimeLog> timeLogRepository) : IRequestHandler<CreateTimeLogCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateTimeLogCommand request, CancellationToken cancellationToken)
    {
        var timeLog = new TimeLog
        {
            CBTimeLogJsonSettings = request.CBTimeLogJsonSettings,
            IsTimeTrackerReminderEnabled = request.IsTimeTrackerReminderEnabled,
            TLTime = request.TLTime,
            IsDailyTimeLogReportEnabled = request.IsDailyTimeLogReportEnabled,
            RoleId = request.RoleId,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await timeLogRepository.CreateAsync(timeLog);
    }
}




























