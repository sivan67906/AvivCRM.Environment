using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Tasks.GetAllTask;
public class GetAllTaskQueryHandler : IRequestHandler<GetAllTaskQuery, IEnumerable<TaskDTO>>
{
    private readonly IGenericRepository<Domain.Entities.Task> _domain;
    public GetAllTaskQueryHandler(IGenericRepository<Domain.Entities.Task> domain)
    {
        _domain = domain;
    }

    public async Task<IEnumerable<TaskDTO>> Handle(GetAllTaskQuery request, CancellationToken cancellationToken)
    {
        var clients = await _domain.GetAllAsync();

        var clientlist = clients.Select(x => new TaskDTO
        {
            Id = x.Id,
            BeforeXDate = x.BeforeXDate,
            AfterXDate = x.AfterXDate,
            Description = x.Description,
            SendReminderDueDate = x.SendReminderDueDate,
            Status = x.Status,
            Statuss = x.Statuss,
            TaskboardLength = x.TaskboardLength,
            TaskCategory = x.TaskCategory,
            Project = x.Project,
            StartDate = x.StartDate,
            DueDate = x.DueDate,
            AssignedTo = x.AssignedTo,
            Label = x.Label,
            AssignedBy = x.AssignedBy,
            Priority = x.Priority,
            MakePrivate = x.MakePrivate,
            TimeEstimate = x.Comment,
            Comment = x.Comment,
            AddFile = x.AddFile,
            SubTask = x.SubTask,
            Timesheet = x.Timesheet,
            Notes = x.Notes,
            History = x.History,
            HoursLogged = x.HoursLogged,
            CustomFields = x.CustomFields,
            CopyTaskLink = x.CopyTaskLink
        }).ToList();

        return clientlist;
    }
}
