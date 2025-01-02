using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.ProjectReminderPersons.UpdateProjectReminderPerson;

internal class UpdateProjectReminderPersonCommandHandler : IRequestHandler<UpdateProjectReminderPersonCommand>
{
    private readonly IGenericRepository<ProjectReminderPerson> _projectReminderPersonRepository;

    public UpdateProjectReminderPersonCommandHandler(
        IGenericRepository<ProjectReminderPerson> projectReminderPersonRepository) =>
        _projectReminderPersonRepository = projectReminderPersonRepository;

    public async System.Threading.Tasks.Task Handle(UpdateProjectReminderPersonCommand request, CancellationToken cancellationToken)
    {
        var projectReminderPerson = new ProjectReminderPerson
        {
            Id = request.Id,
            Name = request.Name,
            UpdatedDate = DateTime.Now
        };

        await _projectReminderPersonRepository.UpdateAsync(projectReminderPerson);
    }
}
























