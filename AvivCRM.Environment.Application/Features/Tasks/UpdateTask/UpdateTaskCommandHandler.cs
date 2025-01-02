using AvivCRM.Environment.Domain.Interfaces;
using MediatR;

namespace AvivCRM.Environment.Application.Features.Tasks.UpdateTask;
public class UpdateTaskCommandHandler : IRequestHandler<UpdateTaskCommand, Guid>
{
    private readonly IGenericRepository<Domain.Entities.Task> _repository;
    public UpdateTaskCommandHandler(IGenericRepository<Domain.Entities.Task> repository)
    {
        _repository = repository;
    }

    public async Task<Guid> Handle(UpdateTaskCommand request, CancellationToken cancellationToken)
    {
        var product = new Domain.Entities.Task
        {
            Id = request.Id,
            BeforeXDate = request.BeforeXDate,
            AfterXDate = request.AfterXDate,
            Description = request.Description,
            SendReminderDueDate = request.SendReminderDueDate,
            Status = request.Status,
            Statuss = request.Statuss,
            TaskboardLength = request.TaskboardLength,
            TaskCategory = request.TaskCategory,
            Project = request.Project,
            StartDate = request.StartDate,
            DueDate = request.DueDate,
            AssignedTo = request.AssignedTo,
            Label = request.Label,
            AssignedBy = request.AssignedBy,
            Priority = request.Priority,
            MakePrivate = request.MakePrivate,
            TimeEstimate = request.Comment,
            Comment = request.Comment,
            AddFile = request.AddFile,
            SubTask = request.SubTask,
            Timesheet = request.Timesheet,
            Notes = request.Notes,
            History = request.History,
            HoursLogged = request.HoursLogged,
            CustomFields = request.CustomFields,
            CopyTaskLink = request.CopyTaskLink
        };
        await _repository.UpdateAsync(product);
        return request.Id;
    }
}
