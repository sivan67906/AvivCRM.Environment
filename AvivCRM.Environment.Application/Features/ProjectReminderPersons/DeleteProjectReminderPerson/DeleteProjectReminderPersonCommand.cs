using MediatR;

namespace AvivCRM.Environment.Application.Features.ProjectReminderPersons.DeleteProjectReminderPerson
{
    public class DeleteProjectReminderPersonCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
























