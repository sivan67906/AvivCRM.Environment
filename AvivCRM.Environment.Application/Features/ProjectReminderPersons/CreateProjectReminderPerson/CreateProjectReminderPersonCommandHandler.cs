using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.ProjectReminderPersons.CreateProjectReminderPerson;

internal class CreateProjectReminderPersonCommandHandler(
    IGenericRepository<ProjectReminderPerson> projectReminderPersonRepository) : IRequestHandler<CreateProjectReminderPersonCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateProjectReminderPersonCommand request, CancellationToken cancellationToken)
    {
        var projectReminderPerson = new ProjectReminderPerson
        {
            Name = request.Name,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await projectReminderPersonRepository.CreateAsync(projectReminderPerson);
    }
}
























