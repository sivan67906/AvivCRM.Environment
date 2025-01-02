using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.TimeLogs.UpdateTimeLog;

internal class UpdateTimeLogCommandHandler : IRequestHandler<UpdateTimeLogCommand>
{
    private readonly IGenericRepository<TimeLog> _timeLogRepository;

    public UpdateTimeLogCommandHandler(
        IGenericRepository<TimeLog> timeLogRepository) =>
        _timeLogRepository = timeLogRepository;

    public async System.Threading.Tasks.Task Handle(UpdateTimeLogCommand request, CancellationToken cancellationToken)
    {
        var timeLog = new TimeLog
        {
            Id = request.Id,
            CBTimeLogJsonSettings = request.CBTimeLogJsonSettings,
            IsTimeTrackerReminderEnabled = request.IsTimeTrackerReminderEnabled,
            TLTime = request.TLTime,
            IsDailyTimeLogReportEnabled = request.IsDailyTimeLogReportEnabled,
            RoleId = request.RoleId,
            UpdatedDate = DateTime.Now
        };

        await _timeLogRepository.UpdateAsync(timeLog);
    }
}




























