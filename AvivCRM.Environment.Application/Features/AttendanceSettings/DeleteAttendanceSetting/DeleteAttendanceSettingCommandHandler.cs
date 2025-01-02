using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.AttendanceSettings.DeleteAttendanceSetting;

internal class DeleteAttendanceSettingCommandHandler : IRequestHandler<DeleteAttendanceSettingCommand>
{
    private readonly IGenericRepository<AttendanceSetting> _timeLogRepository;

    public DeleteAttendanceSettingCommandHandler(
        IGenericRepository<AttendanceSetting> timeLogRepository) =>
        _timeLogRepository = timeLogRepository;
    public async System.Threading.Tasks.Task Handle(DeleteAttendanceSettingCommand request, CancellationToken cancellationToken)
    {
        await _timeLogRepository.DeleteAsync(request.Id);
    }
}








































