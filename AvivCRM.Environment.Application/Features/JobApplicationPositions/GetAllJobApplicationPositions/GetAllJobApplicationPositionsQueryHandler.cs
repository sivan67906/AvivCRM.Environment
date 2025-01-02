using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.JobApplicationPositions.GetAllJobApplicationPositions;

internal class GetAllJobApplicationPositionsQueryHandler : IRequestHandler<GetAllJobApplicationPositionsQuery, IEnumerable<JobApplicationPositionDTO>>
{
    private readonly IGenericRepository<JobApplicationPosition> _jobApplicationPositionRepository;
    private readonly IGenericRepository<ProjectReminderPerson> _projectReminderPersonRepository;

    public GetAllJobApplicationPositionsQueryHandler(
        IGenericRepository<JobApplicationPosition> jobApplicationPositionRepository,
        IGenericRepository<ProjectReminderPerson> projectReminderPersonRepository)
    {
        _jobApplicationPositionRepository = jobApplicationPositionRepository;
        _projectReminderPersonRepository = projectReminderPersonRepository;
    }

    public async Task<IEnumerable<JobApplicationPositionDTO>> Handle(GetAllJobApplicationPositionsQuery request, CancellationToken cancellationToken)
    {
        var jobApplicationPosition = await _jobApplicationPositionRepository.GetAllAsync();

        var jobApplicationPositionList = jobApplicationPosition.Select(x => new JobApplicationPositionDTO
        {
            Id = x.Id,
            JAPositionCode = x.JAPositionCode,
            JAPositionName = x.JAPositionName
        }).ToList();

        return jobApplicationPositionList;
    }
}
























