using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Tasks.GetTaskById;
public class GetTaskByIdQueryHandler : IRequestHandler<GetTaskByIdQuery, TaskDTO>
{
    private readonly IGenericRepository<Domain.Entities.Task> _repository;
    public GetTaskByIdQueryHandler(IGenericRepository<Domain.Entities.Task> repository)
    {
        _repository = repository;
    }

    public async Task<TaskDTO> Handle(GetTaskByIdQuery request, CancellationToken cancellationToken)
    {
        var task = await _repository.GetByIdAsync(request.Id);
        if (task == null) return null;
        return new TaskDTO
        {
            Id = task.Id,
            BeforeXDate = task.BeforeXDate,
            AfterXDate = task.AfterXDate,
            Description = task.Description,
            SendReminderDueDate = task.SendReminderDueDate,
            Status = task.Status,
            Statuss = task.Statuss,
            TaskboardLength = task.TaskboardLength,
            TaskCategory = task.TaskCategory,
            Project = task.Project,
            StartDate = task.StartDate,
            DueDate = task.DueDate,
            AssignedTo = task.AssignedTo,
            Label = task.Label,
            AssignedBy = task.AssignedBy,
            Priority = task.Priority,
            MakePrivate = task.MakePrivate,
            TimeEstimate = task.Comment,
            Comment = task.Comment,
            AddFile = task.AddFile,
            SubTask = task.SubTask,
            Timesheet = task.Timesheet,
            Notes = task.Notes,
            History = task.History,
            HoursLogged = task.HoursLogged,
            CustomFields = task.CustomFields,
            CopyTaskLink = task.CopyTaskLink
        };
    }
}
