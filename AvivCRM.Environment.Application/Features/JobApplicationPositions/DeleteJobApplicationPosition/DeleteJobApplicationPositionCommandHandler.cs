using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;
using MediatR;

namespace AvivCRM.Environment.Application.Features.JobApplicationPositions.DeleteJobApplicationPosition;

internal class DeleteJobApplicationPositionCommandHandler : IRequestHandler<DeleteJobApplicationPositionCommand>
{
    private readonly IGenericRepository<JobApplicationPosition> _jobApplicationPositionRepository;

    public DeleteJobApplicationPositionCommandHandler(
        IGenericRepository<JobApplicationPosition> jobApplicationPositionRepository) =>
        _jobApplicationPositionRepository = jobApplicationPositionRepository;
    public async System.Threading.Tasks.Task Handle(DeleteJobApplicationPositionCommand request, CancellationToken cancellationToken)
    {
        await _jobApplicationPositionRepository.DeleteAsync(request.Id);
    }
}
























