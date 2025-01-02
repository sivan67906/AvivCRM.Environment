using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.TimesheetSettings.GetTimesheetSettingById;

internal class GetTimesheetSettingByIdQueryHandler : IRequestHandler<GetTimesheetSettingByIdQuery, TimesheetSettingDTO>
{
    private readonly IGenericRepository<TimesheetSetting> _timesheetSettingRepository;

    public GetTimesheetSettingByIdQueryHandler(
        IGenericRepository<TimesheetSetting> timesheetSettingRepository) =>
        _timesheetSettingRepository = timesheetSettingRepository;

    public async Task<TimesheetSettingDTO> Handle(GetTimesheetSettingByIdQuery request, CancellationToken cancellationToken)
    {
        var timesheetSetting = await _timesheetSettingRepository.GetByIdAsync(request.Id);
        if (timesheetSetting == null) return null;
        return new TimesheetSettingDTO
        {
            Id = timesheetSetting.Id,
            ProjectId = timesheetSetting.ProjectId,
            //ProjectName = timesheetSetting.ProjectName,
            TaskId = timesheetSetting.TaskId,
            //TaskName = timesheetSetting.TaskName,
            EmployeeId = timesheetSetting.EmployeeId,
            //EmployeeName = timesheetSetting.EmployeeName,
            StartDate = timesheetSetting.StartDate,
            StartTime = timesheetSetting.StartTime,
            StartDateTime = timesheetSetting.StartDateTime,
            EndDate = timesheetSetting.EndDate,
            EndTime = timesheetSetting.EndTime,
            EndDateTime = timesheetSetting.EndDateTime,
            Memo = timesheetSetting.Memo,
            TotalHours = timesheetSetting.TotalHours
        };
    }
}




































