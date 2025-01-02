using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.TimeLogs.GetAllTimeLogs;

internal class GetAllTimeLogsQueryHandler : IRequestHandler<GetAllTimeLogsQuery, IEnumerable<TimeLogDTO>>
{
    private readonly IGenericRepository<TimeLog> _timeLogRepository;
    public GetAllTimeLogsQueryHandler(
        IGenericRepository<TimeLog> timeLogRepository)
    {
        _timeLogRepository = timeLogRepository;
    }

    public async Task<IEnumerable<TimeLogDTO>> Handle(GetAllTimeLogsQuery request, CancellationToken cancellationToken)
    {
        var timeLogs = await _timeLogRepository.GetAllAsync();
        var timeLogList = timeLogs.Select(x => new TimeLogDTO
        {
            Id = x.Id,
            CBTimeLogJsonSettings = x.CBTimeLogJsonSettings,
            IsTimeTrackerReminderEnabled = x.IsTimeTrackerReminderEnabled,
            TLTime = x.TLTime,
            IsDailyTimeLogReportEnabled = x.IsDailyTimeLogReportEnabled,
            RoleId = x.RoleId
        }).ToList();

        return timeLogList;
    }
}




























