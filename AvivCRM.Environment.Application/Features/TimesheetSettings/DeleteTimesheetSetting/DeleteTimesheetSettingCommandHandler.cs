using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.TimesheetSettings.DeleteTimesheetSetting;

internal class DeleteTimesheetSettingCommandHandler : IRequestHandler<DeleteTimesheetSettingCommand>
{
    private readonly IGenericRepository<TimesheetSetting> _timeSheetSettingRepository;

    public DeleteTimesheetSettingCommandHandler(
        IGenericRepository<TimesheetSetting> timeSheetSettingRepository) =>
        _timeSheetSettingRepository = timeSheetSettingRepository;
    public async System.Threading.Tasks.Task Handle(DeleteTimesheetSettingCommand request, CancellationToken cancellationToken)
    {
        await _timeSheetSettingRepository.DeleteAsync(request.Id);
    }
}




































