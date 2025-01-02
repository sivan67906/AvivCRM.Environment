using MediatR;

namespace AvivCRM.Environment.Application.Features.ProjectReminderPersons.UpdateProjectReminderPerson;

public class UpdateProjectReminderPersonCommand : IRequest
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
}
























