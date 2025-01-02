using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.JobApplicationPositions.CreateJobApplicationPosition;

internal class CreateJobApplicationPositionCommandHandler(
    IGenericRepository<JobApplicationPosition> jobApplicationPositionRepository) : IRequestHandler<CreateJobApplicationPositionCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateJobApplicationPositionCommand request, CancellationToken cancellationToken)
    {
        var jobApplicationPosition = new JobApplicationPosition
        {
            JAPositionCode = request.JAPositionCode,
            JAPositionName = request.JAPositionName,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await jobApplicationPositionRepository.CreateAsync(jobApplicationPosition);
    }
}
























