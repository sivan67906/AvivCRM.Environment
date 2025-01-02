using MediatR;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.ProjectStatuses.DeleteProjectStatus;

internal class DeleteProjectStatusCommandHandler : IRequestHandler<DeleteProjectStatusCommand>
{
    private readonly IGenericRepository<Domain.Entities.ProjectStatus> _projectStatusRepository;

    public DeleteProjectStatusCommandHandler(
        IGenericRepository<Domain.Entities.ProjectStatus> projectStatusRepository) =>
        _projectStatusRepository = projectStatusRepository;
    public async Task Handle(DeleteProjectStatusCommand request, CancellationToken cancellationToken)
    {
        await _projectStatusRepository.DeleteAsync(request.Id);
    }
}