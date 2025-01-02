using AvivCRM.Environment.Application.DTOs;
using MediatR;

namespace AvivCRM.Environment.Application.Features.ProjectReminderPersons.GetProjectReminderPersonById
{
    public class GetProjectReminderPersonByIdQuery : IRequest<ProjectReminderPersonDTO>
    {
        public Guid Id { get; set; }
    }
}
























