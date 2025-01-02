using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.TimeLogs.GetTimeLogById;

internal class GetTimeLogByIdQueryHandler : IRequestHandler<GetTimeLogByIdQuery, TimeLogDTO>
{
    private readonly IGenericRepository<TimeLog> _timeLogRepository;

    public GetTimeLogByIdQueryHandler(
        IGenericRepository<TimeLog> timeLogRepository) =>
        _timeLogRepository = timeLogRepository;

    public async Task<TimeLogDTO> Handle(GetTimeLogByIdQuery request, CancellationToken cancellationToken)
    {
        var timeLog = await _timeLogRepository.GetByIdAsync(request.Id);
        if (timeLog == null) return null;
        return new TimeLogDTO
        {
            Id = timeLog.Id,
            CBTimeLogJsonSettings = timeLog.CBTimeLogJsonSettings,
            IsTimeTrackerReminderEnabled = timeLog.IsTimeTrackerReminderEnabled,
            TLTime = timeLog.TLTime,
            IsDailyTimeLogReportEnabled = timeLog.IsDailyTimeLogReportEnabled,
            RoleId = timeLog.RoleId
        };
    }
}




























