using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.ProjectReminderPersons.DeleteProjectReminderPerson;

internal class DeleteProjectReminderPersonCommandHandler : IRequestHandler<DeleteProjectReminderPersonCommand>
{
    private readonly IGenericRepository<ProjectReminderPerson> _projectReminderPersonRepository;

    public DeleteProjectReminderPersonCommandHandler(
        IGenericRepository<ProjectReminderPerson> projectReminderPersonRepository) =>
        _projectReminderPersonRepository = projectReminderPersonRepository;
    public async System.Threading.Tasks.Task Handle(DeleteProjectReminderPersonCommand request, CancellationToken cancellationToken)
    {
        await _projectReminderPersonRepository.DeleteAsync(request.Id);
    }
}
























