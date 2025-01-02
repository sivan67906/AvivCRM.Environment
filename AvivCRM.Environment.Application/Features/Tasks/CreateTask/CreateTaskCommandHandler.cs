using MediatR;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Tasks.CreateTask;
public class CreateTaskCommandHandler : IRequestHandler<CreateTaskCommand, Guid>
{
    private readonly IGenericRepository<Domain.Entities.Task> _repository;
    public CreateTaskCommandHandler(IGenericRepository<Domain.Entities.Task> repository)
    {
        _repository = repository;
    }

    public async Task<Guid> Handle(CreateTaskCommand request, CancellationToken cancellationToken)
    {
        var client = new Domain.Entities.Task
        {
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

        await _repository.CreateAsync(client);
        return client.Id;
    }
}
