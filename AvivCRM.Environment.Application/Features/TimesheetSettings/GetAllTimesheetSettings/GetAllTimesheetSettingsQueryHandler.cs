using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.TimesheetSettings.GetAllTimesheetSettings;

internal class GetAllTimesheetSettingsQueryHandler : IRequestHandler<GetAllTimesheetSettingsQuery, IEnumerable<TimesheetSettingDTO>>
{
    private readonly IGenericRepository<TimesheetSetting> _timesheetSettingRepository;

    public GetAllTimesheetSettingsQueryHandler(
        IGenericRepository<TimesheetSetting> timesheetSettingRepository)
    {
        _timesheetSettingRepository = timesheetSettingRepository;
    }

    public async Task<IEnumerable<TimesheetSettingDTO>> Handle(GetAllTimesheetSettingsQuery request, CancellationToken cancellationToken)
    {
        var timesheetSettings = await _timesheetSettingRepository.GetAllAsync();
        var timesheetSettingList = timesheetSettings.Select(x => new TimesheetSettingDTO
        {
            Id = x.Id,
            ProjectId = x.ProjectId,
            //ProjectName = x.ProjectName,
            TaskId = x.TaskId,
            //TaskName = x.TaskName,
            EmployeeId = x.EmployeeId,
            //EmployeeName = x.EmployeeName,
            StartDate = x.StartDate,
            StartTime = x.StartTime,
            StartDateTime = x.StartDateTime,
            EndDate = x.EndDate,
            EndTime = x.EndTime,
            EndDateTime = x.EndDateTime,
            Memo = x.Memo,
            TotalHours = x.TotalHours
        }).ToList();

        return timesheetSettingList;
    }
}




































