using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.JobApplicationPositions.GetJobApplicationPositionById;

internal class GetJobApplicationPositionByIdQueryHandler : IRequestHandler<GetJobApplicationPositionByIdQuery, JobApplicationPositionDTO>
{
    private readonly IGenericRepository<JobApplicationPosition> _jobApplicationPositionRepository;

    public GetJobApplicationPositionByIdQueryHandler(
        IGenericRepository<JobApplicationPosition> jobApplicationPositionRepository) =>
        _jobApplicationPositionRepository = jobApplicationPositionRepository;

    public async Task<JobApplicationPositionDTO> Handle(GetJobApplicationPositionByIdQuery request, CancellationToken cancellationToken)
    {
        var jobApplicationPosition = await _jobApplicationPositionRepository.GetByIdAsync(request.Id);
        if (jobApplicationPosition == null) return null;
        return new JobApplicationPositionDTO
        {
            Id = jobApplicationPosition.Id,
            JAPositionCode = jobApplicationPosition.JAPositionCode,
            JAPositionName = jobApplicationPosition.JAPositionName
        };
    }
}
























