using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.JobApplicationPositions.UpdateJobApplicationPosition;

internal class UpdateJobApplicationPositionCommandHandler : IRequestHandler<UpdateJobApplicationPositionCommand>
{
    private readonly IGenericRepository<JobApplicationPosition> _jobApplicationPositionRepository;

    public UpdateJobApplicationPositionCommandHandler(
        IGenericRepository<JobApplicationPosition> jobApplicationPositionRepository) =>
        _jobApplicationPositionRepository = jobApplicationPositionRepository;

    public async System.Threading.Tasks.Task Handle(UpdateJobApplicationPositionCommand request, CancellationToken cancellationToken)
    {
        var jobApplicationPosition = new JobApplicationPosition
        {
            Id = request.Id,
            JAPositionCode = request.JAPositionCode,
            JAPositionName = request.JAPositionName,
            UpdatedDate = DateTime.Now
        };

        await _jobApplicationPositionRepository.UpdateAsync(jobApplicationPosition);
    }
}
























