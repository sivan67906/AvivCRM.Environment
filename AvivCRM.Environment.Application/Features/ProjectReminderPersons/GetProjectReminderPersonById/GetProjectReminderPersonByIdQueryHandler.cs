using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.ProjectReminderPersons.GetProjectReminderPersonById;

internal class GetProjectReminderPersonByIdQueryHandler : IRequestHandler<GetProjectReminderPersonByIdQuery, ProjectReminderPersonDTO>
{
    private readonly IGenericRepository<ProjectReminderPerson> _projectReminderPersonRepository;

    public GetProjectReminderPersonByIdQueryHandler(
        IGenericRepository<ProjectReminderPerson> projectReminderPersonRepository) =>
        _projectReminderPersonRepository = projectReminderPersonRepository;

    public async Task<ProjectReminderPersonDTO> Handle(GetProjectReminderPersonByIdQuery request, CancellationToken cancellationToken)
    {
        var projectReminderPerson = await _projectReminderPersonRepository.GetByIdAsync(request.Id);
        if (projectReminderPerson == null) return null;
        return new ProjectReminderPersonDTO
        {
            Id = projectReminderPerson.Id,
            Name = projectReminderPerson.Name
        };
    }
}
























